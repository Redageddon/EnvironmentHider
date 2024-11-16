namespace EnvironmentHider.Environments.BuiltIn;

public class LatticeEnvironment : Environment
{
    public LatticeEnvironment()
    {
        this.Static = new List<EnvironmentObject>();

        this.Dynamic = new List<EnvironmentObject>
        {
            new("LightWithIdManager"),
            new("LightEffects"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("DirectionalLights"),
            new("Runway"),
            new("CubesGlobal"),
            new("Chevron"),
            new("DustPS"),
            new("BigSmokePS"),
        };
    }
}