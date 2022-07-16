using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Web.Services
{
    public class AppUserApiService : BaseApiService
    {
        public AppUserApiService(HttpClient httpClient) : base(httpClient)
        {
        }
        public async Task<AppUser> GetByIdAsync(int id)
        {

            CustomResponseDto<AppUser> response = await _httpClient.GetFromJsonAsync<CustomResponseDto<AppUser>>($"appusers/{id}");
            return response.Data;
        }
        public async Task<AppUserDto> CheckAppUser(AppUserDto appUserDto)
        {

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("appusers", appUserDto);

            if (!response.IsSuccessStatusCode) return null;

            CustomResponseDto<AppUserDto> responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<AppUserDto>>();

            return responseBody.Data;
        }
    }
}
