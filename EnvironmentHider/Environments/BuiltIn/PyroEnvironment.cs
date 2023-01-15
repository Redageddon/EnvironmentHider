namespace EnvironmentHider.Environments.BuiltIn;

public class PyroEnvironment : Environment
{
    public PyroEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Runway"),
            new("StarSkyPS"),
            new("StageRing"),
            new("FrontScaffolding"),
            new("ScreenSetupRight"),
            new("ScreenSetupLeft"),
            new("LightBoxesScaffoldingLeft"),
            new("LightBoxesScaffoldingRight"),
            new("PlayersPlace"),
            new("Stairs"),
            new("Behind"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("MainStageSetup"),
            new("Fire"),
            new("PlayerSetup"),
            new("SmokeLeft"),
            new("ProjectorArray"),
            new("PyroLogo"),
            new("CrowdFlipbookGroup"),
            new("Video"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("DirectionalLights"),
            new("CoreLighting"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("LightColorGroupEffectManager"),
            new("LightRotationGroupEffectManager"),
            new("MainLasers"),
            new("EnvironmentStartEndSongAudioEffect"),
        };
    }
}