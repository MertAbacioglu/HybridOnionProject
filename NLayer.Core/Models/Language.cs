﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Language : BaseEntity
    {
        public string LanguageName { get; set; }
        public int Level { get; set; }
    }
}
