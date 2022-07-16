using Microsoft.EntityFrameworkCore;
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
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<AppUser> CheckAppUser(AppUser appUser)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(x => x.UserName == appUser.UserName && x.Password == appUser.Password);

        }
    }
}
