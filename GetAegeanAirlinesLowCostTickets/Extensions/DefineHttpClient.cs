using System.Net.Http.Headers;

namespace GetAegeanAirlinesLowCostTickets.Extensions
{
    internal class DefineHttpClient
    {
        internal async static Task<HttpClient> GetHttpClient()
        {
            var client = new HttpClient();  
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:128.0) Gecko/20100101 Firefox/128.0");
            client.DefaultRequestHeaders.Accept.TryParseAdd("*/*");
            client.DefaultRequestHeaders.AcceptLanguage.TryParseAdd("en-US,en;q=0.5");
            client.DefaultRequestHeaders.AcceptEncoding.TryParseAdd("gzip, deflate, br, zstd");
            client.DefaultRequestHeaders.Connection.TryParseAdd("keep-alive");

            return client;
        }
    }
}
