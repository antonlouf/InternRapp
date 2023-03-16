using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Common;
public class LocationDto:IMapFrom<Location>
{
    public int Id { get; set; }
    public string City { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public string ZipCode { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Location, LocationDto>();
    }
}
