namespace EnvironmentHider.Environments.BuiltIn;

public class DefaultEnvironment : Environment
{
    public DefaultEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
            new("NearBuildingLeft (1)"),
            new("NearBuildingRight (1)"),
            new("NearBuildingLeft (2)"),
            new("NearBuildingRight (2)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BackColumns"),
            new("BasicGameHUD"),
            new("BigSmokePS"),
            new("SmallTrackLaneRings"),
            new("BigTrackLaneRings"),
            new("Spectrograms"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("GradientBackground"),
            new("LightEffects"),
            new("LightWithIdManager"),
            new("CoreLighting"),
            new("FrontLights"),
            new("DoubleColorLaserR"),
            new("DoubleColorLaserL"),
            new("DoubleColorLaserR (1)"),
            new("DoubleColorLaserL (1)"),
            new("DoubleColorLaserR (2)"),
            new("DoubleColorLaserL (2)"),
            new("DoubleColorLaserR (3)"),
            new("DoubleColorLaserL (3)"),
            new("DoubleColorLaserR (4)"),
            new("DoubleColorLaserL (4)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("NeonTubeL"),
            new("NeonTubeR"),
        };
    }
}