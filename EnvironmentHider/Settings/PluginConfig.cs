using EnvironmentHider.Environments.BuiltIn;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;
using Environment = EnvironmentHider.Environments.Environment;

namespace EnvironmentHider.Settings;

public class PluginConfig
{
    public bool Enabled { get; set; } = true;

    public bool HideMenuGround { get; set; }

    public bool HideMenuNotes { get; set; } = true;

    public bool HideMenuPileOfNotes { get; set; } = true;

    [UseConverter(typeof(ListConverter<Environment>))]
    public List<Environment> Environments { get; set; } = new()
    {
        new DefaultEnvironment(),
    };
}