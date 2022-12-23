using NLayer.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class LanguageDto : IBaseDto
    {
        public int ID { get; set; }
        public DataStatus Status { get; set; }
        public string LanguageName { get; set; }
        public int Level { get; set; }
    }
}
