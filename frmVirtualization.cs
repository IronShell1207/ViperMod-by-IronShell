// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmVirtualization
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;
using MetroFramework;

namespace ViPER4WindowsBin
{
    public class frmVirtualization  : Telerik.WinControls.UI.RadForm
    {
        private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramSystem = new RuntimeUtils.ConfigProxy._ParamOfBaseSystem();
        private int m_nCurrentAudioSystem = -1;
        private IContainer components;
        private Label label_AudioSystemConfig;
        private ButtonBox buttonBox_AudioSystemConfig;
        private GroupBox groupBox_VirtApplied;
        private CheckBox checkBox_MusicMode;
        private CheckBox checkBox_Freestyle;
        private CheckBox checkBox_MovieMode;
        private ListView listView_Speaker;
        private ColumnHeader columnHeader_Speaker;
        private ColumnHeader columnHeader_Angle;
        private SingleButton singleButton_ResetConfig;
        private GroupBox groupBox_VirtEnv;
        private OnOffSwitch onOffSwitch_EnvRealize;
        private ComboBox comboBox_EnvRealizePreset;
        private HSlider hSlider_EnvRealizeDrySignal;
        private Label label_PrePostProcess;
        private ContextMenuStrip contextMenuStrip_SpeakerAngle;
        private ToolStripMenuItem toolStripMenuItem_SpeakerAngle;
        private ToolStripSeparator toolStripSeparator_Angle;
        private ToolStripComboBox toolStripComboBox_SpeakerAngle;
        private Telerik.WinControls.UI.RadButton singleButton_OK;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;
        private TwoSelector twoSelector_PrePostProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVirtualization));
            this.label_AudioSystemConfig = new System.Windows.Forms.Label();
            this.groupBox_VirtApplied = new System.Windows.Forms.GroupBox();
            this.checkBox_Freestyle = new System.Windows.Forms.CheckBox();
            this.checkBox_MovieMode = new System.Windows.Forms.CheckBox();
            this.checkBox_MusicMode = new System.Windows.Forms.CheckBox();
            this.listView_Speaker = new System.Windows.Forms.ListView();
            this.columnHeader_Speaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Angle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_VirtEnv = new System.Windows.Forms.GroupBox();
            this.twoSelector_PrePostProcess = new ViPER4WindowsBin.UIControls.TwoSelector();
            this.label_PrePostProcess = new System.Windows.Forms.Label();
            this.hSlider_EnvRealizeDrySignal = new ViPER4WindowsBin.UIControls.HSlider();
            this.comboBox_EnvRealizePreset = new System.Windows.Forms.ComboBox();
            this.onOffSwitch_EnvRealize = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.contextMenuStrip_SpeakerAngle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_SpeakerAngle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_Angle = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox_SpeakerAngle = new System.Windows.Forms.ToolStripComboBox();
            this.singleButton_ResetConfig = new ViPER4WindowsBin.UIControls.SingleButton();
            this.buttonBox_AudioSystemConfig = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.singleButton_OK = new Telerik.WinControls.UI.RadButton();
            this.singleButton_Cancel = new Telerik.WinControls.UI.RadButton();
            this.groupBox_VirtApplied.SuspendLayout();
            this.groupBox_VirtEnv.SuspendLayout();
            this.contextMenuStrip_SpeakerAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AudioSystemConfig
            // 
            this.label_AudioSystemConfig.AutoSize = true;
            this.label_AudioSystemConfig.Location = new System.Drawing.Point(12, 18);
            this.label_AudioSystemConfig.Name = "label_AudioSystemConfig";
            this.label_AudioSystemConfig.Size = new System.Drawing.Size(138, 13);
            this.label_AudioSystemConfig.TabIndex = 0;
            this.label_AudioSystemConfig.Text = "$AUDIO_SYSTEM_CONFIG";
            // 
            // groupBox_VirtApplied
            // 
            this.groupBox_VirtApplied.Controls.Add(this.checkBox_Freestyle);
            this.groupBox_VirtApplied.Controls.Add(this.checkBox_MovieMode);
            this.groupBox_VirtApplied.Controls.Add(this.checkBox_MusicMode);
            this.groupBox_VirtApplied.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_VirtApplied.Location = new System.Drawing.Point(151, 316);
            this.groupBox_VirtApplied.Name = "groupBox_VirtApplied";
            this.groupBox_VirtApplied.Size = new System.Drawing.Size(167, 95);
            this.groupBox_VirtApplied.TabIndex = 2;
            this.groupBox_VirtApplied.TabStop = false;
            this.groupBox_VirtApplied.Text = "$VIRT_APPLIED";
            // 
            // checkBox_Freestyle
            // 
            this.checkBox_Freestyle.AutoSize = true;
            this.checkBox_Freestyle.Location = new System.Drawing.Point(16, 69);
            this.checkBox_Freestyle.Name = "checkBox_Freestyle";
            this.checkBox_Freestyle.Size = new System.Drawing.Size(123, 17);
            this.checkBox_Freestyle.TabIndex = 5;
            this.checkBox_Freestyle.Text = "$FREESTYLE_MODE";
            this.checkBox_Freestyle.UseVisualStyleBackColor = true;
            // 
            // checkBox_MovieMode
            // 
            this.checkBox_MovieMode.AutoSize = true;
            this.checkBox_MovieMode.Location = new System.Drawing.Point(16, 46);
            this.checkBox_MovieMode.Name = "checkBox_MovieMode";
            this.checkBox_MovieMode.Size = new System.Drawing.Size(105, 17);
            this.checkBox_MovieMode.TabIndex = 4;
            this.checkBox_MovieMode.Text = "$MOVIE_MODE";
            this.checkBox_MovieMode.UseVisualStyleBackColor = true;
            // 
            // checkBox_MusicMode
            // 
            this.checkBox_MusicMode.AutoSize = true;
            this.checkBox_MusicMode.Location = new System.Drawing.Point(16, 22);
            this.checkBox_MusicMode.Name = "checkBox_MusicMode";
            this.checkBox_MusicMode.Size = new System.Drawing.Size(104, 17);
            this.checkBox_MusicMode.TabIndex = 3;
            this.checkBox_MusicMode.Text = "$MUSIC_MODE";
            this.checkBox_MusicMode.UseVisualStyleBackColor = true;
            // 
            // listView_Speaker
            // 
            this.listView_Speaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listView_Speaker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Speaker,
            this.columnHeader_Angle});
            this.listView_Speaker.FullRowSelect = true;
            this.listView_Speaker.GridLines = true;
            this.listView_Speaker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Speaker.HideSelection = false;
            this.listView_Speaker.Location = new System.Drawing.Point(151, 77);
            this.listView_Speaker.MultiSelect = false;
            this.listView_Speaker.Name = "listView_Speaker";
            this.listView_Speaker.Size = new System.Drawing.Size(167, 233);
            this.listView_Speaker.TabIndex = 3;
            this.listView_Speaker.UseCompatibleStateImageBehavior = false;
            this.listView_Speaker.View = System.Windows.Forms.View.Details;
            this.listView_Speaker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_Speaker_MouseUp);
            // 
            // columnHeader_Speaker
            // 
            this.columnHeader_Speaker.Text = "$VIRT_SPEAKER";
            this.columnHeader_Speaker.Width = 95;
            // 
            // columnHeader_Angle
            // 
            this.columnHeader_Angle.Text = "$VIRT_SPEAKER_ANGLE";
            // 
            // groupBox_VirtEnv
            // 
            this.groupBox_VirtEnv.Controls.Add(this.twoSelector_PrePostProcess);
            this.groupBox_VirtEnv.Controls.Add(this.label_PrePostProcess);
            this.groupBox_VirtEnv.Controls.Add(this.hSlider_EnvRealizeDrySignal);
            this.groupBox_VirtEnv.Controls.Add(this.comboBox_EnvRealizePreset);
            this.groupBox_VirtEnv.Controls.Add(this.onOffSwitch_EnvRealize);
            this.groupBox_VirtEnv.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_VirtEnv.Location = new System.Drawing.Point(324, 39);
            this.groupBox_VirtEnv.Name = "groupBox_VirtEnv";
            this.groupBox_VirtEnv.Size = new System.Drawing.Size(222, 115);
            this.groupBox_VirtEnv.TabIndex = 5;
            this.groupBox_VirtEnv.TabStop = false;
            this.groupBox_VirtEnv.Text = "$VIRTUAL_ENVIRONMENT";
            // 
            // twoSelector_PrePostProcess
            // 
            this.twoSelector_PrePostProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.twoSelector_PrePostProcess.CurrentObject = null;
            this.twoSelector_PrePostProcess.LeftObject = null;
            this.twoSelector_PrePostProcess.Location = new System.Drawing.Point(146, 80);
            this.twoSelector_PrePostProcess.Name = "twoSelector_PrePostProcess";
            this.twoSelector_PrePostProcess.RightObject = null;
            this.twoSelector_PrePostProcess.Selector = ViPER4WindowsBin.UIControls.TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            this.twoSelector_PrePostProcess.Size = new System.Drawing.Size(70, 24);
            this.twoSelector_PrePostProcess.TabIndex = 9;
            // 
            // label_PrePostProcess
            // 
            this.label_PrePostProcess.AutoSize = true;
            this.label_PrePostProcess.Location = new System.Drawing.Point(6, 86);
            this.label_PrePostProcess.Name = "label_PrePostProcess";
            this.label_PrePostProcess.Size = new System.Drawing.Size(116, 13);
            this.label_PrePostProcess.TabIndex = 3;
            this.label_PrePostProcess.Text = "$PRE_POST_PROCESS";
            // 
            // hSlider_EnvRealizeDrySignal
            // 
            this.hSlider_EnvRealizeDrySignal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_EnvRealizeDrySignal.Location = new System.Drawing.Point(68, 52);
            this.hSlider_EnvRealizeDrySignal.MoveDelta = ((uint)(1u));
            this.hSlider_EnvRealizeDrySignal.Name = "hSlider_EnvRealizeDrySignal";
            this.hSlider_EnvRealizeDrySignal.Position = ((uint)(0u));
            this.hSlider_EnvRealizeDrySignal.PositionFloat = 0F;
            this.hSlider_EnvRealizeDrySignal.Size = new System.Drawing.Size(148, 22);
            this.hSlider_EnvRealizeDrySignal.TabIndex = 2;
            // 
            // comboBox_EnvRealizePreset
            // 
            this.comboBox_EnvRealizePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboBox_EnvRealizePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EnvRealizePreset.FormattingEnabled = true;
            this.comboBox_EnvRealizePreset.Location = new System.Drawing.Point(6, 22);
            this.comboBox_EnvRealizePreset.Name = "comboBox_EnvRealizePreset";
            this.comboBox_EnvRealizePreset.Size = new System.Drawing.Size(210, 21);
            this.comboBox_EnvRealizePreset.TabIndex = 1;
            // 
            // onOffSwitch_EnvRealize
            // 
            this.onOffSwitch_EnvRealize.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_EnvRealize.Location = new System.Drawing.Point(6, 50);
            this.onOffSwitch_EnvRealize.Name = "onOffSwitch_EnvRealize";
            this.onOffSwitch_EnvRealize.Size = new System.Drawing.Size(53, 24);
            this.onOffSwitch_EnvRealize.SwitchedOn = false;
            this.onOffSwitch_EnvRealize.TabIndex = 0;
            // 
            // contextMenuStrip_SpeakerAngle
            // 
            this.contextMenuStrip_SpeakerAngle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SpeakerAngle,
            this.toolStripSeparator_Angle,
            this.toolStripComboBox_SpeakerAngle});
            this.contextMenuStrip_SpeakerAngle.Name = "contextMenuStrip_SpeakerAngle";
            this.contextMenuStrip_SpeakerAngle.Size = new System.Drawing.Size(182, 59);
            this.contextMenuStrip_SpeakerAngle.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip_SpeakerAngle_Closed);
            // 
            // toolStripMenuItem_SpeakerAngle
            // 
            this.toolStripMenuItem_SpeakerAngle.Enabled = false;
            this.toolStripMenuItem_SpeakerAngle.Name = "toolStripMenuItem_SpeakerAngle";
            this.toolStripMenuItem_SpeakerAngle.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_SpeakerAngle.Text = "$SPEAKER_ANGLE";
            this.toolStripMenuItem_SpeakerAngle.Click += new System.EventHandler(this.toolStripMenuItem_SpeakerAngle_Click);
            // 
            // toolStripSeparator_Angle
            // 
            this.toolStripSeparator_Angle.Name = "toolStripSeparator_Angle";
            this.toolStripSeparator_Angle.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox_SpeakerAngle
            // 
            this.toolStripComboBox_SpeakerAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_SpeakerAngle.Name = "toolStripComboBox_SpeakerAngle";
            this.toolStripComboBox_SpeakerAngle.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_SpeakerAngle.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SpeakerAngle_SelectedIndexChanged);
            // 
            // singleButton_ResetConfig
            // 
            this.singleButton_ResetConfig.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_ResetConfig.ButtonText = "$VIRT_RESET";
            this.singleButton_ResetConfig.Location = new System.Drawing.Point(151, 39);
            this.singleButton_ResetConfig.Name = "singleButton_ResetConfig";
            this.singleButton_ResetConfig.Size = new System.Drawing.Size(167, 28);
            this.singleButton_ResetConfig.TabIndex = 4;
            this.singleButton_ResetConfig.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_ResetConfig_ButtonClickNotify);
            // 
            // buttonBox_AudioSystemConfig
            // 
            this.buttonBox_AudioSystemConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonBox_AudioSystemConfig.Location = new System.Drawing.Point(14, 39);
            this.buttonBox_AudioSystemConfig.Name = "buttonBox_AudioSystemConfig";
            this.buttonBox_AudioSystemConfig.Size = new System.Drawing.Size(131, 373);
            this.buttonBox_AudioSystemConfig.TabIndex = 1;
            this.buttonBox_AudioSystemConfig.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_AudioSystemConfig_ItemSelectedNotify);
            this.buttonBox_AudioSystemConfig.Load += new System.EventHandler(this.buttonBox_AudioSystemConfig_Load);
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(343, 378);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(89, 32);
            this.singleButton_OK.TabIndex = 29;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(455, 378);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 30;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // frmVirtualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 427);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.groupBox_VirtEnv);
            this.Controls.Add(this.singleButton_ResetConfig);
            this.Controls.Add(this.listView_Speaker);
            this.Controls.Add(this.groupBox_VirtApplied);
            this.Controls.Add(this.buttonBox_AudioSystemConfig);
            this.Controls.Add(this.label_AudioSystemConfig);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVirtualization";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$VIRTUALIZATION";
            this.ThemeName = "VisualStudio2012Dark";
            this.groupBox_VirtApplied.ResumeLayout(false);
            this.groupBox_VirtApplied.PerformLayout();
            this.groupBox_VirtEnv.ResumeLayout(false);
            this.groupBox_VirtEnv.PerformLayout();
            this.contextMenuStrip_SpeakerAngle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void SetBaseSystemParam(
          RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramSystem)
        {
            m_paramSystem = paramSystem;
            int num1 = m_paramSystem.m_bVirtApplied & 1;
            int num2 = m_paramSystem.m_bVirtApplied >> 1 & 1;
            int num3 = m_paramSystem.m_bVirtApplied >> 2 & 1;
            if (num1 == 1)
            {
                checkBox_MusicMode.Checked = true;
            }

            if (num2 == 1)
            {
                checkBox_MovieMode.Checked = true;
            }

            if (num3 == 1)
            {
                checkBox_Freestyle.Checked = true;
            }

            onOffSwitch_EnvRealize.SwitchedOn = m_paramSystem.m_bEnvRealizeEnabled == 1;
            hSlider_EnvRealizeDrySignal.PositionFloat = m_paramSystem.m_rEnvRealizeDrySignal;
            twoSelector_PrePostProcess.Selector = m_paramSystem.m_bEnvRealizePreprocess != 1 ? TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT : TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            for (int index = 0; index < comboBox_EnvRealizePreset.Items.Count; ++index)
            {
                if ((comboBox_EnvRealizePreset.Items[index] as frmVirtualization.EnvRealizePreset).PresetID == m_paramSystem.m_nEnvRealizePreset)
                {
                    comboBox_EnvRealizePreset.SelectedIndex = index;
                    break;
                }
            }
        }

        public RuntimeUtils.ConfigProxy._ParamOfBaseSystem GetBaseSystemParam()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            if (checkBox_MusicMode.Checked)
            {
                num1 = 1;
            }

            if (checkBox_MovieMode.Checked)
            {
                num2 = 1;
            }

            if (checkBox_Freestyle.Checked)
            {
                num3 = 1;
            }

            m_paramSystem.m_bVirtApplied = num1 | num2 << 1 | num3 << 2;
            m_paramSystem.m_bEnvRealizeEnabled = !onOffSwitch_EnvRealize.SwitchedOn ? 0 : 1;
            m_paramSystem.m_bEnvRealizePreprocess = twoSelector_PrePostProcess.Selector != TwoSelector.SelectorPosition.SELECTOR_ON_LEFT ? 0 : 1;
            m_paramSystem.m_rEnvRealizeDrySignal = hSlider_EnvRealizeDrySignal.PositionFloat;
            if (comboBox_EnvRealizePreset.SelectedItem == null)
            {
                m_paramSystem.m_bEnvRealizeEnabled = 0;
            }
            else if (comboBox_EnvRealizePreset.SelectedItem.GetType() != typeof(frmVirtualization.EnvRealizePreset))
            {
                m_paramSystem.m_bEnvRealizeEnabled = 0;
            }
            else
            {
                m_paramSystem.m_nEnvRealizePreset = (comboBox_EnvRealizePreset.SelectedItem as frmVirtualization.EnvRealizePreset).PresetID;
            }

            return m_paramSystem;
        }

        public frmVirtualization()
        {
            Parameters.LoadDefaultParameter(ref m_paramSystem);
            m_nCurrentAudioSystem = -1;
            InitializeComponent();
            Text = GlobalMessages.VIRTUALIZATION;
            label_AudioSystemConfig.Text = GlobalMessages.AUDIO_SYSTEM_CONFIG;
            singleButton_ResetConfig.ButtonText = GlobalMessages.VIRT_RESET;
            groupBox_VirtApplied.Text = GlobalMessages.VIRT_APPLIED;
            checkBox_MusicMode.Text = GlobalMessages.MUSIC_MODE;
            checkBox_MovieMode.Text = GlobalMessages.MOVIE_MODE;
            checkBox_Freestyle.Text = GlobalMessages.FREESTYLE_MODE;
            groupBox_VirtEnv.Text = GlobalMessages.VIRT_ENVIRONMENT;
            label_PrePostProcess.Text = GlobalMessages.VIRT_PREPOST_PROCESS;
            singleButton_OK.Text = GlobalMessages.OK;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            buttonBox_AudioSystemConfig.ClearItem();
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_MONO, "0"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_STEREO, "1"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_HEADSET, "2"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_REARSTEREO, "3"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_QUAD, "4"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X5P1, "5"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X6P1, "6"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X7P1, "7"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X8P1, "8"));
            listView_Speaker.Columns[0].Text = GlobalMessages.VIRT_SPEAKER;
            listView_Speaker.Columns[1].Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
            listView_Speaker.Items.Clear();
            checkBox_MusicMode.Checked = false;
            checkBox_MovieMode.Checked = false;
            checkBox_Freestyle.Checked = false;
            onOffSwitch_EnvRealize.SwitchedOn = false;
            hSlider_EnvRealizeDrySignal.PositionFloat = 0.7f;
            twoSelector_PrePostProcess.Selector = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            comboBox_EnvRealizePreset.Items.Clear();
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_SMALLROOM, 2));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_BATHROOM, 3));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_LIVINGROOM, 4));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_STONEROOM, 5));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_AUDITORIUM, 6));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_CONCERTHALL, 7));
            comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_HALLWAY, 12));
            toolStripMenuItem_SpeakerAngle.Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
            toolStripComboBox_SpeakerAngle.Items.Clear();
            for (int index = -180; index <= 180; index += 10)
            {
                toolStripComboBox_SpeakerAngle.Items.Add(new frmVirtualization.SpeakerAngle(index));
            }
        }

        private string FormatAngleString(float fAngle)
        {
            return fAngle >= 0.0 ? "+" + fAngle.ToString("F01") : fAngle.ToString("F01");
        }

        private void RefreshSpeakerList()
        {
            listView_Speaker.Items.Clear();
            switch (m_nCurrentAudioSystem)
            {
                case 0:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_00[0])
                    }));
                    break;
                case 1:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_01[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_01[1])
                    }));
                    break;
                case 2:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_02[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_02[1])
                    }));
                    break;
                case 3:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_03[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_03[1])
                    }));
                    break;
                case 4:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[3])
                    }));
                    break;
                case 5:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[5])
                    }));
                    break;
                case 6:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[6])
                    }));
                    break;
                case 7:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[7])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[7])
                    }));
                    break;
                case 8:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[6])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[7])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[8])
                    }));
                    break;
            }
        }

        private void buttonBox_AudioSystemConfig_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || itCurrItem.Tag.GetType() != typeof(string))
            {
                return;
            }

            string tag = itCurrItem.Tag as string;
            if (string.IsNullOrEmpty(tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 8)
            {
                return;
            }

            m_nCurrentAudioSystem = result;
            RefreshSpeakerList();
        }

        private void singleButton_ResetConfig_ButtonClickNotify(SingleButton objSender)
        {
            m_paramSystem.m_rpChannelAngle_00 = new float[9];
            m_paramSystem.m_rpChannelAngle_01 = new float[9];
            m_paramSystem.m_rpChannelAngle_02 = new float[9];
            m_paramSystem.m_rpChannelAngle_03 = new float[9];
            m_paramSystem.m_rpChannelAngle_04 = new float[9];
            m_paramSystem.m_rpChannelAngle_05 = new float[9];
            m_paramSystem.m_rpChannelAngle_06 = new float[9];
            m_paramSystem.m_rpChannelAngle_07 = new float[9];
            m_paramSystem.m_rpChannelAngle_08 = new float[9];
            m_paramSystem.m_rpChannelAngle_00[0] = 0.0f;
            m_paramSystem.m_rpChannelAngle_01[0] = -30f;
            m_paramSystem.m_rpChannelAngle_01[1] = 30f;
            m_paramSystem.m_rpChannelAngle_02[0] = -90f;
            m_paramSystem.m_rpChannelAngle_02[1] = 90f;
            m_paramSystem.m_rpChannelAngle_03[0] = -150f;
            m_paramSystem.m_rpChannelAngle_03[1] = 150f;
            m_paramSystem.m_rpChannelAngle_04[0] = -45f;
            m_paramSystem.m_rpChannelAngle_04[1] = 45f;
            m_paramSystem.m_rpChannelAngle_04[2] = -135f;
            m_paramSystem.m_rpChannelAngle_04[3] = 135f;
            m_paramSystem.m_rpChannelAngle_05[0] = -30f;
            m_paramSystem.m_rpChannelAngle_05[1] = 30f;
            m_paramSystem.m_rpChannelAngle_05[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_05[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_05[4] = -110f;
            m_paramSystem.m_rpChannelAngle_05[5] = 110f;
            m_paramSystem.m_rpChannelAngle_06[0] = -30f;
            m_paramSystem.m_rpChannelAngle_06[1] = 30f;
            m_paramSystem.m_rpChannelAngle_06[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_06[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_06[4] = 180f;
            m_paramSystem.m_rpChannelAngle_06[5] = -90f;
            m_paramSystem.m_rpChannelAngle_06[6] = 90f;
            m_paramSystem.m_rpChannelAngle_07[0] = -30f;
            m_paramSystem.m_rpChannelAngle_07[1] = 30f;
            m_paramSystem.m_rpChannelAngle_07[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_07[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_07[4] = -150f;
            m_paramSystem.m_rpChannelAngle_07[5] = 150f;
            m_paramSystem.m_rpChannelAngle_07[6] = -90f;
            m_paramSystem.m_rpChannelAngle_07[7] = 90f;
            m_paramSystem.m_rpChannelAngle_08[0] = -30f;
            m_paramSystem.m_rpChannelAngle_08[1] = 30f;
            m_paramSystem.m_rpChannelAngle_08[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_08[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_08[4] = -150f;
            m_paramSystem.m_rpChannelAngle_08[5] = 150f;
            m_paramSystem.m_rpChannelAngle_08[6] = 180f;
            m_paramSystem.m_rpChannelAngle_08[7] = -90f;
            m_paramSystem.m_rpChannelAngle_08[8] = 90f;
            RefreshSpeakerList();
        }

        private void listView_Speaker_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || m_nCurrentAudioSystem < 0 || listView_Speaker.SelectedItems.Count != 1)
            {
                return;
            }

            float[] numArray = null;
            int num1 = -1;
            switch (m_nCurrentAudioSystem)
            {
                case 0:
                    numArray = m_paramSystem.m_rpChannelAngle_00;
                    num1 = 1;
                    break;
                case 1:
                    numArray = m_paramSystem.m_rpChannelAngle_01;
                    num1 = 2;
                    break;
                case 2:
                    numArray = m_paramSystem.m_rpChannelAngle_02;
                    num1 = 2;
                    break;
                case 3:
                    numArray = m_paramSystem.m_rpChannelAngle_03;
                    num1 = 2;
                    break;
                case 4:
                    numArray = m_paramSystem.m_rpChannelAngle_04;
                    num1 = 4;
                    break;
                case 5:
                    numArray = m_paramSystem.m_rpChannelAngle_05;
                    num1 = 6;
                    break;
                case 6:
                    numArray = m_paramSystem.m_rpChannelAngle_06;
                    num1 = 7;
                    break;
                case 7:
                    numArray = m_paramSystem.m_rpChannelAngle_07;
                    num1 = 8;
                    break;
                case 8:
                    numArray = m_paramSystem.m_rpChannelAngle_08;
                    num1 = 9;
                    break;
            }
            if (numArray == null)
            {
                return;
            }

            int index1 = listView_Speaker.SelectedItems[0].Index;
            if (index1 >= num1)
            {
                return;
            }

            float num2 = numArray[index1];
            int num3 = -1;
            for (int index2 = 0; index2 < toolStripComboBox_SpeakerAngle.Items.Count; ++index2)
            {
                frmVirtualization.SpeakerAngle speakerAngle = toolStripComboBox_SpeakerAngle.Items[index2] as frmVirtualization.SpeakerAngle;
                if (speakerAngle.AngleFloat == (double)num2)
                {
                    num3 = index2;
                    break;
                }
                if (speakerAngle.AngleFloat == 0.0)
                {
                    num3 = index2;
                }
            }
            if (num3 == -1)
            {
                return;
            }

            contextMenuStrip_SpeakerAngle.Tag = null;
            toolStripComboBox_SpeakerAngle.SelectedIndex = num3;
            contextMenuStrip_SpeakerAngle.Tag = index1.ToString();
            contextMenuStrip_SpeakerAngle.Show(listView_Speaker, e.Location);
        }

        private void toolStripComboBox_SpeakerAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_nCurrentAudioSystem < 0 || contextMenuStrip_SpeakerAngle.Tag == null || contextMenuStrip_SpeakerAngle.Tag.GetType() != typeof(string))
            {
                return;
            }

            string tag = contextMenuStrip_SpeakerAngle.Tag as string;
            if (string.IsNullOrEmpty(tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result))
            {
                return;
            }

            float[] numArray = null;
            int num = -1;
            switch (m_nCurrentAudioSystem)
            {
                case 0:
                    numArray = m_paramSystem.m_rpChannelAngle_00;
                    num = 1;
                    break;
                case 1:
                    numArray = m_paramSystem.m_rpChannelAngle_01;
                    num = 2;
                    break;
                case 2:
                    numArray = m_paramSystem.m_rpChannelAngle_02;
                    num = 2;
                    break;
                case 3:
                    numArray = m_paramSystem.m_rpChannelAngle_03;
                    num = 2;
                    break;
                case 4:
                    numArray = m_paramSystem.m_rpChannelAngle_04;
                    num = 4;
                    break;
                case 5:
                    numArray = m_paramSystem.m_rpChannelAngle_05;
                    num = 6;
                    break;
                case 6:
                    numArray = m_paramSystem.m_rpChannelAngle_06;
                    num = 7;
                    break;
                case 7:
                    numArray = m_paramSystem.m_rpChannelAngle_07;
                    num = 8;
                    break;
                case 8:
                    numArray = m_paramSystem.m_rpChannelAngle_08;
                    num = 9;
                    break;
            }
            if (numArray == null || result >= num || (toolStripComboBox_SpeakerAngle.SelectedItem == null || toolStripComboBox_SpeakerAngle.SelectedItem.GetType() != typeof(frmVirtualization.SpeakerAngle)))
            {
                return;
            }

            frmVirtualization.SpeakerAngle selectedItem = toolStripComboBox_SpeakerAngle.SelectedItem as frmVirtualization.SpeakerAngle;
            numArray[result] = selectedItem.AngleFloat;
        }

        private void contextMenuStrip_SpeakerAngle_Closed(
          object sender,
          ToolStripDropDownClosedEventArgs e)
        {
            contextMenuStrip_SpeakerAngle.Tag = null;
            RefreshSpeakerList();
        }

        private class EnvRealizePreset
        {
            private string m_szPresetName = "";
            private readonly int m_nPresetID = -1;

            public string PresetName => m_szPresetName;

            public string Text
            {
                get => m_szPresetName;
                set => m_szPresetName = value;
            }

            public int PresetID => m_nPresetID;

            public EnvRealizePreset(string szPresetName, int nPresetID)
            {
                m_szPresetName = szPresetName;
                m_nPresetID = nPresetID;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || obj.GetType() != typeof(frmVirtualization.EnvRealizePreset))
                {
                    return false;
                }

                frmVirtualization.EnvRealizePreset envRealizePreset = obj as frmVirtualization.EnvRealizePreset;
                return envRealizePreset.PresetName == m_szPresetName && envRealizePreset.PresetID == m_nPresetID;
            }

            public override int GetHashCode()
            {
                return m_nPresetID;
            }

            public override string ToString()
            {
                return m_szPresetName;
            }
        }

        private class SpeakerAngle
        {
            private float m_fAngle;

            public string AngleString => m_fAngle >= 0.0 ? "+" + m_fAngle.ToString("F01") : m_fAngle.ToString("F01");

            public float AngleFloat
            {
                get => m_fAngle;
                set => m_fAngle = value;
            }

            public SpeakerAngle(float fAngle)
            {
                m_fAngle = fAngle;
            }

            public override bool Equals(object obj)
            {
                return obj != null && obj.GetType() == typeof(frmVirtualization.SpeakerAngle) && (obj as SpeakerAngle).AngleFloat == (double)m_fAngle;
            }

            public override int GetHashCode()
            {
                return (int)Math.Round(m_fAngle);
            }

            public override string ToString()
            {
                return AngleString;
            }
        }

        private void buttonBox_AudioSystemConfig_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_SpeakerAngle_Click(object sender, EventArgs e)
        {

        }
    }
}
