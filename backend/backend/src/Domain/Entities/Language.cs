using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class Language
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public IList<InternShipContentTranslation> InternshipTranslations{ get; set; }
    public IList<PrefaceTranslation> PrefaceTranslations { get; set; }

    //public string CreatorEmail { get; set; }

}
