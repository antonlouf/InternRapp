using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Languages.Commands.DeleteLanguage;
public class DeleteLanguageCommand:IRequest
{
    // make command immutable 
  
    public int Id { get; set; }
}
public class DeleteLanguageCommandHandler : AsyncRequestHandler<DeleteLanguageCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public DeleteLanguageCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override async Task Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
    {
        //single or default
        var entityTobeDeleted = await _dbContext.Languages.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
        _dbContext.Languages.Remove(entityTobeDeleted);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
