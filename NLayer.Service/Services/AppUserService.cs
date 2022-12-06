using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class AppUserService : BaseService<AppUser, AppUserDto>
    {
        public AppUserService(IGenericRepository<AppUser> genericRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(genericRepository, unitOfWork, mapper)
        {
        }
    }
}
