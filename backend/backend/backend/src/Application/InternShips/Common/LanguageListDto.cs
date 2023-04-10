using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.Common.Mappings;
using backend.Domain.Entities;

namespace backend.Application.InternShips.Common;
    //Something to think about -> Automapper hides alot (blackbox) and is a pain in the * to debug.
    // is it really needed for such simple mapping?
public class LanguageListDto:IMapFrom<Language>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Language, LanguageListDto>();
    }
}
