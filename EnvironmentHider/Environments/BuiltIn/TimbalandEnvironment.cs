namespace EnvironmentHider.Environments.BuiltIn;

public class TimbalandEnvironment : Environment
{
    public TimbalandEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("MainStructure"),
            new("TopStructure"),
            new("Buildings"),
            new("TrackMirror"),
            new("TrackConstruction"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("Spectrograms"),
            new("BasicGameHUD"),
            new("PlayersPlace"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("PairLaserTrackLaneRings"),
            new("BigSmokePS"),
            new("CoreLighting"),
            new("TimbalandLogo"),
            new("LightEffects"),
            new("LightWithIdManager"),
            new("TimbalandLogo (1)"),
            new("TimbalandLogo (2)"),
            new("TimbalandLogo (3)"),
            new("GlowLineL"),
            new("GlowLineR"),
            new("Light (4)"),
            new("Light (6)"),
            new("Light (5)"),
            new("BackColumns"),
            new("Light (7)"),
            new("GradientBackground"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}