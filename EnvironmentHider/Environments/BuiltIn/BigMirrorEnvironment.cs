namespace EnvironmentHider.Environments.BuiltIn;

public class BigMirrorEnvironment : Environment
{
    public BigMirrorEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Floor"),
            new("BackColumns"),
            new("Construction"),
            new("PlayersPlace"),
            new("NearBuildingLeft"),
            new("NearBuildingRight"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
            new("Spectrograms"),
            new("BigTrackLaneRings"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("FrontLights"),
            new("DoubleColorLaser"),
            new("DoubleColorLaser (4)"),
            new("DoubleColorLaser (1)"),
            new("DoubleColorLaser (2)"),
            new("DoubleColorLaser (3)"),
            new("DoubleColorLaser (5)"),
            new("DoubleColorLaser (6)"),
            new("DoubleColorLaser (8)"),
            new("DoubleColorLaser (7)"),
            new("DoubleColorLaser (9)"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("NeonTubeDirectionalL"),
            new("NeonTubeDirectionalFL"),
            new("NeonTubeDirectionalR"),
            new("NeonTubeDirectionalFR"),
            new("GradientBackground"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}