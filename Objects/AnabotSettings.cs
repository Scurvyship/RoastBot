using System.Drawing;
using RoastBot.Helpers;

namespace RoastBot.Objects
{
    internal class AnabotSettings
    {
        public AnabotSettings()
        {
            AimKey = 0x05;
            IsEnabled = true;
            TargetColor = Color.FromArgb(202, 164, 63);
            AimMode = AimMode.Toggle;
            IsToggled = false;
            DrawStatus = true;
            DrawFov = false;
            FieldOfView = new Fov();
        }

        public byte AimKey { get; set; }

        public bool IsEnabled { get; set; }

        public Color TargetColor { get; set; }

        public AimMode AimMode { get; set; }

        public bool IsToggled { get; set; }

        public bool DrawStatus { get; set; }

        public bool DrawFov { get; set; }

        public Fov FieldOfView { get; set; }
    }
}
