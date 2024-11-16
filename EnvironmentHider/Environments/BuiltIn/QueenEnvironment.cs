namespace EnvironmentHider.Environments.BuiltIn;

public class QueenEnvironment : Environment
{
    public QueenEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("LightWithIdManager"),
            new("LightEffects"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("DirectionalLights"),
            new("BottomSmoke"),
            new("Silhouette"),
            new("TunnelRings"),
            new("TunnelRingsReflProbeVariant"),
            new("VinylsLeft"),
            new("VinylsRight"),
            new("PlatformDeck"),
            new("Lasers"),
        };
    }
}