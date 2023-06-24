namespace CoinMarketCapApi.Authentication;

public static class GeneralOptions
{
    public static string ApiKey { get; private set; }
    
    public static void Init(string apiKey)
    {
        ApiKey = apiKey;
    }
}

