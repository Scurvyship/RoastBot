using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Objects;

namespace RoastBot.Modules
{
    internal class Anabot
    {
        /// <summary>
        /// Contains all FOVs.
        /// </summary>
        public List<Fov> Fovs { get; set; }

        private Fov MyFov;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Anabot()
        {
            // Initialize Fovs.
            Fovs = new List<Fov>
            {
                new Fov { Resolution = new Point(1920, 1080), FieldOfView = new Rectangle(830, 430, 275, 130), RangeValues = new Point(0, 25), Tolerance = new Point(2, 2) },
                new Fov { Resolution = new Point(1280, 720), FieldOfView = new Rectangle(550, 300, 180, 110), RangeValues = new Point(0, 25), Tolerance = new Point(2, 2) }
            };

            var gameScreen = Screen.AllScreens[SettingsManager.General.GameMonitor];

            MyFov = Fovs.FirstOrDefault(x => x.Resolution == new Point(gameScreen.Bounds.Width, gameScreen.Bounds.Height));

            if (MyFov != null)
            {
                var thread = new Thread(Run) { IsBackground = true };
                thread.Start();
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
                if (MouseHelper.GetAsyncKeyState(SettingsManager.Anabot.AimKey) < 0)
                {
                    if (lastKeyState == false)
                    {
                        lastKeyState = true;
                        SettingsManager.Anabot.IsToggled = !SettingsManager.Anabot.IsToggled;
                    }
                }
                else
                {
                    lastKeyState = false;
                }

                if (!ShouldRun())
                {
                    Thread.Sleep(100);
                    continue;
                }

                if (MouseHelper.GetAsyncKeyState(SettingsManager.Anabot.AimKey) < 0)
                {
                    // Get the screen capture.
                    var screenCapture = ScreenHelper.GetScreenCapture(MyFov.FieldOfView);

                    // Search for a target.
                    var coordinates = SearchHelper.SearchColor(ref screenCapture, SettingsManager.Anabot.TargetColor, 3);

                    // Only continue if a healthbar was found.
                    if (coordinates.X != 0 || coordinates.Y != 0)
                    {
                        coordinates = ScreenHelper.GetAbsoluteCoordinates(coordinates, MyFov.FieldOfView);

                        MouseHelper.Move(ref MyFov, coordinates);
                    }

                    // Destroy the bitmap.
                    screenCapture.Dispose();
                    screenCapture = null;
                }

                Thread.Sleep(1);
            }
        }

        private static bool ShouldRun()
        {
            if (!SettingsManager.Anabot.IsEnabled)
                return false;

            switch (SettingsManager.Anabot.AimMode)
            {
                case AimMode.Hold:
                    if (MouseHelper.GetAsyncKeyState(SettingsManager.Anabot.AimKey) >= 0)
                        return false;
                    break;
                case AimMode.Toggle:
                    if (!SettingsManager.Anabot.IsToggled)
                        return false;
                    break;
            }

            return true;
        }
    }
}
