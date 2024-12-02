using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace AegeanUnitTests.Mock
{
    public static class AegeanMocks
    {
        public static LowFareCalendarResponse SingleFlight()
        {
            return new LowFareCalendarResponse
            {
                AirportFromSelect = "ATH",
                AirportToSelect = "BCN",
                OutboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-01", 199.99M },
                { "2024-12-02", 189.99M },
                { "2024-12-03", 179.99M }
            },
                InboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-10", 249.99M },
                { "2024-12-11", 239.99M },
                { "2024-12-12", 229.99M }
            }
            };
        }

        public static LowFareCalendarResponse SelectDestinations(this LowFareCalendarResponse response, string departure, string arrival)
        {
            response.AirportFromSelect = departure;
            response.AirportToSelect = arrival;

            return response;
        }

        public static List<LowFareCalendarResponse> MultipleFlightList()
        {
            return new List<LowFareCalendarResponse>
    {
        new LowFareCalendarResponse
        {
            AirportFromSelect = "ATH",
            AirportToSelect = "BCN",
            OutboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-01", 199.99M },
                { "2024-12-02", 189.99M },
                { "2024-12-03", 179.99M }
            },
            InboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-10", 249.99M },
                { "2024-12-11", 239.99M },
                { "2024-12-12", 229.99M }
            }
        },
        new LowFareCalendarResponse
        {
            AirportFromSelect = "ATH",
            AirportToSelect = "LHR",
            OutboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-05", 399.99M },
                { "2024-12-06", 379.99M },
                { "2024-12-07", 359.99M }
            },
            InboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-15", 449.99M },
                { "2024-12-16", 429.99M },
                { "2024-12-17", 419.99M }
            }
        },
        new LowFareCalendarResponse
        {
            AirportFromSelect = "ATH",
            AirportToSelect = "NRT",
            OutboundPrices = new Dictionary<string, decimal>
            {
                { "2024-12-20", 699.99M },
                { "2024-12-21", 679.99M },
                { "2024-12-22", 659.99M }
            },
            InboundPrices = new Dictionary<string, decimal>
            {
                { "2025-01-05", 749.99M },
                { "2025-01-06", 729.99M },
                { "2025-01-07", 719.99M }
            }
        }
    };
        }

    }
}
