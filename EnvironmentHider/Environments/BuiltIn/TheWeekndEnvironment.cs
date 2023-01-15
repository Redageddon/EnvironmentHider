namespace EnvironmentHider.Environments.BuiltIn;

public class TheWeekndEnvironment : Environment
{
    public TheWeekndEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("BasicGameHUD"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("RunwayLasers"),
            new("MiddleLaneLasersGroup"),
            new("CenterpieceRing"),
            new("ArrowsGroup"),
            new("LampsGroupLeft"),
            new("LampsGroupRight"),
            new("SideLasersGroupLeft"),
            new("SideLasersGroupRight"),
            new("BuildingsLeft"),
            new("BuildingsRight"),
            new("BackgroundBuildings"),
            new("PeripheralBuildings"),
        };
    }
}