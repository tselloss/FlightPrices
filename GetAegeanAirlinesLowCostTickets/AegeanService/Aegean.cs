using GetAegeanAirlinesLowCostTickets.Extensions;
using GetAegeanAirlinesLowCostTickets.Interface;
using GetLowCostAirTickets.Common;
using Newtonsoft.Json;
using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace GetAegeanAirlinesLowCostTickets.Service
{
    public class Aegean : IAegean
    {
        public async Task<List<LowFareCalendarResponse>> GetAllFlightsFromAthens()
        {
            var getAllAirports = await GetAllTheAirports(); // Await the task

            var listOfPrices = new List<LowFareCalendarResponse>();

            // Use a Task.WhenAll for parallel processing
            var tasks = getAllAirports.Select(async airport =>
            {
                var getPrices = await GetCheapestInboundMonth("ATH", airport.Value);
                return getPrices;
            });

            var results = await Task.WhenAll(tasks);

            // Add all results to the list
            listOfPrices.AddRange(results);

            return listOfPrices;
        }

        public async Task<List<Destination>> GetAllTheAirports()
        {
            var aegeanHttpClient = await DefineHttpClient.GetHttpClient();
            var url = StringConcatenation.GetAirportsFromAthUrl();
            HttpResponseMessage httpResponseMessage = await aegeanHttpClient.GetAsync(url);
            httpResponseMessage.EnsureSuccessStatusCode();

            var responseBody = await JsonDeserializer.DeserializationAsync(httpResponseMessage);
            List<Destination> destinations = JsonConvert.DeserializeObject<List<Destination>>(responseBody);


            return destinations;
        }

        public async Task<LowFareCalendarResponse> GetCheapestInboundMonth(string inbound, string outbound)
        {
            var aegeanHttpClient = await DefineHttpClient.GetHttpClient();
            var url = StringConcatenation.GetRoundTripUrl(inbound, outbound);
            HttpResponseMessage httpResponseMessage = await aegeanHttpClient.GetAsync(url);
            httpResponseMessage.EnsureSuccessStatusCode();

            var responseBody = await JsonDeserializer.DeserializationAsync(httpResponseMessage);
            var jsonData = JsonConvert.DeserializeObject<LowFareCalendarResponse>(responseBody);

            return jsonData;
        }

        async Task<LowFareCalendarResponse> IAegean.GetSingleFlightInfo()
        {
            var aegeanHttpClient = await DefineHttpClient.GetHttpClient();
            var url = StringConcatenation.GetRoundTripUrl("ATH", "BCN");
            HttpResponseMessage httpResponseMessage = await aegeanHttpClient.GetAsync(url);
            httpResponseMessage.EnsureSuccessStatusCode();

            var responseBody = await JsonDeserializer.DeserializationAsync(httpResponseMessage);
            var jsonData = JsonConvert.DeserializeObject<LowFareCalendarResponse>(responseBody);

            return jsonData;
        }
    }
}
