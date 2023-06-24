using System.Net.Mime;
using CoinMarketCapApi.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CoinMarketCapApi;


     public static class SharedStartup
    {
        private const string CorsPolicy = "CorsPolicy";

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, string appName)
        {
            GeneralOptions.Init(configuration["ApiKey"]);

            services.AddControllers()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        var result = new BadRequestObjectResult(context.ModelState);

                        result.ContentTypes.Add(MediaTypeNames.Application.Json);
                        result.ContentTypes.Add(MediaTypeNames.Application.Xml);

                        return result;
                    };
                });






            var settings = configuration.GetSection("AppSettings");
            var settingServiceCacheValidityInSeconds =
                settings.GetValue<double>("SettingServiceCacheValidityInSeconds");



            services.AddCors(o => o.AddPolicy(CorsPolicy, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
        }
}