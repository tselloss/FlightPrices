using AegeanUnitTests.Mock;
using FakeItEasy;
using FluentAssertions;
using GetAegeanAirlinesLowCostTickets.Interface;
using LowCostAirTickets.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AegeanUnitTests
{
    public class Tests
    {
        private IAegean _aegean;
        private ILogger<AegeanController> _logger;
        private AegeanController _aegeanController;

        [OneTimeSetUp]
        public void Setup()
        {
            _aegean = A.Fake<IAegean>();
            _logger = A.Fake<ILogger<AegeanController>>();  

            _aegeanController = A.Fake<AegeanController>(x => x.WithArgumentsForConstructor(() => new AegeanController(_logger,_aegean)));
        }

        [Test]
        public void AegeanController_GetSingleFlightInfo_Return_FlightInfo_Success()
        {
            // Arrange
            A.CallTo(() => _aegean.GetSingleFlightInfo()).Returns(AegeanMocks.SingleFlight());

            // Act
            var returnSingleFlight = _aegeanController.GetSingleFlightInfo();

            // Assert
            returnSingleFlight.IsCompletedSuccessfully.Should().BeTrue();
        }

        [Test]
        public void AegeanController_GetSingleFlightInfo_Return_FlightInfo_SelectedDestinations_Success()
        {
            // Arrange
            A.CallTo(() => _aegean.GetCheapestInboundMonth("JFK", "LHR"))
                .Returns(AegeanMocks.SingleFlight().SelectDestinations("JFK", "LHR"));
            // Act
            var returnSingleFlight = _aegeanController.GetSingleFlightInfo("JFK", "LHR");

            // Assert
            returnSingleFlight.IsCompletedSuccessfully.Should().BeTrue();
        }

        [Test]
        public void AegeanController_GetSingleFlightInfo_Return_FlightInfo_MultipleDestinations_Success()
        {
            // Arrange
            A.CallTo(() => _aegean.GetAllFlightsFromAthens())
                .Returns(AegeanMocks.MultipleFlightList());
            // Act
            var returnSingleFlight = _aegeanController.GetAllFlightsFromAthens();

            // Assert
            returnSingleFlight.IsCompletedSuccessfully.Should().BeTrue();
        }
    }
}