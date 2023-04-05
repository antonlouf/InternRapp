using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Commands.CreateInternShip;
using backend.Application.InternShips.Commands.UpdateInternShip;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Common;
public class ValidationFunctions
{
    readonly IApplicationDbContext _dbContext;

    public ValidationFunctions(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public static bool IsVersionValid(IList<LanguageSpecificUpdateInternShipDto> arg)
    {
        foreach (var version in arg)
        {
            if (version.NeededKnowledge == null || version.NeededKnowledge == "") return false;
            if (version.TitleContent == null || version.TitleContent == "") return false;
            if (version.Comment == null || version.Comment == "") return false;
            if (version.Content == null || version.Content == "") return false;
            if (version.Description == null || version.Description == "") return false;
            if (version.Location == null || version.Location == "") return false;
            if (version.KnowledgeToDevelop == null || version.KnowledgeToDevelop == "") return false;

        }
        return true;
    }
    public static bool IsVersionValid(IList<LanguageSpecificInternShipDto> arg)
    {
        foreach (var version in arg)
        {
            if (version.NeededKnowledge == null || version.NeededKnowledge == "") return false;
            if (version.TitleContent == null || version.TitleContent == "") return false;
            if (version.Comment == null || version.Comment == "") return false;
            if (version.Content == null || version.Content == "") return false;
            if (version.Description == null || version.Description == "") return false;
            if (version.Location == null || version.Location == "") return false;
            if (version.KnowledgeToDevelop == null || version.KnowledgeToDevelop == "") return false;
        }
        return true;
    }
    public async Task<bool> CheckIfLanguageIdExists(IList<LanguageSpecificInternShipDto> dtos, CancellationToken arg2)
    {
        for (int i = 0; i < dtos.Count; i++)
        {
            var result = await _dbContext.Languages.Where(x => x.Id == dtos[i].LanguageId).ToListAsync();
            if (result == null) return false;
        }
        return true;

    }
    public async Task<bool> CheckIfLanguageIdExists(IList<LanguageSpecificUpdateInternShipDto> dtos, CancellationToken arg2)
    {
        for (int i = 0; i < dtos.Count; i++)
        {
            var result = await _dbContext.Languages.Where(x => x.Id == dtos[i].LanguageId).ToListAsync();
            if (result == null) return false;
        }
        return true;

    }
    public async Task<bool> CheckIfLocationIdExists(int arg1, CancellationToken arg2)
    {
        //should later be placed inside the getbyidquery of locations this is just temporary
        var result = await _dbContext.Locations.Where(x => x.Id == arg1).ToListAsync();
        return result != null;
    }

    public async Task<bool> CheckIfUnitIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _dbContext.InternShips.FirstOrDefaultAsync(x => x.Id == arg1);
        return result != null;
    }
    public async Task<bool> CheckIfInternShipIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _dbContext.InternShips.FirstOrDefaultAsync(x => x.Id == arg1);
        return result != null;
    }
    public async Task<bool> CheckIfTranslationIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _dbContext.Translations.FirstOrDefaultAsync(x => x.Id == arg1);
        return result != null;
    }
    public async Task<bool> CheckIfTranslationIdExists(List<LanguageSpecificUpdateInternShipDto> dto, CancellationToken arg2)
    {
        foreach (var item in dto)
        {
            var result = await _dbContext.Translations.FirstOrDefaultAsync(x => x.LanguageId == item.LanguageId);
            if (result == null) return false;
        }

        return true;
    }
    public bool IsValidSchoolYear(string arg)
    {
        var currentYear = DateTime.Now.Year;
        var differenceWithMinimalYear = currentYear - 2020;
        for (int i = 0; i <= differenceWithMinimalYear; i++)
        {
            var yearRange = $"{2020 + i}-{2020 + i + 1}";
            if (yearRange == arg) return true;
        }

        return false;
    }
}
