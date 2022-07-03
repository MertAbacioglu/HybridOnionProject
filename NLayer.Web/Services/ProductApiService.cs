using AutoMapper;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Web.ViewModels;

namespace NLayer.Web.Services
{
    public class ProductApiService : BaseApiService
    {
        CategoryApiService _categoryApiService;
        private readonly IMapper _mapper;

        public ProductApiService(HttpClient httpClient, CategoryApiService categoryApiService, IMapper mapper) : base(httpClient)
        {
            _categoryApiService = categoryApiService;
            _mapper = mapper;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategoryAsync2()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/GetProductsWithCategory");

            return response.Data;
        }
        public async Task<ProductListVM> GetProductsWithCategoryAsync()
        {
            CustomResponseDto<List<ProductWithCategoryDto>> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/GetProductsWithCategory");

            ProductListVM productListelemeVM = new ProductListVM();
            foreach (ProductWithCategoryDto item in response.Data)
            {
                productListelemeVM.productVMs.Add(new ProductVM
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Stock=item.Stock,
                    CategoryVM = new CategoryVM
                    {
                        Id = item.Category.Id,
                        Name = item.Category.Name
                    }

                });
            }
            return productListelemeVM;
        }
        public async Task<ProductAddVM> GetByIdAsync(int id)
        {

            CustomResponseDto<ProductDto> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<ProductDto>>($"products/{id}");
            return new ProductAddVM
            {
                Id = response.Data.Id,
                Price = response.Data.Price,
                Stock = response.Data.Stock,
                Name = response.Data.Name,
                CategoryVM = new CategoryVM
                {
                    Id = response.Data.CategoryId
                },
                CategorySelectList = _categoryApiService.GetAllAsync().Result.CategorySelectList
            };
            
        }



        public async Task<ProductVM> SaveAsync(ProductAddVM productAddVM)
        {
            ProductDto productDto = new ProductDto
            {
                CategoryId = productAddVM.CategoryId,
                Name = productAddVM.Name,
                Stock = productAddVM.Stock,
                Price = productAddVM.Price
            };
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("products", productDto);

            if (!response.IsSuccessStatusCode) return null;

            CustomResponseDto<ProductDto> responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
            return new ProductVM
            {
                Id= responseBody.Data.Id,
                Price= responseBody.Data.Price,
                Stock= responseBody.Data.Stock,
                Name= responseBody.Data.Name,
                CategoryVM=new CategoryVM
                {
                    Id=responseBody.Data.CategoryId,
                }
            };

        }
        public async Task<bool> UpdateAsync(ProductAddVM productAddVM)
        {
            ProductUpdateDto productUpdateDto = new ProductUpdateDto()
            {
                CategoryId = productAddVM.CategoryId,
                Id = productAddVM.Id,
                Name = productAddVM.Name,
                Price = productAddVM.Price,
                Stock = productAddVM.Stock,

            };
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync("products", productUpdateDto);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"products/{id}");

            return response.IsSuccessStatusCode;
        }
    }

}
