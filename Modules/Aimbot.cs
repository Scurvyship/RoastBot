using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Objects;

namespace RoastBot.Modules
{
    internal class Aimbot
    {
        /// <summary>
        /// Contains all FOVs.
        /// </summary>
        public List<Fov> Fovs;

        private Fov MyFov;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Aimbot()
        {
            // Initialize Fovs.
            Fovs = new List<Fov>
            {
                new Fov { Resolution = new Point(1920, 1080), FieldOfView = new Rectangle(775, 410, 370, 185), RangeValues = new Point(45, 56), Tolerance = new Point(2, 2) },
                new Fov { Resolution = new Point(1280, 720), FieldOfView = new Rectangle(500, 300, 245, 120), RangeValues = new Point(30, 42), Tolerance = new Point(2, 2) }
            };

            var gameScreen = Screen.AllScreens[SettingsManager.General.GameMonitor];

            MyFov = Fovs.FirstOrDefault(x => x.Resolution == new Point(gameScreen.Bounds.Width, gameScreen.Bounds.Height));

            if (MyFov != null)
            {
                // Run the aimbot.
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
                if (MouseHelper.GetAsyncKeyState(SettingsManager.Aimbot.AimKey) < 0)
                {
                    if (lastKeyState == false)
                    {
                        lastKeyState = true;
                        SettingsManager.Aimbot.IsToggled = !SettingsManager.Aimbot.IsToggled;
                    }
                }
                else
                {
                    lastKeyState = false;
                }

                if (!ShouldRun())
                    continue;

                if (MouseHelper.GetAsyncKeyState(SettingsManager.Aimbot.AimKey) < 0)
                {
                    // Get the screen capture.
                    var screenCapture = ScreenHelper.GetScreenCapture(MyFov.FieldOfView);

                    // Search for a target.
                    var coordinates = SearchHelper.SearchColor(ref screenCapture, SettingsManager.Aimbot.TargetColor);

                    // Only continue if a healthbar was found.
                    if (coordinates.X != 0 || coordinates.Y != 0)
                    {
                        coordinates = ScreenHelper.GetAbsoluteCoordinates(coordinates, MyFov.FieldOfView);

                        MouseHelper.Move(ref MyFov, coordinates, SettingsManager.Aimbot.ForceHeadshot);
                    }

                    // Destroy the bitmap.
                    screenCapture.Dispose();
                    screenCapture = null;
                }

                Thread.Sleep(1);
            }
        }

        private bool ShouldRun()
        {
            if (!SettingsManager.Aimbot.IsEnabled)
                return false;

            switch (SettingsManager.Aimbot.AimMode)
            {
                case AimMode.Hold:
                    if (MouseHelper.GetAsyncKeyState(SettingsManager.Aimbot.AimKey) >= 0)
                        return false;
                    break;
                case AimMode.Toggle:
                    if (!SettingsManager.Aimbot.IsToggled)
                        return false;
                    break;
            }

            return true;
        }
    }
}
