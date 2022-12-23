using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class AppUserLanguageRepository : GenericRepository<AppUserLanguage>,IAppUserLanguageRepository
    {
        public AppUserLanguageRepository(AppDbContext context) : base(context)
        {
        }

    }
}
