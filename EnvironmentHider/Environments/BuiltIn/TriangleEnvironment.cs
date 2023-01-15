namespace EnvironmentHider.Environments.BuiltIn;

public class TriangleEnvironment : Environment
{
    public TriangleEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("FloorConstruction"),
            new("TrackMirror"),
            new("BackColumns"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
            new("PlayersPlace"),
            new("TriangleTrackLaneRings"),
            new("BigTrackLaneRings"),
            new("Spectrograms"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("LightEffects"),
            new("LightWithIdManager"),
            new("CoreLighting"),
            new("FrontLights"),
            new("NeonTubeDirectionalL"),
            new("NeonTubeDirectionalR"),
            new("RotatingLasersPair"),
            new("RotatingLasersPair (1)"),
            new("RotatingLasersPair (2)"),
            new("RotatingLasersPair (3)"),
            new("RotatingLasersPair (4)"),
            new("RotatingLasersPair (5)"),
            new("RotatingLasersPair (6)"),
            new("DoubleColorLaser"),
            new("DoubleColorLaser (1)"),
            new("DoubleColorLaser (2)"),
            new("DoubleColorLaser (3)"),
            new("DoubleColorLaser (4)"),
            new("DoubleColorLaser (5)"),
            new("DoubleColorLaser (6)"),
            new("DoubleColorLaser (7)"),
            new("DoubleColorLaser (8)"),
            new("DoubleColorLaser (9)"),
            new("GradientBackground"),
            new("NearBuildingLeft"),
            new("NearBuildingRight"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}