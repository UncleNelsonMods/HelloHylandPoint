using MelonLoader;
using MelonLoader.Utils;
using System.IO;
using System.Text.Json;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: MelonInfo(typeof(HelloHylandPoint.HelloHylandPoint), "HelloHylandPoint", "1.0.0", "John")]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace HelloHylandPoint
{
    public class HelloHylandPoint : MelonMod
    {
        private ModConfig config;
        
        public override void OnInitializeMelon()
        {
            LoadConfig();
            MelonLogger.Msg($"Hello Hyland Point Mod Initialized");
            MelonLogger.Msg(config.WelcomeMessage);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg($"Scene loaded: {sceneName} (Index: {buildIndex})");
        }

        private void LoadConfig()
        {
            string configPath = Path.Combine(MelonEnvironment.ModsDirectory, "HelloHylandPoint.json");
            
            // Create default config if it doesn't exist
            if (!File.Exists(configPath))
            {
                config = new ModConfig
                {
                    WelcomeMessage = "Hello from Hyland Point!"
                };
                SaveConfig(configPath);
            }
            else
            {
                string json = File.ReadAllText(configPath);
                config = JsonSerializer.Deserialize<ModConfig>(json);
            }
        }

        private void SaveConfig(string path)
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }

    public class ModConfig
    {
        public string WelcomeMessage { get; set; }
    }
} 