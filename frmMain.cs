using System;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Modules;

namespace RoastBot
{
    public partial class frmMain : Form
    {
        private Aimbot aimbot;
        private Anabot anabot;
        private Triggerbot triggerbot;
        private Widowbot widowbot;

        private FrmDrawing drawingForm;

        public frmMain()
        {
            InitializeComponent();

            SettingsManager.LoadSettingsFromDefaultPath();
            UpdateUserInterface();

            aimbot = new Aimbot(this);
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();

            drawingForm = new FrmDrawing();
        }

        private void UpdateUserInterface()
        {
            GrabScreenResolution();
            PopulateMonitorComboBox();
            UpdateModuleControls();
        }

        private void GrabScreenResolution()
        {
            var screen = Screen.AllScreens[SettingsManager.General.GameMonitor];
            lblResolution.Text = $@"Resolution: {screen.Bounds.Width} x {screen.Bounds.Height}";
        }

        private void PopulateMonitorComboBox()
        {
            cbMonitor.Items.Clear();
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                cbMonitor.Items.Add(i+1);
            }
            cbMonitor.SelectedIndex = SettingsManager.General.GameMonitor;
        }

        private void UpdateModuleControls()
        {
            cbAimEnable.Checked = SettingsManager.Aimbot.IsEnabled;
            cbAnaEnable.Checked = SettingsManager.Anabot.IsEnabled;
            cbTriggerEnable.Checked = SettingsManager.Triggerbot.IsEnabled;
            cbWidowEnable.Checked = SettingsManager.Widowbot.IsEnabled;

            nudAimKey.Value = SettingsManager.Aimbot.AimKey;
            cbAimMode.SelectedIndex = (int)SettingsManager.Aimbot.AimMode;

            nudAnaKey.Value = SettingsManager.Anabot.AimKey;
            cbAnaMode.SelectedIndex = (int)SettingsManager.Anabot.AimMode;

            nudTriggerKey.Value = SettingsManager.Triggerbot.AimKey;
            cbTriggerMode.SelectedIndex = (int)SettingsManager.Triggerbot.AimMode;

            nudWidowKey.Value = SettingsManager.Widowbot.AimKey;
            cbWidowMode.SelectedIndex = (int)SettingsManager.Widowbot.AimMode;

            cbDrawOver.Checked = SettingsManager.General.DrawOverlay;
            cbDrawAim.Checked = SettingsManager.Aimbot.DrawOverlay;
            cbDrawAna.Checked = SettingsManager.Anabot.DrawOverlay;
            cbDrawTrigger.Checked = SettingsManager.Triggerbot.DrawOverlay;
            cbDrawWidow.Checked = SettingsManager.Widowbot.DrawOverlay;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.SaveSettingsToFile();
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.LoadSettingsFromDefaultPath();
            UpdateModuleControls();
        }

        private void cbAimEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.IsEnabled = cbAimEnable.Checked;
            RedrawGUI();
        }

        private void cbAnaEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.IsEnabled = cbAnaEnable.Checked;
            RedrawGUI();
        }

        private void cbTriggerEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.IsEnabled = cbTriggerEnable.Checked;
            RedrawGUI();
        }

        private void cbWidowEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.IsEnabled = cbWidowEnable.Checked;
            RedrawGUI();
        }

        private void nudAimKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimKey = (byte)nudAimKey.Value;
        }

        private void cbAimMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimMode = (AimMode) cbAimMode.SelectedIndex;
            RedrawGUI();
        }

        private void nudAnaKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimKey = (byte) nudAnaKey.Value;
        }

        private void cbAnaMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimMode = (AimMode) cbAnaMode.SelectedIndex;
            RedrawGUI();
        }

        private void nudTriggerKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimKey = (byte) nudTriggerKey.Value;
        }

        private void cbTriggerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimMode = (AimMode) cbTriggerMode.SelectedIndex;
            RedrawGUI();
        }

        private void nudWidowKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimKey = (byte) nudWidowKey.Value;
        }

        private void cbWidowMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimMode = (AimMode) cbWidowMode.SelectedIndex;
            RedrawGUI();
        }

        private void cbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.General.GameMonitor = cbMonitor.SelectedIndex;
            GrabScreenResolution();
            aimbot = new Aimbot(this);
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();
        }

        private void frmMain_FormClosing(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public void RedrawGUI()
        {
            drawingForm?.Invalidate();
        }

        private void cbDrawOver_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.General.DrawOverlay = cbDrawOver.Checked;
            var isDrawingOverlay = SettingsManager.General.DrawOverlay;
            cbDrawAim.Enabled = isDrawingOverlay;
            cbDrawAna.Enabled = isDrawingOverlay;
            cbDrawTrigger.Enabled = isDrawingOverlay;
            cbDrawWidow.Enabled = isDrawingOverlay;
        }

        private void cbDrawAim_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.DrawOverlay = cbDrawAim.Checked;
        }

        private void cbDrawAna_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.DrawOverlay = cbDrawAna.Checked;
        }

        private void cbDrawTrigger_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.DrawOverlay = cbDrawTrigger.Checked;
        }

        private void cbDrawWidow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.DrawOverlay = cbDrawWidow.Checked;
        }
    }
}
