using EnvironmentHider.Installers;
using EnvironmentHider.Settings;

namespace EnvironmentHider;

[Plugin(RuntimeOptions.DynamicInit)]
[NoEnableDisable]
public class Plugin
{
    [Init]
    public Plugin(IPA.Logging.Logger logger, IPA.Config.Config config, Zenjector zenjector)
    {
        Logger.Log = logger;

        PluginConfig pluginConfig = config.Generated<PluginConfig>();
        zenjector.Install(Location.App, container => container.BindInstance(pluginConfig).AsSingle());
        zenjector.Install<EnvironmentHiderMenuInstaller>(Location.Menu);
        zenjector.Install<EnvironmentHiderGameInstaller>(Location.Player);
    }
}