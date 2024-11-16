namespace EnvironmentHider.Environments.BuiltIn;

public class HipHopEnvironment : Environment
{
    public HipHopEnvironment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("FakeMirrorSettings"),
            new("BakedReflectionProbe"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("TrackMirror"),
            new("PlayersPlace"),
            new("BasicGameHUD"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("BigSmokePS"),
            new("DustPS"),
            new("Spectrograms"),
            new("GraffitiRoot"),
            new("Baskets"),
            new("Trains"),
            new("Runway"),
            new("RoofPosition"),
            new("WallsPosition"),
            new("PlatformsPosition"),
            new("CeilingLightsGroupRight"),
            new("CeilingLightsGroupLeft"),
            new("PillarsRight"),
            new("PillarsLeft"),
            new("LasersParallelRight"),
            new("LasersParallelLeft"),
        };
    }
}