namespace ViPER4WindowsBin
{
    partial class metroFormVirt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(metroFormVirt));
            this.buttonBox_AudioSystemConfig = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.listView_Speaker = new MetroFramework.Controls.MetroListView();
            this.columnHeader_Speaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Angle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_MusicMode = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox_MovieMode = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox_Freestyle = new MetroFramework.Controls.MetroCheckBox();
            this.singleButton_OK = new MetroFramework.Controls.MetroButton();
            this.singleButton_Cancel = new MetroFramework.Controls.MetroButton();
            this.twoSelector_PrePostProcess = new ViPER4WindowsBin.UIControls.TwoSelector();
            this.hSlider_EnvRealizeDrySignal = new ViPER4WindowsBin.UIControls.HSlider();
            this.onOffSwitch_EnvRealize = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_PrePostProcess = new MetroFramework.Controls.MetroLabel();
            this.singleButton_ResetConfig = new MetroFramework.Controls.MetroButton();
            this.comboBox_EnvRealizePreset = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBox_AudioSystemConfig
            // 
            this.buttonBox_AudioSystemConfig.BackColor = System.Drawing.Color.Black;
            this.buttonBox_AudioSystemConfig.Location = new System.Drawing.Point(23, 63);
            this.buttonBox_AudioSystemConfig.Name = "buttonBox_AudioSystemConfig";
            this.buttonBox_AudioSystemConfig.Size = new System.Drawing.Size(108, 317);
            this.buttonBox_AudioSystemConfig.TabIndex = 3;
            this.buttonBox_AudioSystemConfig.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_AudioSystemConfig_ItemSelectedNotify);
            this.buttonBox_AudioSystemConfig.Load += new System.EventHandler(this.buttonBox_AudioSystemConfig_Load);
            // 
            // listView_Speaker
            // 
            this.listView_Speaker.BackColor = System.Drawing.Color.Black;
            this.listView_Speaker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Speaker,
            this.columnHeader_Angle});
            this.listView_Speaker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView_Speaker.ForeColor = System.Drawing.Color.White;
            this.listView_Speaker.FullRowSelect = true;
            this.listView_Speaker.Location = new System.Drawing.Point(137, 99);
            this.listView_Speaker.Name = "listView_Speaker";
            this.listView_Speaker.OwnerDraw = true;
            this.listView_Speaker.Size = new System.Drawing.Size(196, 175);
            this.listView_Speaker.TabIndex = 5;
            this.listView_Speaker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.listView_Speaker.UseCompatibleStateImageBehavior = false;
            this.listView_Speaker.UseSelectable = true;
            this.listView_Speaker.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Speaker
            // 
            this.columnHeader_Speaker.Text = "$VIRT_SPEAKER";
            this.columnHeader_Speaker.Width = 112;
            // 
            // columnHeader_Angle
            // 
            this.columnHeader_Angle.Text = "$VIRT_SPEAKER_ANGLE";
            this.columnHeader_Angle.Width = 75;
            // 
            // checkBox_MusicMode
            // 
            this.checkBox_MusicMode.AutoSize = true;
            this.checkBox_MusicMode.Location = new System.Drawing.Point(21, 33);
            this.checkBox_MusicMode.Name = "checkBox_MusicMode";
            this.checkBox_MusicMode.Size = new System.Drawing.Size(104, 15);
            this.checkBox_MusicMode.TabIndex = 6;
            this.checkBox_MusicMode.Text = "$MUSIC_MODE";
            this.checkBox_MusicMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_MusicMode.UseSelectable = true;
            // 
            // checkBox_MovieMode
            // 
            this.checkBox_MovieMode.AutoSize = true;
            this.checkBox_MovieMode.Location = new System.Drawing.Point(21, 54);
            this.checkBox_MovieMode.Name = "checkBox_MovieMode";
            this.checkBox_MovieMode.Size = new System.Drawing.Size(104, 15);
            this.checkBox_MovieMode.TabIndex = 6;
            this.checkBox_MovieMode.Text = "$MOVIE_MODE";
            this.checkBox_MovieMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_MovieMode.UseSelectable = true;
            // 
            // checkBox_Freestyle
            // 
            this.checkBox_Freestyle.AutoSize = true;
            this.checkBox_Freestyle.Location = new System.Drawing.Point(21, 75);
            this.checkBox_Freestyle.Name = "checkBox_Freestyle";
            this.checkBox_Freestyle.Size = new System.Drawing.Size(124, 15);
            this.checkBox_Freestyle.TabIndex = 6;
            this.checkBox_Freestyle.Text = "$FREESTYLE_MODE";
            this.checkBox_Freestyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkBox_Freestyle.UseSelectable = true;
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(23, 525);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(84, 22);
            this.singleButton_OK.TabIndex = 7;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.singleButton_OK.UseSelectable = true;
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(248, 525);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(85, 22);
            this.singleButton_Cancel.TabIndex = 7;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.singleButton_Cancel.UseSelectable = true;
            // 
            // twoSelector_PrePostProcess
            // 
            this.twoSelector_PrePostProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.twoSelector_PrePostProcess.CurrentObject = null;
            this.twoSelector_PrePostProcess.LeftObject = null;
            this.twoSelector_PrePostProcess.Location = new System.Drawing.Point(207, 94);
            this.twoSelector_PrePostProcess.Name = "twoSelector_PrePostProcess";
            this.twoSelector_PrePostProcess.RightObject = null;
            this.twoSelector_PrePostProcess.Selector = ViPER4WindowsBin.UIControls.TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            this.twoSelector_PrePostProcess.Size = new System.Drawing.Size(65, 24);
            this.twoSelector_PrePostProcess.TabIndex = 13;
            // 
            // hSlider_EnvRealizeDrySignal
            // 
            this.hSlider_EnvRealizeDrySignal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.hSlider_EnvRealizeDrySignal.Location = new System.Drawing.Point(99, 65);
            this.hSlider_EnvRealizeDrySignal.MoveDelta = ((uint)(1u));
            this.hSlider_EnvRealizeDrySignal.Name = "hSlider_EnvRealizeDrySignal";
            this.hSlider_EnvRealizeDrySignal.Position = ((uint)(0u));
            this.hSlider_EnvRealizeDrySignal.PositionFloat = 0F;
            this.hSlider_EnvRealizeDrySignal.Size = new System.Drawing.Size(206, 22);
            this.hSlider_EnvRealizeDrySignal.TabIndex = 11;
            // 
            // onOffSwitch_EnvRealize
            // 
            this.onOffSwitch_EnvRealize.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_EnvRealize.Location = new System.Drawing.Point(18, 62);
            this.onOffSwitch_EnvRealize.Name = "onOffSwitch_EnvRealize";
            this.onOffSwitch_EnvRealize.Size = new System.Drawing.Size(53, 27);
            this.onOffSwitch_EnvRealize.SwitchedOn = false;
            this.onOffSwitch_EnvRealize.TabIndex = 10;
            // 
            // label_PrePostProcess
            // 
            this.label_PrePostProcess.AutoSize = true;
            this.label_PrePostProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PrePostProcess.Location = new System.Drawing.Point(40, 96);
            this.label_PrePostProcess.Name = "label_PrePostProcess";
            this.label_PrePostProcess.Size = new System.Drawing.Size(141, 19);
            this.label_PrePostProcess.TabIndex = 4;
            this.label_PrePostProcess.Text = "$PRE_POST_PROCESS";
            this.label_PrePostProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // singleButton_ResetConfig
            // 
            this.singleButton_ResetConfig.Location = new System.Drawing.Point(137, 63);
            this.singleButton_ResetConfig.Name = "singleButton_ResetConfig";
            this.singleButton_ResetConfig.Size = new System.Drawing.Size(196, 29);
            this.singleButton_ResetConfig.TabIndex = 7;
            this.singleButton_ResetConfig.Text = "$VIRT_RESET";
            this.singleButton_ResetConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.singleButton_ResetConfig.UseSelectable = true;
            this.singleButton_ResetConfig.Click += new System.EventHandler(this.singleButton_ResetConfig_Click);
            // 
            // comboBox_EnvRealizePreset
            // 
            this.comboBox_EnvRealizePreset.FormattingEnabled = true;
            this.comboBox_EnvRealizePreset.ItemHeight = 23;
            this.comboBox_EnvRealizePreset.Location = new System.Drawing.Point(4, 27);
            this.comboBox_EnvRealizePreset.Name = "comboBox_EnvRealizePreset";
            this.comboBox_EnvRealizePreset.Size = new System.Drawing.Size(301, 29);
            this.comboBox_EnvRealizePreset.TabIndex = 14;
            this.comboBox_EnvRealizePreset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBox_EnvRealizePreset.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.checkBox_MovieMode);
            this.metroPanel1.Controls.Add(this.checkBox_MusicMode);
            this.metroPanel1.Controls.Add(this.checkBox_Freestyle);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(137, 280);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(196, 100);
            this.metroPanel1.TabIndex = 15;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(3, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "$VIRT_APPLIED";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.twoSelector_PrePostProcess);
            this.metroPanel2.Controls.Add(this.comboBox_EnvRealizePreset);
            this.metroPanel2.Controls.Add(this.hSlider_EnvRealizeDrySignal);
            this.metroPanel2.Controls.Add(this.onOffSwitch_EnvRealize);
            this.metroPanel2.Controls.Add(this.label_PrePostProcess);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 386);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(310, 126);
            this.metroPanel2.TabIndex = 16;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(3, 2);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "$VIRTUAL_ENVIRONMENT";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroFormVirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 563);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.singleButton_ResetConfig);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.listView_Speaker);
            this.Controls.Add(this.buttonBox_AudioSystemConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "metroFormVirt";
            this.Resizable = false;
            this.Text = "$VIRTUALIZATION";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UIControls.ButtonBox buttonBox_AudioSystemConfig;
        private MetroFramework.Controls.MetroListView listView_Speaker;
        private System.Windows.Forms.ColumnHeader columnHeader_Speaker;
        private System.Windows.Forms.ColumnHeader columnHeader_Angle;
        private MetroFramework.Controls.MetroCheckBox checkBox_MusicMode;
        private MetroFramework.Controls.MetroCheckBox checkBox_MovieMode;
        private MetroFramework.Controls.MetroCheckBox checkBox_Freestyle;
        private MetroFramework.Controls.MetroButton singleButton_OK;
        private MetroFramework.Controls.MetroButton singleButton_Cancel;
        private UIControls.TwoSelector twoSelector_PrePostProcess;
        private UIControls.HSlider hSlider_EnvRealizeDrySignal;
        private UIControls.OnOffSwitch onOffSwitch_EnvRealize;
        private MetroFramework.Controls.MetroLabel label_PrePostProcess;
        private MetroFramework.Controls.MetroButton singleButton_ResetConfig;
        private MetroFramework.Controls.MetroComboBox comboBox_EnvRealizePreset;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}