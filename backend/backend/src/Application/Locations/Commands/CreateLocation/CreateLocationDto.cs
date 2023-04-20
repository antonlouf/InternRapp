using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Application.InternShips.Common;
using backend.Domain.Entities;

namespace backend.Application.Locations.Commands.CreateLocation;
public class CreateLocationDto
{
    public string city { get; set; }
    public string streetname { get; set; }
    public int housenumber { get; set; }
    public string zipcode { get; set; }

   
}
