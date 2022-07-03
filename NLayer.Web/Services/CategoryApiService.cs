using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core.DTOs;
using NLayer.Web.ViewModels;

namespace NLayer.Web.Services
{
    public class CategoryApiService : BaseApiService
    {
        public CategoryApiService(HttpClient httpClient) : base(httpClient)
        {
        }


        public async Task<CategoryVM> GetByIdAsync(int id)
        {

            CustomResponseDto<CategoryDto> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CategoryDto>>($"categories/{id}");
            return new CategoryVM
            {
               Id= response.Data.Id,
               Name= response.Data.Name
            };

        }
        public async Task<bool> UpdateAsync(CategoryVM categoryVM)
        {
            CategoryDto categoryDto = new CategoryDto
            {
                Name = categoryVM.Name,
                Id = categoryVM.Id
            };

            HttpResponseMessage response = await _httpClient.PutAsJsonAsync("categories", categoryDto);

            return response.IsSuccessStatusCode;
        }
        public async Task<CategoryVM> SaveAsync(CategoryVM categoryVM)
        {
            CategoryDto categoryDto = new CategoryDto
            {
                Name = categoryVM.Name
            };
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("categories", categoryDto);

            if (!response.IsSuccessStatusCode) return null;

            CustomResponseDto<CategoryDto> responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<CategoryDto>>();

            return new CategoryVM { Name= responseBody.Data.Name };
        }
        public async Task<bool> RemoveAsync(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"categories/{id}");

            return response.IsSuccessStatusCode;
        }


        public async Task<CategoryListVM> GetAllAsync()
        {
            CustomResponseDto<List<CategoryDto>> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("categories/GetAll");


            return new CategoryListVM
            {
                CategoryVMList = response.Data.Select(x => new CategoryVM
                {
                    Id=x.Id,
                    Name = x.Name,
                }).ToList(),
                CategorySelectList = new SelectList(response.Data, "Id", "Name")
            };

        }

    }
}