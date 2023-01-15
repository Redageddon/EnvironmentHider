namespace EnvironmentHider.Environments.BuiltIn;

public class NiceEnvironment : Environment
{
    public NiceEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Floor"),
            new("BackColumns"),
            new("PlayersPlace"),
            new("NearBuildingRight (1)"),
            new("NearBuildingLeft (1)"),
            new("NearBuildingLeft (2)"),
            new("NearBuildingRight (2)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("SmallTrackLaneRings"),
            new("BigTrackLaneRings"),
            new("BigSmokePS"),
            new("BasicGameHUD"),
            new("Spectrograms"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("LightWithIdManager"),
            new("CoreLighting"),
            new("LightEffects"),
            new("FrontLights"),
            new("GlowLineL"),
            new("GlowLineR"),
            new("GlowLineFarL"),
            new("GlowLineFarR"),
            new("RotatingLaserLeft"),
            new("RotatingLaserRight"),
            new("RotatingLaserLeft (1)"),
            new("RotatingLaserRight (1)"),
            new("RotatingLaserLeft (2)"),
            new("RotatingLaserRight (2)"),
            new("RotatingLaserLeft (3)"),
            new("RotatingLaserRight (3)"),
            new("DoubleColorLaser"),
            new("DoubleColorLaser (1)"),
            new("DoubleColorLaser (2)"),
            new("DoubleColorLaser (3)"),
            new("DoubleColorLaser (4)"),
            new("DoubleColorLaser (5)"),
            new("DoubleColorLaser (6)"),
            new("DoubleColorLaser (7)"),
            new("GradientBackground"),
        };
    }
}