using EnvironmentHider.Settings.UI.Controllers;

namespace EnvironmentHider.Settings.UI;

public class EnvironmentHiderFlowCoordinator : FlowCoordinator
{
    [Inject] private MainFlowCoordinator mainFlowCoordinator = null!;

    [Inject] private OptionsScreenViewController optionsScreenViewController = null!;

    protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
    {
        if (firstActivation)
        {
            this.SetTitle("Environment Hider");
            this.showBackButton = true;
        }

        this.ProvideInitialViewControllers(this.optionsScreenViewController);
    }

    protected override void BackButtonWasPressed(ViewController _) => this.mainFlowCoordinator.DismissFlowCoordinator(this);
}