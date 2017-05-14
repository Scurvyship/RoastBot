using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using RoastBot.Helpers;

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

        internal class AimbotSettings
        {
            public AimbotSettings()
            {
                IsEnabled = true;
                IsToggled = false;
                AimKey = 0x02;
                AntiShake = false;
                ForceHeadshot = false;
                TargetColor = Color.FromArgb(255, 0, 19);
                AimMode = AimMode.Toggle;
                DrawOverlay = true;
            }

            public bool IsEnabled { get; set; }

            public bool IsToggled { get; set; }

            public Color TargetColor { get; set; }

            public byte AimKey { get; set; }

            public bool ForceHeadshot { get; set; }

            public bool AntiShake { get; set; }

            public AimMode AimMode { get; set; }

            public bool DrawOverlay { get; set; }
        }

        internal class WidowbotSettings
        {
            public WidowbotSettings()
            {
                IsEnabled = true;
                IsToggled = false;
                AimKey = 0xA4;
                TargetColor = Color.FromArgb(215, 40, 35);
                AimMode = AimMode.Toggle;
                DrawOverlay = true;
            }

            public bool IsEnabled { get; set; }

            public int AimKey { get; set; }

            public Color TargetColor { get; set; }
            
            public AimMode AimMode { get; set; }

            public bool IsToggled { get; set; }

            public bool DrawOverlay { get; set; }
        }

        internal class AnabotSettings
        {
            public AnabotSettings()
            {
                AimKey = 0x05;
                IsEnabled = true;
                TargetColor = Color.FromArgb(202, 164, 63);
                AimMode = AimMode.Toggle;
                IsToggled = false;
                DrawOverlay = true;
            }

            public byte AimKey { get; set; }

            public bool IsEnabled { get; set; }

            public Color TargetColor { get; set; }

            public AimMode AimMode { get; set; }

            public bool IsToggled { get; set; }

            public bool DrawOverlay { get; set; }
        }

        internal class TriggerbotSettings
        {
            public TriggerbotSettings()
            {
                AimKey = 0xA4;
                IsEnabled = true;
                TargetColor = Color.FromArgb(254, 0, 0);
                AimMode = AimMode.Toggle;
                IsToggled = false;
                DrawOverlay = true;
            }

            public byte AimKey { get; set; }

            public bool IsEnabled { get; set; }

            public Color TargetColor { get; set; }

            public AimMode AimMode { get; set; }

            public bool IsToggled { get; set; }

            public bool DrawOverlay { get; set; }
        }

        internal class GeneralSettings
        {
            public GeneralSettings()
            {
                DrawOverlay = true;
                GameMonitor = 0;
                DrawModuleStatus = true;
            }

            public int GameMonitor { get; set; }

            public bool DrawOverlay { get; set; }

            public bool DrawModuleStatus { get; set; }
        }

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
            using (var file = File.CreateText(filePath))
            {
                serializer.Serialize(file, obj);
            }
        }
    }
}
