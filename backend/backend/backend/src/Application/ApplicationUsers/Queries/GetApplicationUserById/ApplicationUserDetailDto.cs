using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;
using backend.Domain.Enums;

namespace backend.Application.ApplicationUsers.Queries.GetById;

public class ApplicationUserDetailDto:IMapFrom<ApplicationUser>
{
    public string Email { get; set; }
    public Role Role { get; set; }

    public void Mapping(Profile profile)
    {
         profile.CreateMap<ApplicationUser,ApplicationUserDetailDto>();
    }
}