using GetAegeanAirlinesLowCostTickets.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;
using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace LowCostAirTickets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AegeanController : ControllerBase
    {

        private readonly ILogger<AegeanController> _logger;
        private readonly IAegean _aegean;


        public AegeanController(ILogger<AegeanController> logger, IAegean Aegean)
        {
            _logger = logger;
            _aegean = Aegean ?? throw new ArgumentNullException(nameof(Aegean));
        }

        [HttpGet("GetSingleFlightInfo")]
        public async Task<ActionResult<LowFareCalendarResponse>> GetSingleFlightInfo()
        {
            var flightInfo = await _aegean.GetSingleFlightInfo();
            return Ok(flightInfo);
        }

        [HttpGet("GetCheapestInboundMonthForSpecificPlaces")]
        public async Task<ActionResult<LowFareCalendarResponse>> GetSingleFlightInfo(string inbound, string outbound)
        {
            var flightInfo = await _aegean.GetCheapestInboundMonth(inbound, outbound);
            return Ok(flightInfo);
        }


        [HttpGet("GetCheapestInboundMonthFromAthens")]
        public async Task<ActionResult<List<LowFareCalendarResponse>>> GetAllFlightsFromAthens()
        {
            var pricesForAll = await _aegean.GetAllFlightsFromAthens();

            return Ok(pricesForAll);
        }
    }
}