namespace GetAegeanAirlinesLowCostTickets.Extensions
{
    internal class StringConcatenation
    {
        public static string GetRoundTripUrl(string inbound, string outbound)
        {
            var staticUrl = "https://el.aegeanair.com/el/sys/LowFareCalendar/CalendarResults?TravelType=R&AirportFrom=";
            var addInbound = staticUrl + inbound;
            var getFinalUrl = addInbound + "&AirportTo=" + outbound;
            return getFinalUrl;
        }

        public static string GetOneWayTripUrl(string inbound, string outbound)
        {
            var staticUrl = "https://el.aegeanair.com/el/sys/LowFareCalendar/CalendarResults?TravelType=O&AirportFrom=";
            var addInbound = staticUrl + inbound;
            var getFinalUrl = addInbound + "&AirportTo=" + outbound;
            return getFinalUrl;
        }

        public static string GetAirportsFromAthUrl()
        {
            return "https://el.aegeanair.com/el/sys/flights/AirportsSearch?airport=ATH&airline=&expandGroups=false&hideGroups=false&direction=to&version=&searchKey=&showProviderOnlyAlsoAirports=true&showCodeshareOnlyAirports=true";
        }
    }
}
