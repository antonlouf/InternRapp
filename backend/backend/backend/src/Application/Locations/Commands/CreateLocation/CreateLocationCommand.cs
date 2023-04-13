using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;

namespace backend.Application.Locations.Commands.CreateLocation;
       // make command immutable 
    // Dont wrap the properties in a DTO
public class CreateLocationCommand: IRequest
{
    public CreateLocationDto LocationDto { get; init; }
}

public class CreateLocationCommandHandler : AsyncRequestHandler<CreateLocationCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateLocationCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
    {
        var entityTobeAdded = new Location() { 
            City = request.LocationDto.city, 
            StreetName = request.LocationDto.streetname, 
            HouseNumber = request.LocationDto.housenumber, 
            ZipCode = request.LocationDto.zipcode
        };
        await _dbContext.Locations.AddAsync(entityTobeAdded); 
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
