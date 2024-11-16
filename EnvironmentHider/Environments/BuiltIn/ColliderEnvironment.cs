namespace EnvironmentHider.Environments.BuiltIn;

public class ColliderEnvironment : Environment
{
    public ColliderEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("TrackMirror"),
            new("PlayersPlace"),
        };

        this.Dynamic = new List<EnvironmentObject>();

        this.Lights = new List<EnvironmentObject>
        {
            new("ColliderHUD"),
            new("DustPS"),
            new("BigSmokePS"),
            new("CoreLighting"),
            new("SideBlocks"),
            new("CenterBlocks"),
            new("Diamonds"),
            new("Runway"),
            new("Colliders"),
            new("Chevron"),
        };
    }
}