using backend.Application.Common.Interfaces;
using backend.Application.Common.ValidationFunctions;
using backend.Application.Units.Queries.GetUnitById;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Commands.CreateInternShip;
public class CreateInterShipCommandValidator : AbstractValidator<CreateInternShipCommand>
{
    private readonly IMediator _mediator;
    private readonly IApplicationDbContext _dbContext;
    public CreateInterShipCommandValidator(IMediator mediator, IApplicationDbContext dbContext)
    {
        _mediator = mediator;
        _dbContext = dbContext;
        RuleFor(x => x.Dto).NotEmpty().NotNull();
        RuleFor(x => x.Dto.SchoolYear).NotNull().NotEmpty().Must(IsValidSchoolYear);
        RuleFor(x => x.Dto.UnitId).NotNull().NotEmpty().MustAsync(CheckIfUnitIdExists);
        RuleFor(x => x.Dto.MaxCountOfStudents).NotNull().NotEmpty().Must(x => x > 0);
        RuleFor(x => x.Dto.LocatieId).GreaterThan(0).NotEmpty().NotNull().MustAsync(CheckIfLocationIdExists);
        RuleFor(x => x.Dto.TrainingType).NotEmpty().NotNull();
        RuleFor(x => x.Dto.Versions).NotEmpty().NotNull().Must(IsVersionValid).MustAsync(CheckIfLanguageIdExists);
    }

    private bool IsVersionValid(IList<LanguageSpecificInternShipDto> arg)
    {
        foreach (var version in arg)
        {
            if (!version.NeededKnowledge.IsStringWithoutSpecialChars()) return false;
            if (version.NeededKnowledge == null || version.NeededKnowledge == "") return false;

            if (!version.TitleContent.IsStringWithoutSpecialChars()) return false;
            if (version.TitleContent == null || version.TitleContent == "") return false;

            if (!version.Comment.IsStringWithoutSpecialChars()) return false;
            if (version.Comment == null || version.Comment == "") return false;

            if (!version.Content.IsStringWithoutSpecialChars()) return false;
            if (version.Content == null || version.Content == "") return false;

            if (!version.Description.IsStringWithoutSpecialChars()) return false;
            if (version.Description == null || version.Description == "") return false;

            if (!version.Location.IsStringWithoutSpecialChars()) return false;
            if (version.Location == null || version.Location == "") return false;

            if (!version.KnowledgeToDevelop.IsStringWithoutSpecialChars()) return false;
            if (version.KnowledgeToDevelop == null || version.KnowledgeToDevelop == "") return false;





        }
        return true;
    }

    private async Task<bool> CheckIfLanguageIdExists(IList<LanguageSpecificInternShipDto> dtos, CancellationToken arg2)
    {
        for (int i = 0; i < dtos.Count; i++)
        {
            var result = await _dbContext.Languages.Where(x => x.Id == dtos[i].LanguageId).ToListAsync();
            if (result == null) return false;
        }
        return true;

    }


  
    private async Task<bool> CheckIfLocationIdExists(int arg1, CancellationToken arg2)
    {
        //should later be placed inside the getbyidquery of locations this is just temporary
        var result = await _dbContext.Locations.Where(x => x.Id == arg1).ToListAsync();
        return result != null;
    }

    private async Task<bool> CheckIfUnitIdExists(int arg1, CancellationToken arg2)
    {
        var result = await _mediator.Send(new GetByIdQuery() { Id = arg1 });
        return result != null;
    }

    private bool IsValidSchoolYear(string arg)
    {
        var currentYear = DateTime.Now.Year;
        var differenceWithMinimalYear = currentYear - 2020;
        for (int i = 0; i < differenceWithMinimalYear - 1; i++)
        {
            var yearRange = $"2000-{2020 + i + 1}";
            if (yearRange == arg) return true;
        }

        return false;
    }
}
