namespace EnvironmentHider.Environments.BuiltIn;

public class PanicEnvironment : Environment
{
    public PanicEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("BackColumns"),
            new("PlayersPlace"),
            new("Window"),
            new("BottomCones"),
            new("TopCones"),
            new("TrackMirror"),
            new("TrackConstruction"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
            new("Spectrograms"),
            new("BigSmokePS"),
            new("Panels4TrackLaneRings"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("ConstructionGlowLine (4)"),
            new("ConstructionGlowLine (5)"),
            new("ConstructionGlowLine (6)"),
            new("ConstructionGlowLine (7)"),
            new("ConstructionGlowLine (8)"),
            new("ConstructionGlowLine (15)"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("Light (5)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("RotatingLasersPair (5)"),
            new("RotatingLasersPair (6)"),
            new("NeonTube"),
            new("NeonTube (1)"),
            new("GradientBackground"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}