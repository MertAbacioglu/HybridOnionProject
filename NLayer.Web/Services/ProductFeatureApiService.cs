using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Web.Services
{
    public class ProductFeatureApiService : BaseApiService
    {
        private readonly IMapper _mapper;



        public ProductFeatureApiService(HttpClient httpClient, IMapper mapper) : base(httpClient)
        {
            _mapper=mapper;
        }

        public async Task<List<ProductFeatureDto>> GetAllAsync()
        {
            CustomResponseDto<List<ProductFeature>> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductFeature>>>("ProductFeatures/GetAll");
            return _mapper.Map<List<ProductFeatureDto>>(response.Data);

        }

        public async Task<ProductFeatureDto> GetByIdAsync(int id)
        {
            CustomResponseDto<ProductFeature> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ProductFeature>>($"ProductFeatures/{id}");
            return _mapper.Map<ProductFeatureDto>(response.Data);

        }
    }
}
