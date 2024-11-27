using System.Text.Json.Serialization;

namespace GetAegeanAirlinesLowCostTickets.AegeanModel
{
    public class AegeanModel
    {
        public class FlightMonth
        {
            public string Display { get; set; }
            public string DisplayShort { get; set; }
            public string Value { get; set; }
            public decimal Price { get; set; }
            public object Difference { get; set; } 
        }

        public class Results
        {
            public List<FlightMonth> Outbound { get; set; }
            public List<FlightMonth> Inbound { get; set; }
            public string CurrencySymbol { get; set; }
        }

        public class LowFareCalendarResponse
        {
            [JsonIgnore]
            public string AirportFrom { get; set; }
            public string AirportFromSelect { get; set; }
            [JsonIgnore]
            public string AirportTo { get; set; }
            public string AirportToSelect { get; set; }
            [JsonIgnore]
            public string TravelType { get; set; }
            [JsonIgnore]
            public object MonthFrom { get; set; }
            [JsonIgnore]
            public object MonthTo { get; set; }
            [JsonIgnore]
            public object SelectedDepartureDate { get; set; }
            [JsonIgnore]
            public object SelectedReturnDate { get; set; }
            [JsonIgnore]
            public bool ShowInfo { get; set; }
            [JsonIgnore]
            public Results Results { get; set; }
            public Dictionary<string, decimal> OutboundPrices { get; set; }
            public Dictionary<string, decimal> InboundPrices { get; set; }
            [JsonIgnore]
            public object Dep { get; set; }
            [JsonIgnore]
            public object Arr { get; set; }
            [JsonIgnore]
            public object Month { get; set; }
            [JsonIgnore]
            public object Type { get; set; }
        }

       
        public class Destination
        {
            public string Provider { get; set; }
            public string WeatherPointId { get; set; }
            public string Value { get; set; }
            public string Label { get; set; }
            public string CityLabel { get; set; }
            public string Airline { get; set; }
            public double? Lat { get; set; } 
            public double? Lon { get; set; }
            public bool? Direct { get; set; }
            public string Operators { get; set; }
            public string Country { get; set; }
            public bool? Sdf { get; set; }
            public string Bcid { get; set; }
            public string DestinationName { get; set; }
            public double? MinOWPrice { get; set; }
            public string OwCurrency { get; set; }
            public double? MinRTPrice { get; set; }
            public string RtCurrency { get; set; }
            public bool? IsNew { get; set; }
            public string NewTag { get; set; }
            public string Region { get; set; }
        }

        public class AirportsResponse
        {
            [JsonPropertyName("airports")]
            public List<Destination> Airports { get; set; }
        }
    }
}
