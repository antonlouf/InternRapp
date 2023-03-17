using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace backend.Application.Units.Queries.GetAllUnits;
public class GetAllQueryValidator:AbstractValidator<GetAllQuery>    
{
    public GetAllQueryValidator()
    {
        RuleFor(x => x.Dto).Cascade(CascadeMode.Stop).NotNull().NotEmpty();
        RuleFor(x => x.Dto.PageSize).NotNull().NotEmpty();
        RuleFor(x => x.Dto.PageIndex).NotNull().NotEmpty();
    }
}
