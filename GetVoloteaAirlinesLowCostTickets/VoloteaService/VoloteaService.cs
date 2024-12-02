using GetVoloteaAirlinesLowCostTickets.VoloteaInterface;
using static GetVoloteaAirlinesLowCostTickets.VoloteaModel.VoloteaModel;

namespace GetVoloteaAirlinesLowCostTickets.VoloteaService
{
    internal class VoloteaService : IVolotea
    {
        public Task<FlightFare> GetSingleFlightInfo()
        {
            throw new NotImplementedException();
        }
    }
}
