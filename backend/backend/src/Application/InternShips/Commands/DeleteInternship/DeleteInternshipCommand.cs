using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Commands.DeleteInternship;
public class DeleteInternshipCommand:IRequest
{
    public int Id { get; set; }
}
public class DeleteInternshipCommandHandler : AsyncRequestHandler<DeleteInternshipCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public DeleteInternshipCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected async override Task Handle(DeleteInternshipCommand request, CancellationToken cancellationToken)
    {
        var entityTobeDeleted = await _dbContext.InternShips.FindAsync(request.Id);
        _dbContext.InternShips.Remove(entityTobeDeleted);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
