using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Common;
public class LocationDto:IMapFrom<Location>
{
    public int Id { get; set; }
    public string City { get; set; }
    public string Streetname { get; set; }
    public int Housenumber { get; set; }
    public string Zipcode { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Location, LocationDto>();
    }
}
