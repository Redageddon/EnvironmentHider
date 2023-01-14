using EnvironmentHider.Managers;
using EnvironmentHider.Settings;

namespace EnvironmentHider.Installers;

internal class EnvironmentHiderGameInstaller : Installer
{
    private readonly PluginConfig config;

    private EnvironmentHiderGameInstaller(PluginConfig config)
    {
        this.config = config;
    }

    public override void InstallBindings()
    {
        if (this.config.Enabled)
        {
            this.Container.BindInstance(this.config).AsSingle();
            this.Container.BindInterfacesAndSelfTo<GameEnvironmentManager>().AsSingle();
        }
    }
}