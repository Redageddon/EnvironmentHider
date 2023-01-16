using EnvironmentHider.Environments;
using Environment = EnvironmentHider.Environments.Environment;

namespace EnvironmentHider.Settings.UI.Controllers;

public class OptionsScreenViewController : BSMLResourceViewController
{
    private const int DefaultEnvironmentIndex = 4;
    private PluginConfig pluginConfig = null!;
    private Managers.MenuEnvironmentManager menuEnvironmentManager = null!;
    private Environment selectedEnvironment = null!;

    public override string ResourceName => "EnvironmentHider.Settings.UI.Views.OptionsScreenMenu.bsml";

    [Inject]
    public void Setup(PluginConfig pluginConfig, Managers.MenuEnvironmentManager menuEnvironmentManager)
    {
        this.pluginConfig = pluginConfig;
        this.menuEnvironmentManager = menuEnvironmentManager;
        this.selectedEnvironment = this.pluginConfig.Environments[DefaultEnvironmentIndex]; // have to do this so no nre
    }

    [UIComponent(nameof(environmentsDropDownListSetting))] private readonly DropDownListSetting environmentsDropDownListSetting = null!;

    [UIComponent(nameof(staticToggles))] private readonly CustomCellListTableData staticToggles = null!;

    [UIComponent(nameof(dynamicToggles))] private readonly CustomCellListTableData dynamicToggles = null!;

    [UIComponent(nameof(lightToggles))] private readonly CustomCellListTableData lightToggles = null!;

    [UIValue(nameof(Enabled))]
    public bool Enabled
    {
        get => this.pluginConfig.Enabled;
        set
        {
            this.pluginConfig.Enabled = value;
            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(FogRingHidden))]
    public bool FogRingHidden
    {
        get => this.pluginConfig.HideFogRing;
        set
        {
            this.pluginConfig.HideFogRing = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideFogRing(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(MenuGroundHidden))]
    public bool MenuGroundHidden
    {
        get => this.pluginConfig.HideMenuGround;
        set
        {
            this.pluginConfig.HideMenuGround = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideGround(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(MenuNotesHidden))]
    public bool MenuNotesHidden
    {
        get => this.pluginConfig.HideMenuNotes;
        set
        {
            this.pluginConfig.HideMenuNotes = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideNotes(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(MenuPileOfNotesHidden))]
    public bool MenuPileOfNotesHidden
    {
        get => this.pluginConfig.HideMenuPileOfNotes;
        set
        {
            this.pluginConfig.HideMenuPileOfNotes = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HidePileOfNotes(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(LogoHidden))]
    public bool LogoHidden
    {
        get => this.pluginConfig.HideLogo;
        set
        {
            this.pluginConfig.HideLogo = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideLogo(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(RedLineHidden))]
    public bool RedLineHidden
    {
        get => this.pluginConfig.HideRedLine;
        set
        {
            this.pluginConfig.HideRedLine = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideRedLine(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(BlueLineHidden))]
    public bool BlueLineHidden
    {
        get => this.pluginConfig.HideBlueLine;
        set
        {
            this.pluginConfig.HideBlueLine = value;

            if (this.pluginConfig.Enabled)
            {
                this.menuEnvironmentManager.HideBlueLine(value);
            }

            this.NotifyPropertyChanged();
        }
    }

    [UIValue(nameof(EnvironmentEnabled))]
    public bool EnvironmentEnabled
    {
        get => this.selectedEnvironment.Enabled;
        set
        {
            this.selectedEnvironment.Enabled = value;
            this.NotifyPropertyChanged();
        }
    }

    [UIValue("_")] private List<object> _ = new(); // only needed so it doesn't throw

    [UIAction("#post-parse")]
    public void SetupList()
    {
        RefreshDropdown(this.environmentsDropDownListSetting, this.pluginConfig.Environments);
        RefreshTable(this.staticToggles, this.selectedEnvironment.Static);
        RefreshTable(this.dynamicToggles, this.selectedEnvironment.Dynamic);
        RefreshTable(this.lightToggles, this.selectedEnvironment.Lights);
    }

    [UIAction(nameof(EnvironmentSelected))]
    private void EnvironmentSelected(string environmentName)
    {
        this.selectedEnvironment = this.pluginConfig.Environments.Find(environment => environment.Name.Contains(environmentName));
        this.EnvironmentEnabled = this.selectedEnvironment.Enabled;

        RefreshTable(this.staticToggles, this.selectedEnvironment.Static);
        RefreshTable(this.dynamicToggles, this.selectedEnvironment.Dynamic);
        RefreshTable(this.lightToggles, this.selectedEnvironment.Lights);
    }

    private static void RefreshDropdown(DropDownListSetting dropDownListSetting, IEnumerable<Environment> environments)
    {
        dropDownListSetting.values.Clear();
        dropDownListSetting.values.AddRange(environments.Select(environment => environment.Name.Replace("Environment", string.Empty)));
        dropDownListSetting.UpdateChoices();
        dropDownListSetting.dropdown.SelectCellWithIdx(DefaultEnvironmentIndex);
    }

    private static void RefreshTable(CustomCellListTableData customCellListTableData, IEnumerable<EnvironmentObject> environmentObjects)
    {
        customCellListTableData.data.Clear();
        customCellListTableData.data.AddRange(environmentObjects);
        customCellListTableData.tableView.ReloadData();
    }
}