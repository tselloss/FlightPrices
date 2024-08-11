using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace GetAegeanAirlinesLowCostTickets.Interface
{
    public interface IAegean
    {
        Task<LowFareCalendarResponse> GetSingleFlightInfo();
    }
}
