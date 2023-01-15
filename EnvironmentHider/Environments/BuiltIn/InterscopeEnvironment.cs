namespace EnvironmentHider.Environments.BuiltIn;

public class InterscopeEnvironment : Environment
{
    public InterscopeEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("LightmapLightsWithIds"),
            new("BakedReflectionProbe"),
            new("Logo"),
            new("PlayersPlace"),
            new("Floor"),
            new("RearPillar"),
            new("RearPillar (2)"),
            new("Pillar (4)"),
            new("Pillar (3)"),
            new("Pillar (2)"),
            new("Pillar (1)"),
            new("Pillar"),
            new("Plane (3)"),
            new("Plane (2)"),
            new("Plane (1)"),
            new("Plane (4)"),
            new("Plane (5)"),
            new("Plane (6)"),
            new("RearPillar (1)"),
            new("RearPillar (3)"),
            new("RearPillar (4)"),
            new("RearPillar (5)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("Spectrograms"),
            new("BigSmokePS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("DustPS"),
            new("FrontLight"),
            new("NarrowGameHUD"),
            new("Car1"),
            new("Car2"),
            new("Car3"),
            new("Car4"),
            new("FarCar1"),
            new("FarCar2"),
            new("FarCar3"),
            new("FarCar4"),
            new("NeonTop"),
            new("NeonTop (1)"),
            new("NeonTop (2)"),
            new("NeonTop (3)"),
            new("NeonTop (4)"),
            new("SinMoveLasersPair"),
            new("SinMoveLasersPair (1)"),
            new("SinMoveLasersPair (2)"),
            new("SinMoveLasersPair (3)"),
            new("SinMoveLasersPair (4)"),
            new("SinMoveLasersPair (5)"),
            new("SinMoveLasersPair (6)"),
        };
    }
}