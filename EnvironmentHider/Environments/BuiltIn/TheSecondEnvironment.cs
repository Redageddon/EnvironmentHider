namespace EnvironmentHider.Environments.BuiltIn;

public class TheSecondEnvironment : Environment
{
    public TheSecondEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
            new("Buildings"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BackColumns"),
            new("BasicGameHUD"),
            new("BigSmokePS"),
            new("SmallTrackLaneRingsGroup"),
            new("BigTrackLaneRingsGroup"),
            new("DustPS"),
            new("SpectrogramsTheSecond"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("RunwayLasers"),
            new("Main Lasers Top"),
            new("Main Lasers Bottom"),
            new("FrontLogo"),
            new("SpotlightGroupLeft"),
            new("SpotlightGroupRight"),
        };
    }
}