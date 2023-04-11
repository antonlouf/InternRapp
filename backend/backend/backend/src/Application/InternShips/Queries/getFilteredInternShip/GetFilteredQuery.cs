using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using backend.Application.Common.Paging;
using backend.Application.InternShips.Common;
using backend.Application.InternShips.Queries.GetAllInternShips;
using backend.Domain.Entities;
using MediatR;

namespace backend.Application.InternShips.Queries.getFilteredInternShip;

public class GetFilteredQuery : IRequest<PagedList<InternShipListDto>>
{
    public InternShipFilteredDto Dto { get; set; }
}
public class GetFilteredInterShipsQueryHandler : IRequestHandler<GetFilteredQuery, PagedList<InternShipListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private IMapper _iMapper;

    public GetFilteredInterShipsQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _iMapper = mapper;
    }

    public async Task<PagedList<InternShipListDto>> Handle(GetFilteredQuery request, CancellationToken cancellationToken)
    {
        return await PagedList<InternShipListDto>.ToPagedList(_dbContext.InternShips
            .Where(internschip => (request.Dto.UnitId == null || request.Dto.UnitId.Count == 0 || request.Dto.UnitId.Contains(internschip.UnitId))
                && (request.Dto.SchoolYear == null || request.Dto.SchoolYear.Count == 0 || request.Dto.SchoolYear.Contains(internschip.SchoolYear))
                && (request.Dto.LanguageId == null || request.Dto.LanguageId.Count == 0 || internschip.Translations.Any(trnsl => request.Dto.LanguageId.Contains(trnsl.LanguageId))))
            .ProjectTo<InternShipListDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
    }

}