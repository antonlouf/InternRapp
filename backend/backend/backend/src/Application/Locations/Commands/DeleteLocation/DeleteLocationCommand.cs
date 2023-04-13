using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Locations.Commands.DeleteLocation;
public class DeleteLocationCommand:IRequest
{
    // make command immutable 
    // Dont wrap the properties in a DTO
    public int Id { get; init; }
}
    public class DeleteLocationCommandHandler : AsyncRequestHandler<DeleteLocationCommand>
    {
        private readonly IApplicationDbContext _dbContext;

        public DeleteLocationCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected override async Task Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
        //single or default (think EF even has a method for searching on primary key - find?)
        var entityTobeDeleted = await _dbContext.Locations.FindAsync(request.Id);

            _dbContext.Locations.Remove(entityTobeDeleted);

            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }

