using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string _managerEmails;

    public List<InternShip> InternShips { get; set; }

    public List<string> ManagerEmails
    {
        get { return _managerEmails.Split(',').ToList(); }
        set { _managerEmails = string.Join(',',value); }
    }
}
