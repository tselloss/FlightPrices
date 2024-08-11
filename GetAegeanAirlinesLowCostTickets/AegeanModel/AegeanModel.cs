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
            public object Difference { get; set; }  // Assuming this could be null or another data type
        }

        public class Results
        {
            public List<FlightMonth> Outbound { get; set; }
            public List<FlightMonth> Inbound { get; set; }
            public string CurrencySymbol { get; set; }
        }

        public class LowFareCalendarResponse
        {
            public string AirportFrom { get; set; }
            public string AirportFromSelect { get; set; }
            public string AirportTo { get; set; }
            public string AirportToSelect { get; set; }
            public string TravelType { get; set; }
            public object MonthFrom { get; set; }
            public object MonthTo { get; set; }
            public object SelectedDepartureDate { get; set; }
            public object SelectedReturnDate { get; set; }
            public bool ShowInfo { get; set; }
            public Results Results { get; set; }
            public Dictionary<string, decimal> OutboundPrices { get; set; }
            public Dictionary<string, decimal> InboundPrices { get; set; }
            public object Dep { get; set; }
            public object Arr { get; set; }
            public object Month { get; set; }
            public object Type { get; set; }
        }
    }
}
