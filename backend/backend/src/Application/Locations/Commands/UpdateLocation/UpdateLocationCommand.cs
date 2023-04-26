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
    public int Id { get; set; }
    public string City { get; set; }
    public string Streetname { get; set; }
    public int Housenumber { get; set; }
    public string Zipcode { get; set; }
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
        var location = await _dbContext.Locations.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
        location.City = request.City;
        location.StreetName = request.Streetname;
        location.HouseNumber = request.Housenumber;
        location.ZipCode = request.Zipcode;

        _dbContext.Locations.Update(location);

        await _dbContext.SaveChangesAsync(cancellationToken);
    }

}

