namespace EnvironmentHider.Environments.BuiltIn;

public class BritneyEnvironment : Environment
{
    public BritneyEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror_Britney"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("DustBritney"),
            new("BigSmokePS"),
            new("BasicGameHUD_Britney"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("TubeDisplay"),
            new("OuterTubeStage"),
            new("QuadSpeakers"),
            new("Stage"),
            new("TopCircularLasers"),
            new("Spirals"),
            new("Runway"),
            new("Stars"),
            new("Chevron"),
        };
    }
}