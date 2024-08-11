using GetAegeanAirlinesLowCostTickets.Interface;
using GetAegeanAirlinesLowCostTickets.Service;
using LowCostAirTickets.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GetAegeanAirlinesLowCostTickets.DependencyInjection;

public static class Dependencies
{
    public static void AddAegeanServices(this IServiceCollection services)
    {
        services.AddSingleton<IAegean, Aegean>();
        services.AddSingleton<Aegean>();
    }
}
