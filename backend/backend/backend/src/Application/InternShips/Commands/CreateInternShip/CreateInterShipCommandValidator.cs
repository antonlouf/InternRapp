using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Commands.UpdateInternShip;
using backend.Application.InternShips.Common;
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
        var validator = new ValidationFunctions(_dbContext);
        RuleFor(x => x.Dto).NotEmpty().NotNull();
        RuleFor(x => x.Dto.SchoolYear).NotNull().NotEmpty().Must(validator.IsValidSchoolYear);
        RuleFor(x => x.Dto.UnitId).NotNull().NotEmpty().MustAsync(validator.CheckIfUnitIdExists);
        RuleFor(x => x.Dto.MaxCountOfStudents).NotNull().NotEmpty().Must(x => x > 0);
        RuleFor(x => x.Dto.LocationId).GreaterThan(0).NotEmpty().NotNull().MustAsync(validator.CheckIfLocationIdExists);
        RuleFor(x => x.Dto.TrainingType).NotEmpty().NotNull();
        RuleFor(x => x.Dto.Versions).NotEmpty().NotNull().Must(ValidationFunctions.IsVersionValid).MustAsync(validator.CheckIfLanguageIdExists);
    }
    
}
