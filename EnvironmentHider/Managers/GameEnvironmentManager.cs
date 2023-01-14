using System.Linq;
using EnvironmentHider.Settings;
using UnityEngine.SceneManagement;
using Environment = EnvironmentHider.Environments.Environment;

namespace EnvironmentHider.Managers;

public class GameEnvironmentManager : IInitializable
{
    private readonly PluginConfig pluginConfig;

    internal GameEnvironmentManager(PluginConfig pluginConfig)
    {
        this.pluginConfig = pluginConfig;
    }

    public void Initialize()
    {
        string activeEnvironmentName = GetEnvironmentSceneName();
        Logger.Log.Info(activeEnvironmentName);
        Environment environment = this.pluginConfig.Environments.First(e => e.Name.Contains(activeEnvironmentName));

        environment.Static.ForEach(environmentObject => environmentObject.GameObject?.SetActive(environmentObject.Enabled));
        environment.Dynamic.ForEach(environmentObject => environmentObject.GameObject?.SetActive(environmentObject.Enabled));
        environment.Lights.ForEach(environmentObject => environmentObject.GameObject?.SetActive(environmentObject.Enabled));
    }

    private static string GetEnvironmentSceneName()
    {
        for (int index = 0; index < SceneManager.sceneCount; ++index)
        {
            Scene scene = SceneManager.GetSceneAt(index);
            string sceneName = scene.name;

            if (sceneName.Contains("Environment"))
            {
                return sceneName;
            }
        }

        return string.Empty;
    }
}