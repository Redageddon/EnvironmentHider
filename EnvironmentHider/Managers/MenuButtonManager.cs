using EnvironmentHider.Settings.UI;

namespace EnvironmentHider.Managers;

public class MenuButtonManager : IInitializable, IDisposable
{
    private readonly EnvironmentHiderFlowCoordinator environmentHiderFlowCoordinator;
    private readonly MainFlowCoordinator mainFlowCoordinator;
    private readonly MenuButton menuButton;

    public MenuButtonManager(MainFlowCoordinator mainFlowCoordinator, EnvironmentHiderFlowCoordinator environmentHiderFlowCoordinator)
    {
        this.mainFlowCoordinator = mainFlowCoordinator;
        this.environmentHiderFlowCoordinator = environmentHiderFlowCoordinator;
        this.menuButton = new MenuButton("Environment Hider", "Enable or disable anything in any environment.", this.ShowBackgroundFlow);
    }

    public void Initialize() => MenuButtons.instance.RegisterButton(this.menuButton);

    public void Dispose()
    {
        if (MenuButtons.IsSingletonAvailable)
        {
            MenuButtons.instance.UnregisterButton(this.menuButton);
        }
    }

    private void ShowBackgroundFlow() => this.mainFlowCoordinator.PresentFlowCoordinator(this.environmentHiderFlowCoordinator);
}