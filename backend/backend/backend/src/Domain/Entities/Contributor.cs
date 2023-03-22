using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Enums;

namespace backend.Domain.Entities;
public class Contributor
{
    public int Id { get; set; }
    public ApplicationUser AppUser { get; set; }
    public int AppUserId { get; set; }
    public Department Department { get; set; }
    public int DepartmentId { get; set; }
    public ContributorKind TypeOfContributor { get; set; }
}
