using EnvironmentHider.Environments.BuiltIn;
using Environment = EnvironmentHider.Environments.Environment;

namespace EnvironmentHider.Settings;

public class PluginConfig
{
    public bool Enabled { get; set; } = true;

    public bool HideFogRing { get; set; }

    public bool HideMenuGround { get; set; }

    public bool HideMenuNotes { get; set; }

    public bool HideMenuPileOfNotes { get; set; }

    public bool HideLogo { get; set; }

    public bool HideRedLine { get; set; }

    public bool HideBlueLine { get; set; }

    [UseConverter(typeof(ListConverter<Environment>))]
    public List<Environment> Environments { get; set; } = new()
    {
        new BigMirrorEnvironment(),
        new BritneyEnvironment(),
        new BillieEnvironment(),
        new BTSEnvironment(),
        new CrabRaveEnvironment(),
        new ColliderEnvironment(),
        new DaftPunkEnvironment(),
        new DefaultEnvironment(),
        new Dragons2Environment(),
        new DragonsEnvironment(),
        new EDMEnvironment(),
        new FitBeatEnvironment(),
        new GagaEnvironment(),
        new GlassDesertEnvironment(),
        new GreenDayEnvironment(),
        new GreenDayGrenadeEnvironment(),
        new HalloweenEnvironment(),
        new HipHopEnvironment(),
        new InterscopeEnvironment(),
        new KaleidoscopeEnvironment(),
        new KDAEnvironment(),
        new LatticeEnvironment(),
        new LinkinParkEnvironment(),
        new LinkinPark2Environment(),
        new LizzoEnvironment(),
        new MonstercatEnvironment(),
        new NiceEnvironment(),
        new OriginsEnvironment(),
        new PanicEnvironment(),
        new Panic2Environment(),
        new PyroEnvironment(),
        new QueenEnvironment(),
        new RocketEnvironment(),
        new RockMixtapeEnvironment(),
        new SkrillexEnvironment(),
        new TheRollingStonesEnvironment(),
        new TheSecondEnvironment(),
        new TheWeekndEnvironment(),
        new TimbalandEnvironment(),
        new TriangleEnvironment(),
        new WeaveEnvironment(),
    };
}