using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class InternShipLocation
{
    public InternShip InternShip { get; set; }
    public int InternShipId { get; set; }
    public Location Location { get; set; }
    public int LocationsId { get; set; } //locations?
}
