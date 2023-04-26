using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Application.InternShips.Queries.getFilteredInternShip;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetExportInternShipData;
public class GetExportInterShipQuery: IRequest<IList<InternShipListDto>>
{
    public InternshipExportDto Dto { get; set; }
}

public class GetExportInterShipQueryHandler : IRequestHandler<GetExportInterShipQuery, IList<InternShipListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetExportInterShipQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<IList<InternShipListDto>> Handle(GetExportInterShipQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.InternShips
           .Where(internschip => (request.Dto.UnitId == null || request.Dto.UnitId.Count == 0 || request.Dto.UnitId.Contains(internschip.UnitId))
               && (request.Dto.SchoolYear == null || request.Dto.SchoolYear.Count == 0 || request.Dto.SchoolYear.Contains(internschip.SchoolYear))
               && (request.Dto.LanguageId == null || request.Dto.LanguageId.Count == 0 || internschip.Translations.Any(trnsl => request.Dto.LanguageId.Contains(trnsl.LanguageId))))
           .ProjectTo<InternShipListDto>(_iMapper.ConfigurationProvider).AsNoTracking().ToListAsync();
    }
}
