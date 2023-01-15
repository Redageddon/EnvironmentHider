namespace EnvironmentHider.Environments.BuiltIn;

public class RockMixtapeEnvironment : Environment
{
    public RockMixtapeEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Runway"),
            new("PlayersPlace"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("DirectionalLights"),
            new("Aurora"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("LasersBack"),
            new("Tunnel"),
            new("Mountains"),
            new("Eyes"),
            new("Horns"),
            new("GuitarStrings"),
            new("GuitarBridge"),
            new("RunwayFront"),
            new("Spikes"),
            new("SideLasers"),
            new("VideoScreens"),
            new("BGBloom"),
            new("Static Batch Component Container"),
        };
    }
}