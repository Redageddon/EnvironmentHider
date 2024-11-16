namespace EnvironmentHider.Environments.BuiltIn;

public class TheRollingStonesEnvironment : Environment
{
    public TheRollingStonesEnvironment()
    {
        this.Static = new List<EnvironmentObject>();

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
        };

        this.Lights = new List<EnvironmentObject>()
        {
            new("BigSmokePS"),
            new("PlayersPlace"),
            new("DustPS"),
            new("HeartCube"),
            new("Columns"),
            new("Floor"),
            new("Lasers"),
            new("Splinters"),
        };
    }
}