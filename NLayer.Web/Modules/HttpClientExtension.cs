using NLayer.Web.Services;

namespace NLayer.Web.Modules
{
    public static class HttpClientExtension
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddHttpClient<ProductApiService>(opt =>
            {

                opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);

            });
            builder.Services.AddHttpClient<CategoryApiService>(opt =>
            {

                opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);

            });
            builder.Services.AddHttpClient<ProductFeatureApiService>(opt =>
            {

                opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);

            });
            builder.Services.AddHttpClient<AppUserApiService>(opt =>
            {

                opt.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);

            });
            return builder;

        }
    }
}
