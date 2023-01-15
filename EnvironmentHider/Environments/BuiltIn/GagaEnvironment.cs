namespace EnvironmentHider.Environments.BuiltIn;

public class GagaEnvironment : Environment
{
    public GagaEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Runway"),
            new("Construction"),
            new("PlayersPlace"),
            new("BackCube"),
            new("TubeR"),
            new("TubeL"),
            new("TubeL (1)"),
            new("RunwayPillarLow (1)"),
            new("RunwayPillarLow (2)"),
            new("RunwayPillar"),
            new("Tower"),
            new("Tower (3)"),
            new("Tower (1)"),
            new("Tower (2)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("Logo"),
            new("NarrowGameHUD"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("FloorLightTilesGridEffect"),
            new("TeslaTower1L"),
            new("TeslaTower1R"),
            new("TeslaTower2L"),
            new("TeslaTower2R"),
            new("TeslaTower3L"),
            new("TeslaTower3R"),
            new("SmokePSL"),
            new("SmokePSR"),
            new("StarSky"),
            new("Aurora"),
            new("CoreLighting"),
            new("DirectionalLights"),
            new("LightWithIdManager"),
            new("LightEffects"),
            new("GradientBackground"),
            new("FrontLasers"),
        };
    }
}