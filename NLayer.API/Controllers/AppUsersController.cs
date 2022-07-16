using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class AppUsersController : CustomBaseController
    {
        private readonly IApuserService _appUserService;
        private readonly IMapper _mapper;

        public AppUsersController(IApuserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            AppUser appUser = await _appUserService.GetByIdAsync(id);
            AppUserDto appUserDto = _mapper.Map<AppUserDto>(appUser);
            return CreateActionResult(CustomResponseDto<AppUserDto>.Success(200, appUserDto));
        }

        [HttpPost]
        public async Task<IActionResult> CheckAppUser(AppUserDto appUserDto)
        {
            return CreateActionResult(await _appUserService.CheckAppUser(_mapper.Map<AppUser>(appUserDto)));
        }
    }
}
