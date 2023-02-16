using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Queries.GetAllInternShips;
public class GetAllQuery : IRequest<IEnumerable<InternShipListDto>>
{
}
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, IEnumerable<InternShipListDto>>
{
    private readonly IApplicationDbContext _dbContext;
    private readonly IMapper _iMapper;
    public GetAllQueryHandler(IApplicationDbContext dbContext, IMapper iMapper)
    {
        _dbContext = dbContext;
        _iMapper = iMapper;
    }

    public async Task<IEnumerable<InternShipListDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var result = await _dbContext.InternShips.Include(x => x.Location).Include(x => x.Unit).ProjectTo<InternShipListDto>(_iMapper.ConfigurationProvider).ToListAsync();
        //this call should later be placed inside the query (translations)
        var translations = await _dbContext.Translations.Include(x => x.Language).ProjectTo<TranslationDto>(_iMapper.ConfigurationProvider).ToListAsync();
        foreach (var internship in result)
        {

            foreach (var translation in translations)
            {
                if (internship.InternShipId == translation.Id)
                {
                    if (internship.Versions == null)
                        internship.Versions = new List<TranslationDto>();
                    internship.Versions.Add(translation);
                }
            }
        }
        return result;
    }
}
