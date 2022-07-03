using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public abstract class BaseApiService
    {
        protected HttpClient _httpClient;

        public BaseApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

    }
}
