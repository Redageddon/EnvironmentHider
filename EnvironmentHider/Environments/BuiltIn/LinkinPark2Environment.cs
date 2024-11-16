namespace EnvironmentHider.Environments.BuiltIn;

public class LinkinPark2Environment : Environment
{
    public LinkinPark2Environment()
    {
        this.Static = new List<EnvironmentObject>
        {
            new("PlayersPlace"),
            new("TrackMirror"),
        };

        this.Dynamic = new List<EnvironmentObject> {
            new("DustPS"),
            new("BigSmokePS"),};

        this.Lights = new List<EnvironmentObject> {
            new("Spectrograms"),
            new("Logo"),
            new("CircularTunnel"),
            new("Lasers"),
            new("Floor"),
            new("BigArcsGlobal"),};
    }
}