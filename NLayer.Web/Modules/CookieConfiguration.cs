using Microsoft.AspNetCore.Authentication.Cookies;

namespace NLayer.Web.Modules
{
    public static class CookieConfiguration
    {
        public static WebApplicationBuilder UseCookieExtension(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
            //    x => x.LoginPath = "/Home/Login");

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Home/Login";
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(1);
                    options.SlidingExpiration = true;
                    options.Cookie.Name = "MyAppCookie";
                    options.AccessDeniedPath = "/Home/Login";
                });
            return builder;

        }
    }
}

