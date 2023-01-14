using EnvironmentHider.Managers;
using EnvironmentHider.Settings.UI;
using EnvironmentHider.Settings.UI.Controllers;

namespace EnvironmentHider.Installers;

public class EnvironmentHiderMenuInstaller : Installer
{
    public override void InstallBindings()
    {
        this.Container.Bind<OptionsScreenViewController>().FromNewComponentAsViewController().AsSingle();
        this.Container.Bind<EnvironmentHiderFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
        this.Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
        this.Container.BindInterfacesAndSelfTo<Managers.MenuEnvironmentManager>().AsSingle();
    }
}