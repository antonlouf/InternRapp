using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Common;
public class LocationDto:IMapFrom<Location>
{
    public int id { get; set; }
    public string city { get; set; }
    public string streetname { get; set; }
    public int housenumber { get; set; }
    public string zipcode { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Location, LocationDto>();
    }
}
