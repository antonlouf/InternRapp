using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Enums;

namespace backend.Domain.Entities;
public class InternShip
{
    public int Id { get; set; }
    public Unit Unit { get; set; }
    public string SchoolYear { get; set; }
    public sbyte MaxStudents  { get; set; }
    public sbyte CurrentCountOfStudents { get; set; }
    public TrainingType RequiredTrainingType { get; set; }
}
