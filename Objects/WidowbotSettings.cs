using System.Drawing;
using RoastBot.Helpers;

namespace RoastBot.Objects
{
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
            FieldOfView = new Fov();
        }

        public bool IsEnabled { get; set; }

        public int AimKey { get; set; }

        public Color TargetColor { get; set; }
            
        public AimMode AimMode { get; set; }

        public bool IsToggled { get; set; }

        public bool DrawOverlay { get; set; }

        public Fov FieldOfView { get; set; }
    }
}
