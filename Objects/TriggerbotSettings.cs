using System.Drawing;
using RoastBot.Helpers;

namespace RoastBot.Objects
{
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
            FieldOfView = new Fov();
        }

        public byte AimKey { get; set; }

        public bool IsEnabled { get; set; }

        public Color TargetColor { get; set; }

        public AimMode AimMode { get; set; }

        public bool IsToggled { get; set; }

        public bool DrawOverlay { get; set; }

        public Fov FieldOfView { get; set; }
    }
}
