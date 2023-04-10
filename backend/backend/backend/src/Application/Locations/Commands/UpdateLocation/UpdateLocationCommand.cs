using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Application.InternShips.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Locations.Commands.UpdateLocation;
public class UpdateLocationCommand : IRequest
{
    // make command immutable 
    // Dont wrap the properties in a DTO
    public LocationDto Dto { get; set; }
}

public class UpdateLocationCommandHandler : AsyncRequestHandler<UpdateLocationCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateLocationCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        var location = await _dbContext.Locations.Where(x => x.Id == request.Dto.id).FirstOrDefaultAsync();
        location.City = request.Dto.city;
        location.StreetName = request.Dto.streetname;
        location.HouseNumber = request.Dto.housenumber;
        location.ZipCode = request.Dto.zipcode;
        //Update not needed -> ef core changeTracker?
        _dbContext.Locations.Update(location);

        await _dbContext.SaveChangesAsync(cancellationToken);
    }

}

