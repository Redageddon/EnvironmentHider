namespace EnvironmentHider.Environments.BuiltIn;

public class DragonsEnvironment : Environment
{
    public DragonsEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
            new("HallConstruction"),
            new("Underground"),
        };

        this.Dynamic = new List<EnvironmentObject>();

        this.Lights = new List<EnvironmentObject>
        {
            new("GlowLineL"),
            new("BasicGameHUD"),
            new("Spectrograms"),
            new("PanelsTrackLaneRings"),
            new("BigTrackLaneRings"),
            new("BigSmokePS"),
            new("DustPS"),
            new("DragonsSidePSL"),
            new("DragonsSidePSR"),
            new("GlowLineR"),
            new("CoreLighting"),
            new("LightEffects"),
            new("LightWithIdManager"),
            new("FrontLights"),
            new("ConstructionGlowLine (1)"),
            new("ConstructionGlowLine (6)"),
            new("ConstructionGlowLine (4)"),
            new("ConstructionGlowLine (5)"),
            new("GradientBackground"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}