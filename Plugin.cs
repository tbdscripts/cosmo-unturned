using System.Threading.Tasks;
using Rocket.API.DependencyInjection;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace Cosmo.Unturned;

public class Plugin : Plugin<PluginConfiguration>
{
    public Plugin(IDependencyContainer container) : base("Cosmo.Unturned", container)
    {
        //
    }

    protected override async Task OnActivate(bool isFromReload)
    {
        Logger.LogInformation("Hello World!");
        
        await SaveConfigurationAsync();
    }

    protected override async Task OnDeactivate()
    {
        Logger.LogInformation("Good bye :(");
    }
}