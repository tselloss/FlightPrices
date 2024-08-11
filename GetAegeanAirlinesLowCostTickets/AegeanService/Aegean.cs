using GetAegeanAirlinesLowCostTickets.Extensions;
using GetAegeanAirlinesLowCostTickets.Interface;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace GetAegeanAirlinesLowCostTickets.Service
{
    public class Aegean : IAegean
    {        
        async Task<LowFareCalendarResponse> IAegean.GetSingleFlightInfo()
        {
            var aegeanHttpClient = await DefineHttpClient.GetHttpClient();
            var url = StringConcatenation.GetUrl(CitiesEnum.ATH.ToString(), CitiesEnum.HAM.ToString());
            HttpResponseMessage httpResponseMessage = await aegeanHttpClient.GetAsync(url);
            httpResponseMessage.EnsureSuccessStatusCode();

            var responseBody = await Deserializer.DeserializationAsync(httpResponseMessage);
            var jsonData = JsonConvert.DeserializeObject<LowFareCalendarResponse>(responseBody);

            return jsonData;
        }        
    }
}
