namespace EnvironmentHider.Environments.BuiltIn;

public class OriginsEnvironment : Environment
{
    public OriginsEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Construction"),
            new("TrackConstruction"),
            new("PlayersPlace"),
            new("TrackMirror"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
            new("BigSmokePS"),
            new("Spectrograms"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("BigLightsTrackLaneRings"),
            new("SidePSR"),
            new("SidePSL"),
            new("LightWithIdManager"),
            new("CoreLighting"),
            new("LightEffects"),
            new("FrontLights"),
            new("LightAreaL"),
            new("LightAreaR"),
            new("GradientBackground"),
            new("NeonTube"),
            new("NeonTube (1)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("Laser"),
            new("Laser (1)"),
            new("Laser (2)"),
            new("Laser (3)"),
        };
    }
}