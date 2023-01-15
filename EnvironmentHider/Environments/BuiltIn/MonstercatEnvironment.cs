namespace EnvironmentHider.Environments.BuiltIn;

public class MonstercatEnvironment : Environment
{
    public MonstercatEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("NearBuildingRight"),
            new("NearBuildingLeft"),
            new("PlayersPlace"),
            new("TrackMirror"),
            new("VConstruction"),
            new("FarBuildings"),
            new("SpectrogramEnd"),
            new("Construction"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
            new("MonstercatLogoL"),
            new("MonstercatLogoR"),
            new("Spectrograms"),
            new("SmallTrackLaneRings"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("FrontLights"),
            new("GlowTopLine (5)"),
            new("GlowTopLine (6)"),
            new("GlowTopLine (7)"),
            new("GlowTopLine (8)"),
            new("GlowTopLine (9)"),
            new("GlowTopLine (10)"),
            new("GlowTopLine (11)"),
            new("GlowLineL"),
            new("GlowLineR"),
            new("GlowLineL (1)"),
            new("GlowLineR (1)"),
            new("Laser (4)"),
            new("Laser (5)"),
            new("Laser (7)"),
            new("Laser (8)"),
            new("Laser (9)"),
            new("Laser (10)"),
            new("Laser (11)"),
            new("Laser (12)"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (4)"),
            new("GradientBackground"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}