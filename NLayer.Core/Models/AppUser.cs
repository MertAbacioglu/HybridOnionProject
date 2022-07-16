using NLayer.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class AppUser:BaseEntity
    {
        public AppUser()
        {
            Role = AppUserRole.Member;
            ActivationCode = Guid.NewGuid();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public AppUserRole Role { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }

        //Relational Properties
        public AppUserProfile AppUserProfile { get; set; }

    }
}
