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
        var location = await _dbContext.Locations.Where(x => x.Id == request.Dto.Id).FirstOrDefaultAsync();
        location.City = request.Dto.City;
        location.StreetName = request.Dto.Streetname;
        location.HouseNumber = request.Dto.Housenumber;
        location.ZipCode = request.Dto.Zipcode;

        _dbContext.Locations.Update(location);

        await _dbContext.SaveChangesAsync(cancellationToken);
    }

}

