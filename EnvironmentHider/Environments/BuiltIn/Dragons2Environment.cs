namespace EnvironmentHider.Environments.BuiltIn;

public class Dragons2Environment : Environment
{
    public Dragons2Environment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
            new("HallConstruction"),
        };

        this.Dynamic = new List<EnvironmentObject>();

        this.Lights = new List<EnvironmentObject>
        {
            new("Dragons2HUD"),
            new("Spectrograms"),
            new("BigSmokePS"),
            new("DustPS"),
            new("NewUnderground"),
            new("TopSpotlightsGroup"),
            new("RunwayLasersLeft"),
            new("RunwayLasersRight"),
            new("SmallRingsLightGroup"),
            new("BigRingsGroup"),
            new("DragonParticlesGroupLeft"),
            new("DragonParticlesGroupRight"),
            new("FrontLights"),
            new("TopLasersLeftTop"),
            new("TopLasersLeftBottom"),
            new("TopLasersRightTop"),
            new("TopLasersRightBottom"),
            new("GlowLines"),
        };
    }
}