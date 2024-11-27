using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace GetAegeanAirlinesLowCostTickets.Interface
{
    public interface IAegean
    {
        Task<LowFareCalendarResponse> GetSingleFlightInfo();
        Task<List<Destination>> GetAllTheAirports();
        Task<LowFareCalendarResponse> GetCheapestInboundMonth(string inboundCity, string outboundCity);
        Task<List<LowFareCalendarResponse>> GetAllFlightsFromAthens();
    }
}
