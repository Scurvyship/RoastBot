using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Modules;

namespace RoastBot
{
    internal partial class FrmDrawing : Form
    {
        private Pen pen;
        private SolidBrush enabledBrush;
        private SolidBrush disabledBrush;
        private Font uiFont;

        public FrmDrawing()
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None; // no borders

            var screen = Screen.AllScreens[SettingsManager.General.GameMonitor];
            Size = new Size(screen.Bounds.Width, screen.Bounds.Height);

            Location = new Point(0, 0);

            TransparencyKey = BackColor = Color.Teal;

            pen = new Pen(Color.Aqua);
            enabledBrush = new SolidBrush(Color.LimeGreen);
            disabledBrush = new SolidBrush(Color.Red);
            uiFont = new Font("Arial", 16);

            // Extend aero glass style on form init
            OnResize(null);

            TopMost = true;
            Visible = true;

            // Run the aimbot.
            var thread = new Thread(Run) { IsBackground = true };
            thread.Start();
        }
        private void Run()
        {
            while (true)
            {
                Invalidate();
                Thread.Sleep(200);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                // Set the form click-through
                cp.ExStyle |= 0x80000 /* WS_EX_LAYERED */ | 0x20 /* WS_EX_TRANSPARENT */;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Teal);
            var x = 10;
            var y = 50;

            if (!SettingsManager.General.DrawOverlay) return;

            if(SettingsManager.Aimbot.DrawStatus)
                y = DrawAimbotGui(x, y, e);

            if(SettingsManager.Anabot.DrawStatus)
                y = DrawAnabotGui(x, y, e);

            if(SettingsManager.Triggerbot.DrawOverlay)
                y = DrawTriggerBotGui(x, y, e);

            if(SettingsManager.Widowbot.DrawOverlay)
                y = DrawWidowBotGui(x, y, e);
        }

        private int DrawAimbotGui(int x, int y, PaintEventArgs e)
        {
            var aimSettings = SettingsManager.Aimbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Aimbot Enabled: {aimSettings.IsEnabled}", uiFont, GetBrush(aimSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {aimSettings.AimMode}", uiFont, GetBrush(aimSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            switch (aimSettings.AimMode)
            {
                case AimMode.Toggle:
                    e.Graphics.DrawString($"Toggled: {aimSettings.IsToggled}", uiFont, GetBrush(aimSettings.IsToggled), x, postDrawY);
                    postDrawY += 20;
                    break;
                case AimMode.HoldDown:
                    var heldCondition = MouseHelper.GetAsyncKeyState(aimSettings.AimKey) < 0;
                    e.Graphics.DrawString($"Held: {heldCondition}", uiFont, GetBrush(heldCondition), x, postDrawY);
                    postDrawY += 20;
                    break;
            }
            postDrawY += 20;
            return postDrawY;
        }

        private int DrawAnabotGui(int x, int y, PaintEventArgs e)
        {
            var anaSettings = SettingsManager.Anabot;
            var postDrawY = y;
            e.Graphics.DrawString($"Anabot Enabled: {anaSettings.IsEnabled}", uiFont, GetBrush(anaSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {anaSettings.AimMode}", uiFont, GetBrush(anaSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            switch (anaSettings.AimMode)
            {
                case AimMode.Toggle:
                    e.Graphics.DrawString($"Toggled: {anaSettings.IsToggled}", uiFont, GetBrush(anaSettings.IsToggled), x, postDrawY);
                    postDrawY += 20;
                    break;
                case AimMode.HoldDown:
                    var heldCondition = MouseHelper.GetAsyncKeyState(anaSettings.AimKey) < 0;
                    e.Graphics.DrawString($"Held: {heldCondition}", uiFont, GetBrush(heldCondition), x, postDrawY);
                    postDrawY += 20;
                    break;
            }
            postDrawY += 20;
            return postDrawY;
        }

        private int DrawTriggerBotGui(int x, int y, PaintEventArgs e)
        {
            var triggerSettings = SettingsManager.Triggerbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Triggerbot Enabled: {triggerSettings.IsEnabled}", uiFont, GetBrush(triggerSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {triggerSettings.AimMode}", uiFont, GetBrush(triggerSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            switch (triggerSettings.AimMode)
            {
                case AimMode.Toggle:
                    e.Graphics.DrawString($"Toggled: {triggerSettings.IsToggled}", uiFont, GetBrush(triggerSettings.IsToggled), x, postDrawY);
                    postDrawY += 20;
                    break;
                case AimMode.HoldDown:
                    var heldCondition = MouseHelper.GetAsyncKeyState(triggerSettings.AimKey) < 0;
                    e.Graphics.DrawString($"Held: {heldCondition}", uiFont, GetBrush(heldCondition), x, postDrawY);
                    postDrawY += 20;
                    break;
            }
            postDrawY += 20;
            return postDrawY;
        }

        private int DrawWidowBotGui(int x, int y, PaintEventArgs e)
        {
            var widowSettings = SettingsManager.Widowbot;
            var postDrawY = y;
            e.Graphics.DrawString($"Widowbot Enabled: {widowSettings.IsEnabled}", uiFont, GetBrush(widowSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            e.Graphics.DrawString($"Aim Mode: {widowSettings.AimMode}", uiFont, GetBrush(widowSettings.IsEnabled), x, postDrawY);
            postDrawY += 20;
            switch (widowSettings.AimMode)
            {
                case AimMode.Toggle:
                    e.Graphics.DrawString($"Toggled: {widowSettings.IsToggled}", uiFont, GetBrush(widowSettings.IsToggled), x, postDrawY);
                    postDrawY += 20;
                    break;
                case AimMode.HoldDown:
                    var heldCondition = MouseHelper.GetAsyncKeyState(widowSettings.AimKey) < 0;
                    e.Graphics.DrawString($"Held: {heldCondition}", uiFont, GetBrush(heldCondition), x, postDrawY);
                    postDrawY += 20;
                    break;
            }
            return postDrawY;
        }

        private SolidBrush GetBrush(bool condition)
        {
            return condition ? enabledBrush : disabledBrush;
        }
    }
}