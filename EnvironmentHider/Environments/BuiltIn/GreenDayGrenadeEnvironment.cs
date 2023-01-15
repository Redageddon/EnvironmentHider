namespace EnvironmentHider.Environments.BuiltIn;

public class GreenDayGrenadeEnvironment : Environment
{
    public GreenDayGrenadeEnvironment()
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
            new("Logo"),
            new("BigSmokePS"),
            new("LightLinesTrackLaneRings"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("FrontLight"),
            new("GlowLineR"),
            new("GlowLineL"),
            new("GlowLineL (2)"),
            new("GlowLineL (4)"),
            new("GlowLineL (13)"),
            new("GlowLineL (14)"),
            new("GlowLineL (7)"),
            new("GlowLineL (8)"),
            new("GlowLineL (15)"),
            new("GlowLineL (16)"),
            new("GlowLineL (17)"),
            new("GlowLineL (18)"),
            new("GlowLineL (19)"),
            new("GlowLineL (20)"),
            new("GlowLineL (21)"),
            new("GlowLineL (22)"),
            new("GlowLineL (23)"),
            new("GlowLineL (24)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("RotatingLasersPair (5)"),
            new("GradientBackground"),
            new("GreenDayCity"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}