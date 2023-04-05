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
        var language = await _dbContext.Languages.Where(x => x.Id == request.Dto.Id).FirstOrDefaultAsync();
        language.Name = request.Dto.Name;
        _dbContext.Languages.Update(language);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

}
