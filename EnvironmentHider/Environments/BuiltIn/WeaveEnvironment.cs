namespace EnvironmentHider.Environments.BuiltIn;

public class WeaveEnvironment : Environment
{
    public WeaveEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightEffects"),
            new("LightColorGroupEffectManager"),
            new("LightRotationGroupEffectManager"),
            new("LightWithIdManager"),
            new("LightGroup0"),
            new("LightGroup1"),
            new("LightGroup2"),
            new("LightGroup3"),
            new("LightGroup4"),
            new("LightGroup5"),
            new("LightGroup6"),
            new("LightGroup7"),
            new("LightGroup8"),
            new("LightGroup9"),
            new("LightGroup10"),
            new("LightGroup11"),
            new("LightGroup12"),
            new("LightGroup13"),
            new("LightGroup14"),
            new("LightGroup15"),
        };
    }
}