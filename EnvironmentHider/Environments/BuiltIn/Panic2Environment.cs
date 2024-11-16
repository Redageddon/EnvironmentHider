namespace EnvironmentHider.Environments.BuiltIn;

public class Panic2Environment : Environment
{
    public Panic2Environment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("TrackMirror"),
            new("BackColumns"),
            new("BottomCones"),
            new("TrackConstruction"),
        };

        this.Dynamic = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("BigSmokePS"),
            new("DustPS"),
        };

        this.Lights = new List<EnvironmentObject>
        {
            new("Windows"),
            new("Cones"),
            new("DiamondRing"),
            new("MainLasers"),
            new("Spectrogram"),
            new("RunwayLasers"),
            new("Static Batch Component Container"),
        };
    }
}