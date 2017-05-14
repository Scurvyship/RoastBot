using System;
using System.IO;
using Newtonsoft.Json;

using RoastBot.Objects;

namespace RoastBot.Modules
{
    internal class SettingsManager
    {
        public static AimbotSettings Aimbot;
        public static AnabotSettings Anabot;
        public static WidowbotSettings Widowbot;
        public static TriggerbotSettings Triggerbot;
        public static GeneralSettings General;

        private const string SettingsFolderName = "settings";
        private static readonly string SettingsFolderFullPath = $"{Environment.CurrentDirectory}\\settings";

        public static void SaveSettingsToFile()
        {
            SerializeObjectToFile(Aimbot, $"{SettingsFolderName}\\aimbot.json");
            SerializeObjectToFile(Anabot, $"{SettingsFolderName}\\anabot.json");
            SerializeObjectToFile(Widowbot, $"{SettingsFolderName}\\widowbot.json");
            SerializeObjectToFile(Triggerbot, $"{SettingsFolderName}\\triggerbot.json");
            SerializeObjectToFile(General, $"{SettingsFolderName}\\general.json");
        }

        public static void LoadSettingsFromDefaultPath()
        {
            if (!Directory.Exists(SettingsFolderFullPath))
            {
                Directory.CreateDirectory(SettingsFolderFullPath);
            }

            Aimbot = ReadJsonFromFile<AimbotSettings>($"{SettingsFolderFullPath}\\aimbot.json");
            Anabot = ReadJsonFromFile<AnabotSettings>($"{SettingsFolderFullPath}\\anabot.json");
            Triggerbot = ReadJsonFromFile<TriggerbotSettings>($"{SettingsFolderFullPath}\\triggerbot.json");
            Widowbot = ReadJsonFromFile<WidowbotSettings>($"{SettingsFolderFullPath}\\widowbot.json");
            General = ReadJsonFromFile<GeneralSettings>($"{SettingsFolderFullPath}\\general.json");
            SaveSettingsToFile();
        }

        private static T ReadJsonFromFile<T>(string filePath) where T : new()
        {
            if (!File.Exists(filePath))
            {
                return new T();
            }
            using (var file = File.OpenText(filePath))
            {
                return JsonConvert.DeserializeObject<T>(file.ReadToEnd());
            }
        }

        private static void SerializeObjectToFile(object obj, string filePath)
        {
            var serializer = new JsonSerializer();

            using (var file = File.Create(filePath))
            using (var sw = new StreamWriter(file))
            using (var jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                serializer.Serialize(jw, obj);
            }
        }
    }
}
