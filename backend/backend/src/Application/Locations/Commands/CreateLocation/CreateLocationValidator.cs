using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace backend.Application.Locations.Commands.CreateLocation;
public class CreateLocationValidator:AbstractValidator<CreateLocationCommand>
{
    public CreateLocationValidator()
    {
        this.CascadeMode = CascadeMode.Stop;
        RuleFor(x => x.LocationDto.city).NotNull().NotEmpty();
        RuleFor(x => x.LocationDto.streetname).NotNull().NotEmpty();
        RuleFor(x => x.LocationDto.housenumber).NotNull().NotEmpty();
        //.Must(x => x.GetType() == typeof(int)); 
        RuleFor(x => x.LocationDto.zipcode).NotNull().NotEmpty();
    }
}
