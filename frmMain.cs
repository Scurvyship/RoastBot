using System;
using System.Windows.Forms;
using RoastBot.Helpers;
using RoastBot.Modules;

namespace RoastBot
{
    public partial class FrmMain : Form
    {
        private Aimbot aimbot;
        private Anabot anabot;
        private Triggerbot triggerbot;
        private Widowbot widowbot;

        private FrmDrawing drawingForm;

        public FrmMain()
        {
            InitializeComponent();

            SettingsManager.LoadSettingsFromDefaultPath();
            UpdateUserInterface();

            aimbot = new Aimbot();
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();
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
            cbAimStatus.Checked = SettingsManager.Aimbot.DrawStatus;
            cbAnabotStatus.Checked = SettingsManager.Anabot.DrawStatus;
            cbTriggerStatus.Checked = SettingsManager.Triggerbot.DrawOverlay;
            cbWidowStatus.Checked = SettingsManager.Widowbot.DrawOverlay;
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
        }

        private void cbAnaEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.IsEnabled = cbAnaEnable.Checked;

        }

        private void cbTriggerEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.IsEnabled = cbTriggerEnable.Checked;
        }

        private void cbWidowEnable_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.IsEnabled = cbWidowEnable.Checked;
        }

        private void nudAimKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimKey = (byte)nudAimKey.Value;
        }

        private void cbAimMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.AimMode = (AimMode) cbAimMode.SelectedIndex;
        }

        private void nudAnaKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimKey = (byte) nudAnaKey.Value;
        }

        private void cbAnaMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.AimMode = (AimMode) cbAnaMode.SelectedIndex;
        }

        private void nudTriggerKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimKey = (byte) nudTriggerKey.Value;
        }

        private void cbTriggerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.AimMode = (AimMode) cbTriggerMode.SelectedIndex;
        }

        private void nudWidowKey_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimKey = (byte) nudWidowKey.Value;
        }

        private void cbWidowMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.AimMode = (AimMode) cbWidowMode.SelectedIndex;
        }

        private void cbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsManager.General.GameMonitor = cbMonitor.SelectedIndex;
            GrabScreenResolution();
            aimbot = new Aimbot();
            anabot = new Anabot();
            triggerbot = new Triggerbot();
            widowbot = new Widowbot();
        }

        private void frmMain_FormClosing(object sender, EventArgs e)
        {
            drawingForm?.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void cbDrawOver_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.General.DrawOverlay = cbDrawOver.Checked;
            var isDrawingOverlay = SettingsManager.General.DrawOverlay;
            if (!isDrawingOverlay)
            {
                drawingForm?.Dispose();
                drawingForm?.Close();
            }
            else
            {
                drawingForm = new FrmDrawing();
            }
            cbAimStatus.Enabled = isDrawingOverlay;
            cbAimFov.Enabled = isDrawingOverlay;
            cbAnabotStatus.Enabled = isDrawingOverlay;
            cbAnaFov.Enabled = isDrawingOverlay;
            cbTriggerStatus.Enabled = isDrawingOverlay;
            cbTriggerFov.Enabled = isDrawingOverlay;
            cbWidowStatus.Enabled = isDrawingOverlay;
            cbWidowFov.Enabled = isDrawingOverlay;
        }

        private void cbDrawAim_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Aimbot.DrawStatus = cbAimStatus.Checked;
        }

        private void cbDrawAna_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Anabot.DrawStatus = cbAnabotStatus.Checked;
        }

        private void cbDrawTrigger_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Triggerbot.DrawOverlay = cbTriggerStatus.Checked;
        }

        private void cbDrawWidow_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Widowbot.DrawOverlay = cbWidowStatus.Checked;
        }
    }
}
