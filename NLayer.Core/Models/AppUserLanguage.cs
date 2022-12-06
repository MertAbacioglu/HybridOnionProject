using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class AppUserLanguage :BaseEntity
    {
        public int LanguageID { get; set; }
        public int AppUserID { get; set; }
        public string GivenBy { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual Language Language { get; set; }
    }
}