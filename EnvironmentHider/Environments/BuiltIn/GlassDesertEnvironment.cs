namespace EnvironmentHider.Environments.BuiltIn;

public class GlassDesertEnvironment : Environment
{
    public GlassDesertEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Collider"),
            new("PlayersPlace"),
            new("TopLightMesh"),
            new("Floor"),
            new("SeparatorWall"),
            new("SeparatorWall (1)"),
            new("SeparatorWall (2)"),
            new("SeparatorWall (3)"),
            new("SeparatorWall (4)"),
            new("SeparatorWall (5)"),
            new("SeparatorWall (6)"),
            new("SeparatorWall (7)"),
            new("SeparatorWall (8)"),
            new("SeparatorWall (9)"),
            new("SeparatorWall (10)"),
            new("SeparatorWall (11)"),
            new("SeparatorWall (12)"),
            new("SeparatorWall (13)"),
            new("SeparatorWall (14)"),
            new("SeparatorWall (15)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("FlyingGameHUD"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightEffects"),
            new("DownLaser (9)"),
            new("DownLaser (12)"),
            new("DownLaser (10)"),
            new("DownLaser (11)"),
            new("DownLaser (4)"),
            new("DownLaser (5)"),
            new("DownLaser (6)"),
            new("DownLaser (7)"),
            new("TopLaser"),
            new("TopLaser (1)"),
            new("TopLaser (2)"),
            new("TopLaser (3)"),
            new("TopLaser (4)"),
            new("TopLaser (5)"),
            new("LightPillar (9)"),
            new("LightPillar (19)"),
            new("LightPillar (20)"),
            new("LightPillar (21)"),
            new("LightPillar (10)"),
            new("LightPillar (23)"),
            new("LightPillar (11)"),
            new("LightPillar (24)"),
            new("LightPillar (12)"),
            new("LightPillar (25)"),
            new("GradientBackground"),
        };
    }
}