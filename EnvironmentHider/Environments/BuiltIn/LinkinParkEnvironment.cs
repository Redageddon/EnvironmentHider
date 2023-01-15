namespace EnvironmentHider.Environments.BuiltIn;

public class LinkinParkEnvironment : Environment
{
    public LinkinParkEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("TunnelRings"),
            new("PlayersPlace"),
            new("TrackMirror"),
            new("TrackConstruction"),
            new("LinkinParkSoldier"),
            new("LinkinParkTextLogoR"),
            new("LinkinParkTextLogoL"),
            new("Tunnel"),
            new("Tunnel (1)"),
            new("Tunnel (2)"),
            new("Tunnel (3)"),
            new("Tunnel (4)"),
            new("Tunnel (5)"),
            new("Tunnel (6)"),
            new("Tunnel (7)"),
            new("Tunnel (8)"),
            new("Tunnel (9)"),
            new("Tunnel (10)"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("NarrowGameHUD"),
            new("Spectrograms"),
            new("DustPS"),
            new("BigSmokePS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("CoreLighting"),
            new("LogoLight"),
            new("Logo"),
            new("LaserL"),
            new("LaserL (2)"),
            new("LarerR"),
            new("LarerR (2)"),
            new("LaserFloor (2)"),
            new("LaserFloor (3)"),
            new("LaserFloor (4)"),
            new("TunnelRotatingLasersPair"),
            new("TunnelRotatingLasersPair (1)"),
            new("TunnelRotatingLasersPair (2)"),
            new("TunnelRotatingLasersPair (3)"),
            new("TunnelRotatingLasersPair (4)"),
            new("TunnelRotatingLasersPair (5)"),
            new("TunnelRotatingLasersPair (6)"),
            new("TunnelRotatingLasersPair (7)"),
            new("TunnelRotatingLasersPair (8)"),
            new("TunnelRotatingLasersPair (9)"),
            new("TunnelRotatingLasersPair (10)"),
            new("TunnelRotatingLasersPair (11)"),
            new("TunnelRotatingLasersPair (12)"),
            new("TunnelRotatingLasersPair (13)"),
            new("TunnelRotatingLasersPair (14)"),
            new("TunnelRotatingLasersPair (15)"),
            new("TunnelRotatingLasersPair (16)"),
            new("TunnelRotatingLasersPair (17)"),
            new("LaserTop"),
            new("LaserTop (1)"),
            new("LaserTop (2)"),
            new("LaserTop (3)"),
            new("LaserTop (4)"),
            new("LaserTop (5)"),
            new("LaserTop (6)"),
            new("LaserTop (7)"),
        };
    }
}