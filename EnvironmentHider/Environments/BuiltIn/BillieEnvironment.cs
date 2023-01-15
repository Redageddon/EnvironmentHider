namespace EnvironmentHider.Environments.BuiltIn;

public class BillieEnvironment : Environment
{
    public BillieEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("Mountains"),
            new("PlayersPlace"),
            new("LeftRail"),
            new("RightRail"),
            new("LeftFarRail1"),
            new("LeftFarRail2"),
            new("RightFarRail1"),
            new("RightFarRail2"),
            new("RailingFullBack"),
            new("RailingFullFront"),
            new("LastRailingCurve"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("Rain"),
            new("WaterRainRipples"),
            new("Waterfall"),
            new("DayAndNight"),
            new("Clouds"),
            new("BigSmokePS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("LightRailingSegment"),
            new("LightRailingSegment (1)"),
            new("LightRailingSegment (2)"),
            new("LightRailingSegment (3)"),
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
            new("BottomPairLasers"),
            new("BottomPairLasers (1)"),
            new("BottomPairLasers (2)"),
            new("BottomPairLasers (3)"),
            new("BottomPairLasers (4)"),
            new("BottomPairLasers (5)"),
            new("BottomPairLasers (6)"),
            new("BottomPairLasers (7)"),
            new("BottomPairLasers (8)"),
        };
    }
}