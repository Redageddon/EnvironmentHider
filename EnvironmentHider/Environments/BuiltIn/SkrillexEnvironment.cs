namespace EnvironmentHider.Environments.BuiltIn;

public class SkrillexEnvironment : Environment
{
    public SkrillexEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("LightEffects"),
            new("BasicGameHUD"),
            new("DustPS"),
            new("BigSmokePS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LightWithIdManager"),
            new("GradientBackground"),
            new("SideMoveLasers"),
            new("TrackLaneRings1"),
            new("TrackLaneRings2"),
            new("LeftLaser"),
            new("RightLaser"),
            new("TrackBL"),
            new("TrackBR"),
            new("TrackTR"),
            new("TrackTL"),
            new("SkrillexLogo"),
            new("SkrillexLogo (1)"),
            new("LogoL"),
            new("LogoR"),
            new("NeonSide"),
            new("NeonSide (1)"),
            new("NeonSide (2)"),
            new("NeonSide (3)"),
            new("NeonSide (4)"),
            new("NeonSide (5)"),
            new("NeonSide (6)"),
            new("NeonSide (7)"),
            new("NeonSide (8)"),
            new("NeonSide (9)"),
            new("NeonSide (10)"),
            new("NeonSide (11)"),
            new("NeonSide (12)"),
            new("NeonSide (13)"),
            new("NeonSide (14)"),
            new("NeonSide (15)"),
            new("NeonSide (16)"),
            new("NeonSide (17)"),
        };
    }
}