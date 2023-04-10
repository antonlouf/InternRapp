using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class InternShipContentTranslation
{
    //Not sure if DDD is in scope but atleast make this domain abit smarter.
    //Make it immutable
    //Dont reference by type if the class doesnt 'own' the other one (use id for EF core config)
    //Check our commands and forsee a Update method instead of setting the properties
    //Forsee a static Create method
    public int Id { get; set; }
    public string TitleContent { get; set; }
    public string Description { get; set; }
    public string KnowledgeToDevelop { get; set; }
    public string NeededKnowledge { get; set; }
    public string Location { get; set; }
    public string Comment { get; set; }
    public string Content { get; set; }
    public InternShip InternShip { get; set; }
    public int InternShipId { get; set; }
    public Language Language { get; set; }
    public int LanguageId { get; set; }
}
