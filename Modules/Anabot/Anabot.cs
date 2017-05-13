﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Objects;
using static RoastBot.Helpers.PrettyLog;

namespace RoastBot.Modules.Anabot
{
    internal class Anabot : IModule
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

            MyFov = Fovs.FirstOrDefault(x => x.Resolution == new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));

            if (MyFov != null)
            {
                // Run the aimbot.
                new Thread(Run).Start();
                LogInfo("Anabot initialized");
            }
            else
            {
                LogError("Could not initialize Anabot as screen does not match available resolutions.\n" +
                         "This will be fixed later, for now make your screen resolution 1920x1080\nor 1280x720.");
            }
        }

        /// <summary>
        /// Main aimbot thread.
        /// </summary>
        public void Run()
        {
            // Run the main routine.
            while (true)
            {
                if (SettingsManager.Anabot.IsEnabled)
                {
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
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public void HandleCommand(IEnumerable<string> args)
        {
            LogWarning("Anabot currently has no command support.\n" +
                       $"To change its settings, go to {Environment.CurrentDirectory}\\anabot.json");
        }
    }
}
