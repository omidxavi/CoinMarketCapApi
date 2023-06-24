namespace CoinMarketCapApi;


    
    public static class CoinMarketCapApiConfigure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
        }
    }
    
