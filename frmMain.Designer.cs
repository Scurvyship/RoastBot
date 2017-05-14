using System.Windows.Forms;

namespace RoastBot
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbAimMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAimKey = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAnaKey = new System.Windows.Forms.NumericUpDown();
            this.cbAnaMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tgGeneral = new System.Windows.Forms.TabPage();
            this.gbDrawing = new System.Windows.Forms.GroupBox();
            this.cbDrawWidow = new System.Windows.Forms.CheckBox();
            this.cbDrawTrigger = new System.Windows.Forms.CheckBox();
            this.cbDrawAna = new System.Windows.Forms.CheckBox();
            this.cbDrawAim = new System.Windows.Forms.CheckBox();
            this.cbDrawOver = new System.Windows.Forms.CheckBox();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbWidowEnable = new System.Windows.Forms.CheckBox();
            this.cbTriggerEnable = new System.Windows.Forms.CheckBox();
            this.cbAnaEnable = new System.Windows.Forms.CheckBox();
            this.cbAimEnable = new System.Windows.Forms.CheckBox();
            this.tpAim = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tpAna = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tpTrigger = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTriggerMode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudTriggerKey = new System.Windows.Forms.NumericUpDown();
            this.tpWidow = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWidowMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudWidowKey = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAimKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaKey)).BeginInit();
            this.tbMain.SuspendLayout();
            this.tgGeneral.SuspendLayout();
            this.gbDrawing.SuspendLayout();
            this.tpAim.SuspendLayout();
            this.tpAna.SuspendLayout();
            this.tpTrigger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerKey)).BeginInit();
            this.tpWidow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowKey)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAimMode
            // 
            this.cbAimMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAimMode.FormattingEnabled = true;
            this.cbAimMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbAimMode.Location = new System.Drawing.Point(66, 34);
            this.cbAimMode.Name = "cbAimMode";
            this.cbAimMode.Size = new System.Drawing.Size(105, 21);
            this.cbAimMode.TabIndex = 2;
            this.cbAimMode.SelectedIndexChanged += new System.EventHandler(this.cbAimMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aim Key";
            // 
            // nudAimKey
            // 
            this.nudAimKey.Location = new System.Drawing.Point(66, 6);
            this.nudAimKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudAimKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimKey.Name = "nudAimKey";
            this.nudAimKey.Size = new System.Drawing.Size(75, 20);
            this.nudAimKey.TabIndex = 4;
            this.nudAimKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAimKey.ValueChanged += new System.EventHandler(this.nudAimKey_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aim Mode";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(13, 9);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(114, 13);
            this.lblResolution.TabIndex = 1;
            this.lblResolution.Text = "Screen resolution label";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(16, 29);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(90, 25);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(112, 29);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(90, 25);
            this.btnLoadSettings.TabIndex = 9;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Aim Key";
            // 
            // nudAnaKey
            // 
            this.nudAnaKey.Location = new System.Drawing.Point(66, 6);
            this.nudAnaKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudAnaKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaKey.Name = "nudAnaKey";
            this.nudAnaKey.Size = new System.Drawing.Size(75, 20);
            this.nudAnaKey.TabIndex = 4;
            this.nudAnaKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnaKey.ValueChanged += new System.EventHandler(this.nudAnaKey_ValueChanged);
            // 
            // cbAnaMode
            // 
            this.cbAnaMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnaMode.FormattingEnabled = true;
            this.cbAnaMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbAnaMode.Location = new System.Drawing.Point(66, 34);
            this.cbAnaMode.Name = "cbAnaMode";
            this.cbAnaMode.Size = new System.Drawing.Size(105, 21);
            this.cbAnaMode.TabIndex = 2;
            this.cbAnaMode.SelectedIndexChanged += new System.EventHandler(this.cbAnaMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aim Mode";
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tgGeneral);
            this.tbMain.Controls.Add(this.tpAim);
            this.tbMain.Controls.Add(this.tpAna);
            this.tbMain.Controls.Add(this.tpTrigger);
            this.tbMain.Controls.Add(this.tpWidow);
            this.tbMain.Location = new System.Drawing.Point(12, 60);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(298, 252);
            this.tbMain.TabIndex = 11;
            // 
            // tgGeneral
            // 
            this.tgGeneral.Controls.Add(this.gbDrawing);
            this.tgGeneral.Controls.Add(this.cbMonitor);
            this.tgGeneral.Controls.Add(this.label13);
            this.tgGeneral.Controls.Add(this.cbWidowEnable);
            this.tgGeneral.Controls.Add(this.cbTriggerEnable);
            this.tgGeneral.Controls.Add(this.cbAnaEnable);
            this.tgGeneral.Controls.Add(this.cbAimEnable);
            this.tgGeneral.Location = new System.Drawing.Point(4, 22);
            this.tgGeneral.Name = "tgGeneral";
            this.tgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tgGeneral.Size = new System.Drawing.Size(290, 226);
            this.tgGeneral.TabIndex = 0;
            this.tgGeneral.Text = "General";
            this.tgGeneral.UseVisualStyleBackColor = true;
            // 
            // gbDrawing
            // 
            this.gbDrawing.Controls.Add(this.cbDrawWidow);
            this.gbDrawing.Controls.Add(this.cbDrawTrigger);
            this.gbDrawing.Controls.Add(this.cbDrawAna);
            this.gbDrawing.Controls.Add(this.cbDrawAim);
            this.gbDrawing.Controls.Add(this.cbDrawOver);
            this.gbDrawing.Location = new System.Drawing.Point(6, 56);
            this.gbDrawing.Name = "gbDrawing";
            this.gbDrawing.Size = new System.Drawing.Size(278, 164);
            this.gbDrawing.TabIndex = 14;
            this.gbDrawing.TabStop = false;
            this.gbDrawing.Text = "Overlay WIP";
            // 
            // cbDrawWidow
            // 
            this.cbDrawWidow.AutoSize = true;
            this.cbDrawWidow.Location = new System.Drawing.Point(16, 111);
            this.cbDrawWidow.Name = "cbDrawWidow";
            this.cbDrawWidow.Size = new System.Drawing.Size(102, 17);
            this.cbDrawWidow.TabIndex = 4;
            this.cbDrawWidow.Text = "Draw Widowbot";
            this.cbDrawWidow.UseVisualStyleBackColor = true;
            this.cbDrawWidow.CheckedChanged += new System.EventHandler(this.cbDrawWidow_CheckedChanged);
            // 
            // cbDrawTrigger
            // 
            this.cbDrawTrigger.AutoSize = true;
            this.cbDrawTrigger.Location = new System.Drawing.Point(16, 88);
            this.cbDrawTrigger.Name = "cbDrawTrigger";
            this.cbDrawTrigger.Size = new System.Drawing.Size(102, 17);
            this.cbDrawTrigger.TabIndex = 3;
            this.cbDrawTrigger.Text = "Draw Triggerbot";
            this.cbDrawTrigger.UseVisualStyleBackColor = true;
            this.cbDrawTrigger.CheckedChanged += new System.EventHandler(this.cbDrawTrigger_CheckedChanged);
            // 
            // cbDrawAna
            // 
            this.cbDrawAna.AutoSize = true;
            this.cbDrawAna.Location = new System.Drawing.Point(16, 65);
            this.cbDrawAna.Name = "cbDrawAna";
            this.cbDrawAna.Size = new System.Drawing.Size(88, 17);
            this.cbDrawAna.TabIndex = 2;
            this.cbDrawAna.Text = "Draw Anabot";
            this.cbDrawAna.UseVisualStyleBackColor = true;
            this.cbDrawAna.CheckedChanged += new System.EventHandler(this.cbDrawAna_CheckedChanged);
            // 
            // cbDrawAim
            // 
            this.cbDrawAim.AutoSize = true;
            this.cbDrawAim.Location = new System.Drawing.Point(16, 42);
            this.cbDrawAim.Name = "cbDrawAim";
            this.cbDrawAim.Size = new System.Drawing.Size(86, 17);
            this.cbDrawAim.TabIndex = 1;
            this.cbDrawAim.Text = "Draw Aimbot";
            this.cbDrawAim.UseVisualStyleBackColor = true;
            this.cbDrawAim.CheckedChanged += new System.EventHandler(this.cbDrawAim_CheckedChanged);
            // 
            // cbDrawOver
            // 
            this.cbDrawOver.AutoSize = true;
            this.cbDrawOver.Location = new System.Drawing.Point(6, 19);
            this.cbDrawOver.Name = "cbDrawOver";
            this.cbDrawOver.Size = new System.Drawing.Size(90, 17);
            this.cbDrawOver.TabIndex = 0;
            this.cbDrawOver.Text = "Draw Overlay";
            this.cbDrawOver.UseVisualStyleBackColor = true;
            this.cbDrawOver.CheckedChanged += new System.EventHandler(this.cbDrawOver_CheckedChanged);
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(83, 29);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(77, 21);
            this.cbMonitor.TabIndex = 13;
            this.cbMonitor.SelectedIndexChanged += new System.EventHandler(this.cbMonitor_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Game Monitor";
            // 
            // cbWidowEnable
            // 
            this.cbWidowEnable.AutoSize = true;
            this.cbWidowEnable.Location = new System.Drawing.Point(216, 6);
            this.cbWidowEnable.Name = "cbWidowEnable";
            this.cbWidowEnable.Size = new System.Drawing.Size(74, 17);
            this.cbWidowEnable.TabIndex = 11;
            this.cbWidowEnable.Text = "Widowbot";
            this.cbWidowEnable.UseVisualStyleBackColor = true;
            this.cbWidowEnable.CheckedChanged += new System.EventHandler(this.cbWidowEnable_CheckedChanged);
            // 
            // cbTriggerEnable
            // 
            this.cbTriggerEnable.AutoSize = true;
            this.cbTriggerEnable.Location = new System.Drawing.Point(136, 6);
            this.cbTriggerEnable.Name = "cbTriggerEnable";
            this.cbTriggerEnable.Size = new System.Drawing.Size(74, 17);
            this.cbTriggerEnable.TabIndex = 10;
            this.cbTriggerEnable.Text = "Triggerbot";
            this.cbTriggerEnable.UseVisualStyleBackColor = true;
            this.cbTriggerEnable.CheckedChanged += new System.EventHandler(this.cbTriggerEnable_CheckedChanged);
            // 
            // cbAnaEnable
            // 
            this.cbAnaEnable.AutoSize = true;
            this.cbAnaEnable.Location = new System.Drawing.Point(70, 6);
            this.cbAnaEnable.Name = "cbAnaEnable";
            this.cbAnaEnable.Size = new System.Drawing.Size(60, 17);
            this.cbAnaEnable.TabIndex = 9;
            this.cbAnaEnable.Text = "Anabot";
            this.cbAnaEnable.UseVisualStyleBackColor = true;
            this.cbAnaEnable.CheckedChanged += new System.EventHandler(this.cbAnaEnable_CheckedChanged);
            // 
            // cbAimEnable
            // 
            this.cbAimEnable.AutoSize = true;
            this.cbAimEnable.Location = new System.Drawing.Point(6, 6);
            this.cbAimEnable.Name = "cbAimEnable";
            this.cbAimEnable.Size = new System.Drawing.Size(58, 17);
            this.cbAimEnable.TabIndex = 8;
            this.cbAimEnable.Text = "Aimbot";
            this.cbAimEnable.UseVisualStyleBackColor = true;
            this.cbAimEnable.CheckedChanged += new System.EventHandler(this.cbAimEnable_CheckedChanged);
            // 
            // tpAim
            // 
            this.tpAim.Controls.Add(this.groupBox3);
            this.tpAim.Controls.Add(this.cbAimMode);
            this.tpAim.Controls.Add(this.label1);
            this.tpAim.Controls.Add(this.label2);
            this.tpAim.Controls.Add(this.nudAimKey);
            this.tpAim.Location = new System.Drawing.Point(4, 22);
            this.tpAim.Name = "tpAim";
            this.tpAim.Padding = new System.Windows.Forms.Padding(3);
            this.tpAim.Size = new System.Drawing.Size(290, 226);
            this.tpAim.TabIndex = 1;
            this.tpAim.Text = "Aimbot";
            this.tpAim.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 160);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FOV coming soon";
            // 
            // tpAna
            // 
            this.tpAna.Controls.Add(this.groupBox4);
            this.tpAna.Controls.Add(this.cbAnaMode);
            this.tpAna.Controls.Add(this.label5);
            this.tpAna.Controls.Add(this.label6);
            this.tpAna.Controls.Add(this.nudAnaKey);
            this.tpAna.Location = new System.Drawing.Point(4, 22);
            this.tpAna.Name = "tpAna";
            this.tpAna.Size = new System.Drawing.Size(290, 226);
            this.tpAna.TabIndex = 2;
            this.tpAna.Text = "Anabot";
            this.tpAna.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(6, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 160);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FOV coming soon";
            // 
            // tpTrigger
            // 
            this.tpTrigger.Controls.Add(this.groupBox5);
            this.tpTrigger.Controls.Add(this.cbTriggerMode);
            this.tpTrigger.Controls.Add(this.label15);
            this.tpTrigger.Controls.Add(this.label16);
            this.tpTrigger.Controls.Add(this.nudTriggerKey);
            this.tpTrigger.Location = new System.Drawing.Point(4, 22);
            this.tpTrigger.Name = "tpTrigger";
            this.tpTrigger.Size = new System.Drawing.Size(290, 226);
            this.tpTrigger.TabIndex = 3;
            this.tpTrigger.Text = "Triggerbot";
            this.tpTrigger.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(6, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 160);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FOV coming soon";
            // 
            // cbTriggerMode
            // 
            this.cbTriggerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTriggerMode.FormattingEnabled = true;
            this.cbTriggerMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbTriggerMode.Location = new System.Drawing.Point(66, 34);
            this.cbTriggerMode.Name = "cbTriggerMode";
            this.cbTriggerMode.Size = new System.Drawing.Size(105, 21);
            this.cbTriggerMode.TabIndex = 17;
            this.cbTriggerMode.SelectedIndexChanged += new System.EventHandler(this.cbTriggerMode_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Aim Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Aim Mode";
            // 
            // nudTriggerKey
            // 
            this.nudTriggerKey.Location = new System.Drawing.Point(66, 6);
            this.nudTriggerKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudTriggerKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerKey.Name = "nudTriggerKey";
            this.nudTriggerKey.Size = new System.Drawing.Size(75, 20);
            this.nudTriggerKey.TabIndex = 19;
            this.nudTriggerKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTriggerKey.ValueChanged += new System.EventHandler(this.nudTriggerKey_ValueChanged);
            // 
            // tpWidow
            // 
            this.tpWidow.Controls.Add(this.groupBox1);
            this.tpWidow.Controls.Add(this.cbWidowMode);
            this.tpWidow.Controls.Add(this.label8);
            this.tpWidow.Controls.Add(this.label9);
            this.tpWidow.Controls.Add(this.nudWidowKey);
            this.tpWidow.Location = new System.Drawing.Point(4, 22);
            this.tpWidow.Name = "tpWidow";
            this.tpWidow.Size = new System.Drawing.Size(290, 226);
            this.tpWidow.TabIndex = 4;
            this.tpWidow.Text = "Widowbot";
            this.tpWidow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 160);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOV coming soon";
            // 
            // cbWidowMode
            // 
            this.cbWidowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidowMode.FormattingEnabled = true;
            this.cbWidowMode.Items.AddRange(new object[] {
            "Always on",
            "Toggle",
            "HoldDown"});
            this.cbWidowMode.Location = new System.Drawing.Point(66, 34);
            this.cbWidowMode.Name = "cbWidowMode";
            this.cbWidowMode.Size = new System.Drawing.Size(105, 21);
            this.cbWidowMode.TabIndex = 23;
            this.cbWidowMode.SelectedIndexChanged += new System.EventHandler(this.cbWidowMode_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Aim Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Aim Mode";
            // 
            // nudWidowKey
            // 
            this.nudWidowKey.Location = new System.Drawing.Point(66, 6);
            this.nudWidowKey.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudWidowKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowKey.Name = "nudWidowKey";
            this.nudWidowKey.Size = new System.Drawing.Size(75, 20);
            this.nudWidowKey.TabIndex = 25;
            this.nudWidowKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidowKey.ValueChanged += new System.EventHandler(this.nudWidowKey_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(322, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Version 0.2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dropbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudAimKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnaKey)).EndInit();
            this.tbMain.ResumeLayout(false);
            this.tgGeneral.ResumeLayout(false);
            this.tgGeneral.PerformLayout();
            this.gbDrawing.ResumeLayout(false);
            this.gbDrawing.PerformLayout();
            this.tpAim.ResumeLayout(false);
            this.tpAim.PerformLayout();
            this.tpAna.ResumeLayout(false);
            this.tpAna.PerformLayout();
            this.tpTrigger.ResumeLayout(false);
            this.tpTrigger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriggerKey)).EndInit();
            this.tpWidow.ResumeLayout(false);
            this.tpWidow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidowKey)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAimKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAimMode;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAnaKey;
        private System.Windows.Forms.ComboBox cbAnaMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tgGeneral;
        private System.Windows.Forms.TabPage tpAim;
        private System.Windows.Forms.CheckBox cbTriggerEnable;
        private System.Windows.Forms.CheckBox cbAnaEnable;
        private System.Windows.Forms.CheckBox cbAimEnable;
        private System.Windows.Forms.TabPage tpAna;
        private System.Windows.Forms.TabPage tpTrigger;
        private System.Windows.Forms.CheckBox cbWidowEnable;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbDrawing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbTriggerMode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudTriggerKey;
        private System.Windows.Forms.TabPage tpWidow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbWidowMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudWidowKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private CheckBox cbDrawOver;
        private CheckBox cbDrawWidow;
        private CheckBox cbDrawTrigger;
        private CheckBox cbDrawAna;
        private CheckBox cbDrawAim;
    }
}

