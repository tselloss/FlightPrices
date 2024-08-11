using System.IO.Compression;

namespace GetAegeanAirlinesLowCostTickets.Extensions
{
    internal class Deserializer
    {
        public static async Task<string> DeserializationAsync(HttpResponseMessage httpResponseMessage)
        {
            string responseBody;
            if (httpResponseMessage.Content.Headers.ContentEncoding.Contains("gzip"))
            {
                using (var responseStream = await httpResponseMessage.Content.ReadAsStreamAsync())
                using (var decompressedStream = new GZipStream(responseStream, CompressionMode.Decompress))
                using (var reader = new StreamReader(decompressedStream))
                {
                    responseBody = await reader.ReadToEndAsync();
                }
            }
            else
            {
                responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
            }

            return responseBody;
        }
    }
}
