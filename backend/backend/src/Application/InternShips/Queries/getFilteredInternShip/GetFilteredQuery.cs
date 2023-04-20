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
using backend.Domain.Entities;
using MediatR;
using backend.Application.InternShips.Queries.GetAllInternShips; 

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
            .Where(internschip => (request.Dto.UnitIds == null || request.Dto.UnitIds.Count == 0 || request.Dto.UnitIds.Contains(internschip.UnitId))
                && (request.Dto.SchoolYear == null || request.Dto.SchoolYear.Count == 0 || request.Dto.SchoolYear.Contains(internschip.SchoolYear))
                && (request.Dto.LanguageIds == null || request.Dto.LanguageIds.Count == 0 || internschip.Translations.Any(trnsl => request.Dto.LanguageIds.Contains(trnsl.LanguageId))))
            .ProjectTo<InternShipListDto>(_iMapper.ConfigurationProvider), request.Dto.PageIndex, request.Dto.PageSize);
    }

}