using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit= backend.Domain.Entities.Department;
using MediatR;
using backend.Application.Common.Interfaces;
using backend.Application.Units.Queries.GetUnitById;
using Microsoft.EntityFrameworkCore;
using backend.Application.Units.Queries.GetAllUnits;
using backend.Domain.Entities;

namespace backend.Application.Units.Commands.UpdateUnit;
public class UpdateUnitCommand:IRequest
{
    public UnitListUpdateDto Unit { get; set; }
}
public class UpdateUnitCommandHandler : AsyncRequestHandler<UpdateUnitCommand>
{

    private readonly IApplicationDbContext _dbContext;
    public UpdateUnitCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected async override Task Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
    {
        //add control to the validator to check there is an existing item with this id!!
        var unit = await _dbContext.Departments.FirstOrDefaultAsync(x=>x.Id==request.Unit.Id);
        unit.Name= request.Unit.Name; 
        unit.ManagerEmails=request.Unit.ManagerEmails;
        unit.PrefaceTranslations = new List<PrefaceTranslation>();
        foreach (var prefaceTranslation in request.Unit.PrefaceTranslations)
        {
            if (prefaceTranslation.TranslationId != null)
            {
                unit.PrefaceTranslations.Add(new()
                {
                    Content = prefaceTranslation.Content,
                    Id=prefaceTranslation.TranslationId??0,
                    LanguageId=prefaceTranslation.LanguageId
                });
            }
            else
            {
                unit.PrefaceTranslations.Add(new()
                {
                    Content = prefaceTranslation.Content,
                    LanguageId = prefaceTranslation.LanguageId
                });
            }
        }
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
