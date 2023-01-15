namespace EnvironmentHider.Environments.BuiltIn;

public class FitBeatEnvironment : Environment
{
    public FitBeatEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("Spectrograms"),
            new("PanelsLightsTrackLaneRings"),
            new("BigCenterLightsTrackLaneRings"),
            new("BigSmokePS"),
            new("CoreLighting"),
            new("LightEffects"),
            new("LightWithIdManager"),
            new("FrontLights"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("RotatingLasersPair (5)"),
            new("RotatingLasersPair (6)"),
            new("RotatingLasersPair (7)"),
            new("GradientBackground"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}