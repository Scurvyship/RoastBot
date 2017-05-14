using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Objects;

namespace RoastBot.Modules
{
    internal class Triggerbot
    {
        /// <summary>
        /// Contains all FOVs.
        /// </summary>
        public List<Fov> Fovs { get; set; }

        private Fov MyFov;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Triggerbot()
        {
            // Initialize Fovs.
            Fovs = new List<Fov>
            {
                new Fov { Resolution = new Point(1920, 1080), FieldOfView = new Rectangle(960, 400, 1, 165) }
            };

            var gameScreen = Screen.AllScreens[SettingsManager.General.GameMonitor];

            MyFov = Fovs.FirstOrDefault(x => x.Resolution == new Point(gameScreen.Bounds.Width, gameScreen.Bounds.Height));

            // Run the aimbot.
            var thread = new Thread(Run);
            if (MyFov != null)
            {
                thread.Start();
            }
        }

        public void LoadModule()
        {
        }

        /// <summary>
        /// Main trigger thread.
        /// </summary>
        public void Run()
        {
            var lastKeyState = false;

            while (true)
            {
                if (MouseHelper.GetAsyncKeyState(SettingsManager.Triggerbot.AimKey) == -32767)
                {
                    if (lastKeyState == false)
                    {
                        lastKeyState = true;
                        SettingsManager.Triggerbot.IsToggled = !SettingsManager.Triggerbot.IsToggled;
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

                if (MouseHelper.GetAsyncKeyState(SettingsManager.Triggerbot.AimKey) < 0)
                {
                    // Get the screen capture.
                    var screenCapture = ScreenHelper.GetScreenCapture(MyFov.FieldOfView);

                    // Search for a target.
                    var coordinates = SearchHelper.SearchColor(ref screenCapture, SettingsManager.Triggerbot.TargetColor, 100);

                    if (coordinates.X != 0 || coordinates.Y != 0)
                    {
                        MouseHelper.Click();
                    }

                    // Destroy the bitmap.
                    screenCapture.Dispose();
                    screenCapture = null;
                }

                Thread.Sleep(10);
            }
        }

        private static bool ShouldRun()
        {
            if (!SettingsManager.Triggerbot.IsEnabled)
                return false;

            switch (SettingsManager.Triggerbot.AimMode)
            {
                case AimMode.HoldDown:
                    if (MouseHelper.GetAsyncKeyState(SettingsManager.Triggerbot.AimKey) >= 0)
                        return false;
                    break;
                case AimMode.Toggle:
                    if (!SettingsManager.Triggerbot.IsToggled)
                        return false;
                    break;
            }

            return true;
        }
    }
}
