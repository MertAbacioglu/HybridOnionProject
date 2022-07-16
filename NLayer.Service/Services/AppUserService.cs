using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class AppUserService : Service<AppUser>, IApuserService
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly IMapper _mapper;

        public AppUserService(IGenericRepository<AppUser> repository, IUnitOfWork unitOfWork, IAppUserRepository appUserRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _appUserRepository = appUserRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<AppUserDto>> CheckAppUser(AppUser appUser)
        {
            AppUser checkedAppUser = await _appUserRepository.CheckAppUser(appUser);
            AppUserDto appUserDto =_mapper.Map<AppUserDto>(checkedAppUser);
            return CustomResponseDto<AppUserDto>.Success(200, appUserDto);

        }
    }
}
