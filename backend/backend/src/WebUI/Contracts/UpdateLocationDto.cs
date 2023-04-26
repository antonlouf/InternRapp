using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Common;
using backend.Domain.Entities;

namespace backend.Application.Locations.Commands.UpdateLocation;
public class UpdateLocationDto:IMapFrom<Location>
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
