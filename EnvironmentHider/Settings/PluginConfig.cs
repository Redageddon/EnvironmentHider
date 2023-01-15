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
        new BigMirrorEnvironment(),
        new BillieEnvironment(),
        new BTSEnvironment(),
        new CrabRaveEnvironment(),
        new DefaultEnvironment(),
        new DragonsEnvironment(),
        new EDMEnvironment(),
        new FitBeatEnvironment(),
        new GagaEnvironment(),
        new GlassDesertEnvironment(),
        new GreenDayEnvironment(),
        new GreenDayGrenadeEnvironment(),
        new HalloweenEnvironment(),
        new InterscopeEnvironment(),
        new KaleidoscopeEnvironment(),
        new KDAEnvironment(),
        new LinkinParkEnvironment(),
        new LizzoEnvironment(),
        new MonstercatEnvironment(),
        new NiceEnvironment(),
        new OriginsEnvironment(),
        new PanicEnvironment(),
        new PyroEnvironment(),
        new RocketEnvironment(),
        new RockMixtapeEnvironment(),
        new SkrillexEnvironment(),
        new TheSecondEnvironment(),
        new TheWeekndEnvironment(),
        new TimbalandEnvironment(),
        new TriangleEnvironment(),
        new WeaveEnvironment(),
    };
}