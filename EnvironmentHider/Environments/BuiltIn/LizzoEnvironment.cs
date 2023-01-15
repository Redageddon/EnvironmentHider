namespace EnvironmentHider.Environments.BuiltIn;

public class LizzoEnvironment : Environment
{
    public LizzoEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("CloudsBackground"),
            new("RunwayArch"),
            new("BackgroundStructures"),
            new("PlayersPlace"),
            new("TrackMirror"),
        };

        this.Dynamic = new List<EnvironmentObject>();

        this.Lights = new List<EnvironmentObject>
        {
            new("LizzoHUDWrapper"),
            new("BigSmokePS"),
            new("DustPS"),
            new("BalloonParticles"),
            new("DanceFloor"),
            new("SidewayLasersLeft"),
            new("SidewayLasersRight"),
            new("DanceFloorMirrored"),
            new("RunwayLasers"),
            new("Rainbow"),
            new("SpotlightStructure"),
            new("CloudLights"),
            new("LetterStands"),
            new("BehindRainbowSpotlights"),
            new("StandLasersLeft"),
            new("StandLasersRight"),
            new("Static Batch Component Container"),
        };
    }
}