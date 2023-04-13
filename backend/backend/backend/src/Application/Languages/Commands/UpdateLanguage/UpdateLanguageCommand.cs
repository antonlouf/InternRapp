using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Languages.Commands.UpdateLanguage;
public class UpdateLanguageCommand:IRequest
{
    public LanguageListDto Dto { get; set; }
}
public class UpdateLanguageCommandHandler : AsyncRequestHandler<UpdateLanguageCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateLanguageCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override async Task Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
    {
        //Single or default / check on null (will crash if language is not found)
        //Do we even need to change the name of a language? 
        var language = await _dbContext.Languages.Where(x => x.Id == request.Dto.Id).FirstOrDefaultAsync();

        if (language == null) {
            return;
        }

        language.Name = request.Dto.Name;
        //Update not needed -> ef core changeTracker?
        _dbContext.Languages.Update(language);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

}
