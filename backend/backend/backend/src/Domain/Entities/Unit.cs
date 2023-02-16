using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class Unit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public int ApplicationUserId { get; set; }

}
