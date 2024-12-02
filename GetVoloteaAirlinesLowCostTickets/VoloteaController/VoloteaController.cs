using GetVoloteaAirlinesLowCostTickets.VoloteaInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GetVoloteaAirlinesLowCostTickets.VoloteaController
{
    [ApiController]
    [Route("[controller]")]
    public class VoloteaController : ControllerBase
    {
        private readonly ILogger<VoloteaController> _logger;
        private readonly IVolotea _volotea;


        public VoloteaController(ILogger<VoloteaController> logger, IVolotea volotea)
        {
            _logger = logger;
            _volotea = volotea ?? throw new ArgumentNullException(nameof(volotea));
        }


        [HttpGet("GetSingleFlightInfo")]
        public async Task<ActionResult<VoloteaModel.VoloteaModel>> GetSingleFlightInfo()
        {
            var flightInfo = await _volotea.GetSingleFlightInfo();
            return Ok(flightInfo);
        }

    }
}
