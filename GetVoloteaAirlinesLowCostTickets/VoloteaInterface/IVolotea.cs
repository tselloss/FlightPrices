using static GetVoloteaAirlinesLowCostTickets.VoloteaModel.VoloteaModel;

namespace GetVoloteaAirlinesLowCostTickets.VoloteaInterface
{
    public interface IVolotea
    {
        Task<FlightFare> GetSingleFlightInfo();
    }
}
