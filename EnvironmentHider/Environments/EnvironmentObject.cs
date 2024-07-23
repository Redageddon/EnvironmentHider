namespace EnvironmentHider.Environments;

public class EnvironmentObject
{
    public EnvironmentObject()
        : this(string.Empty)
    {
    }

    public EnvironmentObject(string name)
    {
        this.Name = name;
        this.Enabled = true;
    }

    [UIValue(nameof(Name))]
    public string Name { get; set; }

    [UIValue("environment-enabled")]
    public bool Enabled { get; set; }

    public void SetActive() => GameObject.Find(this.Name)?.SetActive(this.Enabled);
}