namespace EnvironmentHider.Environments.BuiltIn;

public class RocketEnvironment : Environment
{
    public RocketEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Mirror"),
            new("RocketArena"),
            new("Construction"),
            new("PlayersPlace"),
            new("RocketCarL"),
            new("RocketCarR"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
            new("RocketArenaLight"),
            new("BigSmokePS"),
            new("RocketGateLight"),
            new("LightWithIdManager"),
            new("DirectionalLightManager"),
            new("CoreLighting"),
            new("LightEffects"),
            new("GateLight0"),
            new("GateLight1"),
            new("FrontLights"),
            new("GateLight1 (4)"),
            new("EnvLight0"),
            new("EnvLight0 (2)"),
            new("EnvLight0 (4)"),
            new("EnvLight0 (6)"),
            new("EnvLight0 (7)"),
            new("EnvLight0 (8)"),
            new("EnvLight0 (3)"),
            new("EnvLight0 (5)"),
            new("EnvLight0 (9)"),
            new("GlowLineL (1)"),
            new("GlowLineR (1)"),
            new("GlowLineL (2)"),
            new("GlowLineL (3)"),
            new("GlowLineL (4)"),
            new("GlowLineL (5)"),
            new("BackColumns"),
            new("GlowLineL (6)"),
            new("GlowLineL (7)"),
            new("GlowLineL (8)"),
            new("GlowLineL (9)"),
            new("GradientBackground"),
            new("RotatingLasersPair (13)"),
            new("RotatingLasersPair (12)"),
            new("RotatingLasersPair (7)"),
            new("RotatingLasersPair (8)"),
            new("RotatingLasersPair (9)"),
            new("RotatingLasersPair (10)"),
            new("RotatingLasersPair (11)"),
            new("BakedReflectionProbe"),
            new("BSBakedLightingLightWithIds"),
            new("FakeMirrorSettings"),
            new("BakedReflectionProbeInstaller"),
        };
    }
}