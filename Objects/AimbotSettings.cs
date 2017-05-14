using System.Drawing;
using RoastBot.Helpers;

namespace RoastBot.Objects
{
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
            DrawStatus = true;
            DrawFov = false;
            FieldOfView = new Fov();
        }

        public bool IsEnabled { get; set; }

        public bool IsToggled { get; set; }

        public Color TargetColor { get; set; }

        public byte AimKey { get; set; }

        public bool ForceHeadshot { get; set; }

        public bool AntiShake { get; set; }

        public AimMode AimMode { get; set; }

        public bool DrawStatus { get; set; }

        public bool DrawFov { get; set; }

        public Fov FieldOfView { get; set; }
    }
}
