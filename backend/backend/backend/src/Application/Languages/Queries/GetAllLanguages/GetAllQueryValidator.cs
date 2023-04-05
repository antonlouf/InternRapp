using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace backend.Application.Languages.Queries.GetAllLanguages;
public class GetAllQueryValidator:AbstractValidator<GetAllQuery>    
{
    public GetAllQueryValidator()
    {
        this.CascadeMode = CascadeMode.Stop;
        RuleFor(x => x.Dto).Cascade(CascadeMode.Stop).NotNull().NotEmpty();
        RuleFor(x => x.Dto.PageSize).NotNull().NotEmpty();
        RuleFor(x => x.Dto.PageIndex).NotNull().NotEmpty();
        
    }
}
