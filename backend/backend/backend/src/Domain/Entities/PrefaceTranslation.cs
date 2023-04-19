﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities;
public class PrefaceTranslation
{
    public int Id { get; set; }
    public string Content { get; set; }
    public Language Language { get; set; }
    public int LanguageId { get; set; }
}
