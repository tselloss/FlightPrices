namespace GetVoloteaAirlinesLowCostTickets.VoloteaModel
{
    public class VoloteaModel
    {
        public class FlightFare
        {
            public string Market { get; set; }
            public decimal PriceWithoutFee { get; set; }
            public decimal Price { get; set; }
            public decimal PriceWithFee { get; set; }
            public decimal PriceWithCorporateMasterCardFee { get; set; }
            public DateTime DepartureFlightDate { get; set; }
            public DateTime? ReturnFlightDate { get; set; }
            public string ClassOfService { get; set; }
            public string GroupBy { get; set; }
            public int Availability { get; set; }
            public string FareType { get; set; }
            public decimal PriceWithoutFeePerPassenger { get; set; }
            public decimal PricePerPassenger { get; set; }
            public decimal PriceWithFeePerPassenger { get; set; }
            public decimal PriceWithCorporateMasterCardFeePerPassenger { get; set; }
            public string FareSequence { get; set; }
            public string RuleTariff { get; set; }
            public string ClassType { get; set; }
            public int Status { get; set; }
            public string OperatingOpSuffix { get; set; }
            public string CarrierCode { get; set; }
            public string FlightNumber { get; set; }
            public DateTime DepartureTime { get; set; }
            public DateTime ArrivalTime { get; set; }
            public decimal? AdultFare { get; set; }
            public decimal? ChildFare { get; set; }
            public decimal Taxes { get; set; }
            public string OperatingCarrier { get; set; }
            public string OperatingFlightNumber { get; set; }
            public string CodeShareIndicator { get; set; }
            public string RuleNumber { get; set; }
            public string FareBasisCode { get; set; }
        }

        public class FareSearchResponse
        {
            public string MarketType { get; set; }
            public string MarketValue { get; set; }
            public bool AnyPeriod { get; set; }
            public string FareType { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int MaxResults { get; set; }
            public string GroupBy { get; set; }
            public object Passengers { get; set; } // Adjust type if passenger info is provided
            public bool RepeatMarkets { get; set; }
            public DateTime? ReturnFlightDate { get; set; }
            public bool PriceWithFee { get; set; }
            public List<FlightFare> Value { get; set; }
        }

    }
}
