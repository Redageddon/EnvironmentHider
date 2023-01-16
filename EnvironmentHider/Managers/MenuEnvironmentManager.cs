using EnvironmentHider.Settings;

namespace EnvironmentHider.Managers;

public class MenuEnvironmentManager : IInitializable
{
    private readonly PluginConfig pluginConfig;
    private GameObject? fogRing;
    private GameObject? ground;
    private GameObject? notes;
    private GameObject? pileOfNotes;
    private GameObject? logo;
    private GameObject? redLine;
    private GameObject? blueLine;

    internal MenuEnvironmentManager(PluginConfig pluginConfig)
    {
        this.pluginConfig = pluginConfig;
    }

    public void Initialize()
    {
        this.fogRing = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/MenuFogRing");
        this.ground = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/BasicMenuGround");
        this.notes = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/Notes");
        this.pileOfNotes = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/PileOfNotes");
        this.logo = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/Logo");
        this.redLine = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/GlowLines");
        this.blueLine = GameObject.Find("MenuEnvironmentManager/DefaultMenuEnvironment/GlowLines (1)");

        this.HideAll(this.pluginConfig.Enabled);
    }

    public void HideFogRing(bool shouldHide) => this.fogRing?.SetActive(!shouldHide);

    public void HideGround(bool shouldHide) => this.ground?.SetActive(!shouldHide);

    public void HideNotes(bool shouldHide) => this.notes?.SetActive(!shouldHide);

    public void HidePileOfNotes(bool shouldHide) => this.pileOfNotes?.SetActive(!shouldHide);

    public void HideLogo(bool shouldHide) => this.logo?.SetActive(!shouldHide);

    public void HideRedLine(bool shouldHide) => this.redLine?.SetActive(!shouldHide);

    public void HideBlueLine(bool shouldHide) => this.blueLine?.SetActive(!shouldHide);

    // This is so it doesn't get locked while editing the settings
    internal void HideAll(bool hideAll)
    {
        if (hideAll)
        {
            this.HideFogRing(this.pluginConfig.HideFogRing);
            this.HideGround(this.pluginConfig.HideMenuGround);
            this.HideNotes(this.pluginConfig.HideMenuNotes);
            this.HidePileOfNotes(this.pluginConfig.HideMenuPileOfNotes);
            this.HideLogo(this.pluginConfig.HideLogo);
            this.HideRedLine(this.pluginConfig.HideRedLine);
            this.HideBlueLine(this.pluginConfig.HideBlueLine);
        }
        else
        {
            this.HideFogRing(false);
            this.HideGround(false);
            this.HideNotes(false);
            this.HidePileOfNotes(false);
            this.HideLogo(false);
            this.HideRedLine(false);
            this.HideBlueLine(false);
        }
    }
}