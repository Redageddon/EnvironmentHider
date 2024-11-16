namespace EnvironmentHider.Environments.BuiltIn;

public class DaftPunkEnvironment : Environment
{
    public DaftPunkEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
        };

        this.Dynamic = new List<EnvironmentObject>();

        this.Lights = new List<EnvironmentObject>(){
            new("DaftPunkHUD"),
            new("DustPS"),
            new("BigSmokePS"),
            new("PlayersPlace"),
            new("CoreLighting"),
            new("TrisWall"),
            new("SideLasers"),
            new("Helmet01"),
            new("Helmet02"),
            new("Runway"),
            new("Orbits"),
            new("Stars"),};
    }
}