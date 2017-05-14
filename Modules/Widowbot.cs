using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Objects;

namespace RoastBot.Modules
{
    internal class Widowbot
    {
        /// <summary>
        /// Contains all FOVs.
        /// </summary>
        public List<Fov> Fovs { get; set; }

        private Fov MyFov;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Widowbot()
        {
            // Initialize Fovs.
            Fovs = new List<Fov>
            {
                new Fov { Resolution = new Point(1920, 1200), FieldOfView = new Rectangle(880, 510, 160, 50), RangeValues = new Point(0, 28), Tolerance = new Point(2, 2) },
                new Fov { Resolution = new Point(1280, 720), FieldOfView = new Rectangle(580, 335, 120, 40), RangeValues = new Point(0, 18), Tolerance = new Point(2, 2) }
            };

            var gameScreen = Screen.AllScreens[SettingsManager.General.GameMonitor];

            MyFov = Fovs.FirstOrDefault(x => x.Resolution == new Point(gameScreen.Bounds.Width, gameScreen.Bounds.Height));

            if (MyFov != null)
            {
                // Run the aimbot.
                new Thread(Run).Start();
            }
        }

        /// <summary>
        /// Main aimbot thread.
        /// </summary>
        public void Run()
        {
            var lastKeyState = false;
            // Run the main routine.
            while (true)
            {
                if (MouseHelper.GetAsyncKeyState(SettingsManager.Widowbot.AimKey) < 0)
                {
                    if (lastKeyState == false)
                    {
                        lastKeyState = true;
                        SettingsManager.Widowbot.IsToggled = !SettingsManager.Widowbot.IsToggled;
                    }
                }
                else
                {
                    lastKeyState = false;
                }

                if (!IsRunning())
                {
                    continue;
                }
                // Get the screen capture.
                var screenCapture = ScreenHelper.GetScreenCapture(MyFov.FieldOfView);

                // Search for a target.
                var coordinates = SearchHelper.SearchColor(ref screenCapture, SettingsManager.Widowbot.TargetColor, 12);

                // Only continue if a healthbar was found.
                if (coordinates.X != 0 || coordinates.Y != 0)
                {
                    coordinates = ScreenHelper.GetAbsoluteCoordinates(coordinates, MyFov.FieldOfView);

                    MouseHelper.Move(ref MyFov, coordinates, true);
                }

                // Destroy the bitmap.
                screenCapture.Dispose();
                screenCapture = null;

                Thread.Sleep(1);
            }
        }

        private static bool IsRunning()
        {
            if (!SettingsManager.Widowbot.IsEnabled)
                return false;

            switch (SettingsManager.Widowbot.AimMode)
            {
                case AimMode.Hold:
                    if (MouseHelper.GetAsyncKeyState(SettingsManager.Widowbot.AimKey) >= 0)
                        return false;
                    break;
                case AimMode.Toggle:
                    if (!SettingsManager.Widowbot.IsToggled)
                        return false;
                    break;
            }

            return true;
        }
    }
}
