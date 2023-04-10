using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.Locations.Common;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Locations.Commands.UpdateLocation;
public class UpdateLocationCommandValidator:AbstractValidator<UpdateLocationCommand>  
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateLocationCommandValidator(IApplicationDbContext dbContext)
    {
        this.CascadeMode = CascadeMode.Stop;
        _dbContext = dbContext;
        var validator = new Validator(_dbContext);

        RuleFor(x => x).NotEmpty().NotNull(); //Nodig? -> should be checked in controller
        RuleFor(x => x.Dto.id).NotNull().NotEmpty().MustAsync(validator.DoesIdExists);
        RuleFor(x => x.Dto.city).NotNull().NotEmpty();
        RuleFor(x => x.Dto.housenumber).NotNull().NotEmpty();
        RuleFor(x => x.Dto.zipcode).NotNull().NotEmpty();
    }

    private async Task<bool> IsNameUnique(string arg1, CancellationToken arg2)
    {
        //naming of input - single or default 
        //part of DB key?
        // How are you comparing these strings? Lower vs upper etc...
        var result = await _dbContext.Locations.Where(x => x.City == arg1).FirstOrDefaultAsync();
        return result == null;
    }
}
