namespace EnvironmentHider.Environments.BuiltIn;

public class EDMEnvironment : Environment
{
    public EDMEnvironment()
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
            new("TopCircle"),
            new("CloseCircle"),
            new("DistantCircle1"),
            new("DistantCircle2"),
            new("SingleSourceCircularLY"),
            new("SingleSourceCircularRY"),
            new("SingleSourceLaserUp"),
            new("SingleSourceLaserLeftMid"),
            new("SingleSourceLaserDown"),
            new("SingleSourceLaserRightMid"),
            new("SingleSourceLaserDown"),
            new("Spectrograms"),
            new("Spectrograms (1)"),
            new("Laser"),
            new("Laser (1)"),
            new("Laser (2)"),
            new("Laser (3)"),
            new("Laser (4)"),
        };
    }
}