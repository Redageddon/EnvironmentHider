using IPA.Config.Stores.Attributes;

namespace EnvironmentHider.Environments;

public class EnvironmentObject
{
    private GameObject? gameObject;

    public EnvironmentObject()
    {
        this.Name = string.Empty;
        this.Enabled = true;
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

    [Ignore]
    public GameObject? GameObject => this.gameObject ??= GameObject.Find(this.Name);
}