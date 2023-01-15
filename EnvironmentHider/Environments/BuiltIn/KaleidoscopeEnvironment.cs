namespace EnvironmentHider.Environments.BuiltIn;

public class KaleidoscopeEnvironment : Environment
{
    public KaleidoscopeEnvironment()
    {
        this.Static = new List<EnvironmentObject>();

        this.Dynamic = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("SmallTrackLaneRings"),
            new("DistantRings"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
            new("LightEffects"),
            new("LightWithIdManager"),
            new("CoreLighting"),
            new("GradientBackground"),
            new("TrackMirror"),
            new("Construction"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}