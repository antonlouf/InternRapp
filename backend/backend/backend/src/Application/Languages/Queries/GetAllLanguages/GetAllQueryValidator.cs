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
        RuleFor(x => x.Dto).Cascade(CascadeMode.Stop).NotNull().NotEmpty();
        
    }
}
