using GetAegeanAirlinesLowCostTickets.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static GetAegeanAirlinesLowCostTickets.AegeanModel.AegeanModel;

namespace LowCostAirTickets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AegeanController : ControllerBase
    {

        private readonly ILogger<AegeanController> _logger;
        private readonly IAegean _Aegean;


        public AegeanController(ILogger<AegeanController> logger, IAegean Aegean)
        {
            _logger = logger;
            _Aegean = Aegean ?? throw new ArgumentNullException(nameof(Aegean));
        }

        [HttpGet("GetSingleFlightInfo")]
        public async Task<ActionResult<LowFareCalendarResponse>> GetSingleFlightInfo()
        {
            var flightInfo = await _Aegean.GetSingleFlightInfo();
            return Ok(flightInfo);
        }
    }
}