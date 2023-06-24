namespace CoinMarketCapApi;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class ExchangeSharedStartup
{
    public static class ExchangesSharedStartup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            var isTest = configuration.GetValue<bool>("IsTest");
        }


        public static void ConfigCoinMarketCap(IConfiguration configuration, bool isTest)
        {
            var coinMarketCap = configuration.GetSection("cionarketCapApi");
        }
    }
}