﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Enums;

namespace backend.Domain.Entities;
public class ApplicationUser
{
    public int Id { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public Unit Unit { get; set; }
    public int? UnitId { get; set; }
}
