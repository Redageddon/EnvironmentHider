﻿using System.Linq;
using EnvironmentHider.Environments;
using Environment = EnvironmentHider.Environments.Environment;

namespace EnvironmentHider.Settings.UI.Controllers;

public class OptionsScreenViewController : BSMLResourceViewController
{
    private PluginConfig pluginConfig = null!;
    private Managers.MenuEnvironmentManager menuEnvironmentManager = null!;
    private Environment selectedEnvironment = null!;

    public override string ResourceName => "EnvironmentHider.Settings.UI.Views.OptionsScreenMenu.bsml";

    [Inject]
    public void Setup(PluginConfig pluginConfig, Managers.MenuEnvironmentManager menuEnvironmentManager)
    {
        this.pluginConfig = pluginConfig;
        this.menuEnvironmentManager = menuEnvironmentManager;
        this.selectedEnvironment = this.pluginConfig.Environments[0]; // have to do this so no nre
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
        this.selectedEnvironment = this.pluginConfig.Environments.Find(environment => environment.Name == environmentName);
        this.EnvironmentEnabled = this.selectedEnvironment.Enabled;

        RefreshTable(this.staticToggles, this.selectedEnvironment.Static);
        RefreshTable(this.dynamicToggles, this.selectedEnvironment.Dynamic);
        RefreshTable(this.lightToggles, this.selectedEnvironment.Lights);
    }

    private static void RefreshDropdown(DropDownListSetting dropDownListSetting, IEnumerable<Environment> environments)
    {
        dropDownListSetting.values.Clear();
        dropDownListSetting.values.AddRange(environments.Select(environment => environment.Name));
        dropDownListSetting.UpdateChoices();
        dropDownListSetting.dropdown.SelectCellWithIdx(0);
    }

    private static void RefreshTable(CustomCellListTableData customCellListTableData, IEnumerable<EnvironmentObject> environmentObjects)
    {
        customCellListTableData.data.Clear();
        customCellListTableData.data.AddRange(environmentObjects);
        customCellListTableData.tableView.ReloadData();
    }
}