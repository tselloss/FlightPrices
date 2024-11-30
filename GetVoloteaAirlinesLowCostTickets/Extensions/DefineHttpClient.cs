using System.Net.Http.Headers;

namespace GetVoloteaAirlinesLowCostTickets.Extensions
{
    internal class DefineHttpClient
    {
        internal async static Task<HttpClient> GetHttpClient()
        {
            var client = new HttpClient();

            // Clear any existing headers
            client.DefaultRequestHeaders.Clear();

            // Set headers
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.TryParseAdd("text/plain");
            client.DefaultRequestHeaders.Accept.TryParseAdd("*/*");
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:133.0) Gecko/20100101 Firefox/133.0");
            client.DefaultRequestHeaders.AcceptLanguage.TryParseAdd("en-US,en;q=0.5");
            client.DefaultRequestHeaders.AcceptEncoding.TryParseAdd("gzip, deflate, br, zstd");
            client.DefaultRequestHeaders.Connection.TryParseAdd("keep-alive");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Origin", "https://www.volotea.com");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Referer", "https://www.volotea.com/");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Dest", "empty");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Mode", "cors");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Sec-Fetch-Site", "same-site");

            return client;
        }
    }
}
