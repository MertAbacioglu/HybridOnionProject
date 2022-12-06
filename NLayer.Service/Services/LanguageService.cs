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
    public class LanguageService : BaseService<Language, LanguageDto>, ILanguageServices
    {
        public LanguageService(IGenericRepository<Language> genericRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(genericRepository, unitOfWork, mapper)
        {
        }
    }
}