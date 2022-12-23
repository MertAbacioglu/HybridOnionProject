using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Core.Wrappers;
using NLayer.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class AppUsersLanguagesService : BaseService<AppUserLanguage, AppUserLanguageDto>, IAppUserLanguagesService
    {
        public AppUsersLanguagesService(IGenericRepository<AppUserLanguage> genericRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(genericRepository, unitOfWork, mapper)
        {
        }

        /// <summary>
        /// Gener
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Response<AppUserLanguageDto>> FindAsync(int languageId, int userId, bool tracking)
        {
            AppUserLanguageDto dto = _mapper.Map<AppUserLanguageDto>(await _genericRepository.FindAsync(tracking, languageId, userId));
            return  Response<AppUserLanguageDto>.Success(StatusCodes.Status200OK, dto);
        }
    }
}
