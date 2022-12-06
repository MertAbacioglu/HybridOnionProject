using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class AppUserLanguageRepository : GenericRepository<AppUserLanguage>
    {
        public AppUserLanguageRepository(AppDbContext context) : base(context)
        {
        }
    }
}
