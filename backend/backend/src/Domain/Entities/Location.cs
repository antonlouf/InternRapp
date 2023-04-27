﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class Location
{
    public int Id { get; set; }
    public string City { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber { get; set; }
    public string ZipCode { get; set; }
    //public string CreatorEmail { get; set; }

}