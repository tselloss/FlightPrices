namespace GetAegeanAirlinesLowCostTickets.Extensions
{
    internal class StringConcatenation
    {
        public static string GetUrl(string inbound, string outbound)
        {
            var staticUrl = "https://el.aegeanair.com/el/sys/LowFareCalendar/CalendarResults?TravelType=R&AirportFrom=";
            var addInbound = staticUrl + inbound;
            var addOutbound = addInbound + "&AirportTo=" + outbound;
            var getFullUrl = addOutbound;
            return getFullUrl;
        }            
    }
}
