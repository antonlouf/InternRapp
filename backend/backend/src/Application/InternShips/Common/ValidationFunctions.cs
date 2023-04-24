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

    public static bool IsVersionValid(IList<TranslationUpdateInternshipDto> arg)
    {
        foreach (var version in arg)
        {
            if (String.IsNullOrEmpty(version.NeededKnowledge)) return false;
            if (String.IsNullOrEmpty(version.TitleContent)) return false;
            if (String.IsNullOrEmpty(version.Comment)) return false;
            if (String.IsNullOrEmpty(version.Content)) return false;
            if (String.IsNullOrEmpty(version.Description)) return false;
            if (String.IsNullOrEmpty(version.Location)) return false;
            if (String.IsNullOrEmpty(version.KnowledgeToDevelop)) return false;

        }
        return true;
    }
    public static bool IsVersionValid(IList<TranslationCreateInternshipDto> arg)
    {
        foreach (var version in arg)
        {
            if (String.IsNullOrEmpty(version.NeededKnowledge)) return false;
            if (String.IsNullOrEmpty(version.TitleContent)) return false;
            if (String.IsNullOrEmpty(version.Comment)) return false;
            if (String.IsNullOrEmpty(version.Content)) return false;
            if (String.IsNullOrEmpty(version.Description)) return false;
            if (String.IsNullOrEmpty(version.Location)) return false;
            if (String.IsNullOrEmpty(version.KnowledgeToDevelop)) return false;
        }
        return true;
    }
    public async Task<bool> CheckIfLanguageIdExists(IList<TranslationCreateInternshipDto> dtos, CancellationToken arg2)
    {
        var languageIds = dtos.Select(x => x.LanguageId).ToList();
        var countOfFounded=await _dbContext.Languages.Where(x => languageIds.Contains(x.Id)).CountAsync();
        return countOfFounded == dtos.Count;
    }
    public async Task<bool> CheckIfLanguageIdExists(IList<TranslationUpdateInternshipDto> dtos, CancellationToken arg2)
    {
        var languageIds = dtos.Select(x => x.LanguageId).ToList();
        var countOfFounded = await _dbContext.Languages.Where(x => languageIds.Contains(x.Id)).CountAsync();
        return countOfFounded == dtos.Count;
    }
    public async Task<bool> CheckIfLocationIdExists(int[] arg1, CancellationToken arg2)
    {
        //should later be placed inside the getbyidquery of locations this is just temporary
        foreach (var item in arg1)
        {
            var result = await _dbContext.Locations.Where(x => x.Id == item).ToListAsync();
            if(result==null) return false;
        }
      
        return true;
    }

    public async Task<bool> CheckIfUnitIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _dbContext.Departments.FirstOrDefaultAsync(x => x.Id == arg1);
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
    public async Task<bool> CheckIfTranslationIdExists(List<TranslationUpdateInternshipDto> dto, CancellationToken arg2)
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
        var currentYear = DateTime.UtcNow.Year;
        //var differenceWithMinimalYear = currentYear - 2020;
        for (int i = 0; i <= 20; i++)
        {
            var yearRange = $"{currentYear - i}-{currentYear - i +1}";
            if (yearRange == arg) return true;
        }

        return false;
    }
}
