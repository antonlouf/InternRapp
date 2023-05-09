using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Enums;

namespace backend.Domain.Entities;
public class InternShip
{
    public int Id { get;  set; }
    public Department Unit { get; set; }
    public int UnitId { get; set; }
    public string SchoolYear { get; set; }
    public int MaxStudents  { get; set; }
    public IList<Location> Locations { get; set; }
    public IList<InternShipLocation> InternShipLocations { get; set; }

    //public IList<int> LocationIds { get; set; } //done? 

    public int CurrentCountOfStudents { get; set; }
    public TrainingType RequiredTrainingType { get; set; }
    public IList<InternShipContentTranslation> Translations { get; set; }
    //public List<int> TranslationIds { get; set; } //done?

    //public string CreatorEmail { get; set; }

}
