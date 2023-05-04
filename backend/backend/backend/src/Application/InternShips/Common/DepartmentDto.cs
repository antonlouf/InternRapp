using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Common;
public class DepartmentDto:IMapFrom<Department>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<string> ManagerEmails { get; set; }

    public List<InternShip> InternShips { get; set; }
    public void Mapping(Profile profile)
    {
       profile.CreateMap<Department, DepartmentDto>();
    }


}
