namespace RoastBot.Objects
{
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
}
