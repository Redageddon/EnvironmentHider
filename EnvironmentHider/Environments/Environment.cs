namespace EnvironmentHider.Environments;

public class Environment
{
    private string name = string.Empty;

    [UIValue(nameof(Name))]
    public string Name
    {
        get => this.name == string.Empty ? this.GetType().Name : this.name; // Only use for serialization
        set => this.name = value;                                           // Only use for deserialization
    }

    public bool Enabled { get; set; } = true;

    [UseConverter(typeof(ListConverter<EnvironmentObject>))]
    public List<EnvironmentObject> Static { get; set; } = new();

    [UseConverter(typeof(ListConverter<EnvironmentObject>))]
    public List<EnvironmentObject> Dynamic { get; set; } = new();

    [UseConverter(typeof(ListConverter<EnvironmentObject>))]
    public List<EnvironmentObject> Lights { get; set; } = new();
}