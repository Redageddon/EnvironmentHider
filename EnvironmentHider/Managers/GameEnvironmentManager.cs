using EnvironmentHider.Settings;
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
        Environment environment = this.pluginConfig.Environments.First(e => e.Name.Contains(activeEnvironmentName));

        environment.Static.ForEach(environmentObject => environmentObject.SetActive());
        environment.Dynamic.ForEach(environmentObject => environmentObject.SetActive());
        environment.Lights.ForEach(environmentObject => environmentObject.SetActive());
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