using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class ProductFeaturesController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductFeatureService _service;

        public ProductFeaturesController(IMapper mapper, IProductFeatureService service)
        {

            _mapper = mapper;
            _service = service;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            IQueryable<ProductFeature> productFeatures = _service.GetAllNonDeletedAsync();
            List<ProductFeatureDto> productFeaturesDtos = _mapper.Map<List<ProductFeatureDto>>(productFeatures.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductFeatureDto>>.Success(200, productFeaturesDtos));
        }

        [ServiceFilter(typeof(NotFoundFilter<ProductFeature>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {


            ProductFeature productFeature = await _service.GetByIdAsync(id);
            ProductFeatureDto productFeatureDto = _mapper.Map<ProductFeatureDto>(productFeature);
            return CreateActionResult(CustomResponseDto<ProductFeatureDto>.Success(200, productFeatureDto));
        }
    }
}
