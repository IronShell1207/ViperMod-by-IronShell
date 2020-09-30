// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmCompressor
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
    public class frmCompressor : Telerik.WinControls.UI.RadForm
    {
        private bool m_bAutoKnee = true;
        private float m_rAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
        private bool m_bAutoAttack = true;
        private float m_rRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
        private bool m_bAutoRelease = true;
        private bool m_bAutoGain = true;
        private bool m_bNoClip = true;
        private float m_rKneeMult = Parameters.LIN2PARAM(2f, 0.0f, 4f);
        private float m_rCrestTime = Parameters.LOG2PARAM(0.2f, 0.005f, 2f);
        private float m_rAdaptTime = Parameters.LOG2PARAM(2.5f, 1f, 4f);
        private readonly IContainer components;
        private OnOffSwitch onOffSwitch_Compressor;
        private Label label_Compressor_Enable;
        private GroupBox groupBox_Threshold;
        private HSlider hSlider_Threshold;
        private Label label_Threshold;
        private GroupBox groupBox_Knee;
        private Label label_Knee;
        private HSlider hSlider_Knee;
        private Label label_AutoKnee;
        private OnOffSwitch onOffSwitch_AutoKnee;
        private GroupBox groupBox_Ratio;
        private Label label_Ratio;
        private HSlider hSlider_Ratio;
        private GroupBox groupBox_Release;
        private OnOffSwitch onOffSwitch_AutoRelease;
        private Label label_AutoRelease;
        private Label label_Release;
        private HSlider hSlider_Release;
        private GroupBox groupBox_Attack;
        private OnOffSwitch onOffSwitch_AutoAttack;
        private Label label_AutoAttack;
        private Label label_Attack;
        private HSlider hSlider_Attack;
        private GroupBox groupBox_MakeUpGain;
        private Label label_Gain;
        private HSlider hSlider_Gain;
        private OnOffSwitch onOffSwitch_AutoGain;
        private Label label_AutoGain;
        private Label label_NoClip;
        private OnOffSwitch onOffSwitch_NoClip;
        private GroupBox groupBox_Misc;
        private Label label_KneeMult;
        private Label label_KneeMultValue;
        private HSlider hSlider_KneeMult;
        private Label label_Adapt;
        private Label label_AdaptValue;
        private HSlider hSlider_Adapt;
        private Label label_Crest;
        private Label label_CrestValue;
        private HSlider hSlider_Crest;
        private bool m_bCompressorEnabled;
        private float m_rThreshold;
        private float m_rKneewidth;
        private float m_rRatio;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;
        private Telerik.WinControls.UI.RadButton singleButton_OK;
        private float m_rMakeupGain;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompressor));
            this.onOffSwitch_Compressor = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_Compressor_Enable = new System.Windows.Forms.Label();
            this.groupBox_Threshold = new System.Windows.Forms.GroupBox();
            this.label_Threshold = new System.Windows.Forms.Label();
            this.hSlider_Threshold = new ViPER4WindowsBin.UIControls.HSlider();
            this.groupBox_Knee = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoKnee = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_AutoKnee = new System.Windows.Forms.Label();
            this.label_Knee = new System.Windows.Forms.Label();
            this.hSlider_Knee = new ViPER4WindowsBin.UIControls.HSlider();
            this.groupBox_Ratio = new System.Windows.Forms.GroupBox();
            this.label_Ratio = new System.Windows.Forms.Label();
            this.hSlider_Ratio = new ViPER4WindowsBin.UIControls.HSlider();
            this.groupBox_Release = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoRelease = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_AutoRelease = new System.Windows.Forms.Label();
            this.label_Release = new System.Windows.Forms.Label();
            this.hSlider_Release = new ViPER4WindowsBin.UIControls.HSlider();
            this.groupBox_Attack = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoAttack = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_AutoAttack = new System.Windows.Forms.Label();
            this.label_Attack = new System.Windows.Forms.Label();
            this.hSlider_Attack = new ViPER4WindowsBin.UIControls.HSlider();
            this.groupBox_MakeUpGain = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoGain = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.label_AutoGain = new System.Windows.Forms.Label();
            this.label_Gain = new System.Windows.Forms.Label();
            this.hSlider_Gain = new ViPER4WindowsBin.UIControls.HSlider();
            this.label_NoClip = new System.Windows.Forms.Label();
            this.onOffSwitch_NoClip = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.groupBox_Misc = new System.Windows.Forms.GroupBox();
            this.label_Adapt = new System.Windows.Forms.Label();
            this.label_AdaptValue = new System.Windows.Forms.Label();
            this.hSlider_Adapt = new ViPER4WindowsBin.UIControls.HSlider();
            this.label_Crest = new System.Windows.Forms.Label();
            this.label_CrestValue = new System.Windows.Forms.Label();
            this.hSlider_Crest = new ViPER4WindowsBin.UIControls.HSlider();
            this.label_KneeMult = new System.Windows.Forms.Label();
            this.label_KneeMultValue = new System.Windows.Forms.Label();
            this.hSlider_KneeMult = new ViPER4WindowsBin.UIControls.HSlider();
            this.singleButton_Cancel = new Telerik.WinControls.UI.RadButton();
            this.singleButton_OK = new Telerik.WinControls.UI.RadButton();
            this.groupBox_Threshold.SuspendLayout();
            this.groupBox_Knee.SuspendLayout();
            this.groupBox_Ratio.SuspendLayout();
            this.groupBox_Release.SuspendLayout();
            this.groupBox_Attack.SuspendLayout();
            this.groupBox_MakeUpGain.SuspendLayout();
            this.groupBox_Misc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // onOffSwitch_Compressor
            // 
            this.onOffSwitch_Compressor.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_Compressor.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_Compressor.Location = new System.Drawing.Point(12, 29);
            this.onOffSwitch_Compressor.Name = "onOffSwitch_Compressor";
            this.onOffSwitch_Compressor.Size = new System.Drawing.Size(107, 28);
            this.onOffSwitch_Compressor.SwitchedOn = false;
            this.onOffSwitch_Compressor.TabIndex = 3;
            this.onOffSwitch_Compressor.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_Compressor_SwitchChangeNotify);
            // 
            // label_Compressor_Enable
            // 
            this.label_Compressor_Enable.AutoSize = true;
            this.label_Compressor_Enable.ForeColor = System.Drawing.Color.Snow;
            this.label_Compressor_Enable.Location = new System.Drawing.Point(12, 14);
            this.label_Compressor_Enable.Name = "label_Compressor_Enable";
            this.label_Compressor_Enable.Size = new System.Drawing.Size(51, 13);
            this.label_Compressor_Enable.TabIndex = 2;
            this.label_Compressor_Enable.Text = "$ENABLE";
            // 
            // groupBox_Threshold
            // 
            this.groupBox_Threshold.Controls.Add(this.label_Threshold);
            this.groupBox_Threshold.Controls.Add(this.hSlider_Threshold);
            this.groupBox_Threshold.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Threshold.Location = new System.Drawing.Point(12, 73);
            this.groupBox_Threshold.Name = "groupBox_Threshold";
            this.groupBox_Threshold.Size = new System.Drawing.Size(548, 61);
            this.groupBox_Threshold.TabIndex = 4;
            this.groupBox_Threshold.TabStop = false;
            this.groupBox_Threshold.Text = "$COMPRESSOR_THRESHOLD";
            // 
            // label_Threshold
            // 
            this.label_Threshold.AutoSize = true;
            this.label_Threshold.ForeColor = System.Drawing.Color.Snow;
            this.label_Threshold.Location = new System.Drawing.Point(475, 29);
            this.label_Threshold.Name = "label_Threshold";
            this.label_Threshold.Size = new System.Drawing.Size(26, 13);
            this.label_Threshold.TabIndex = 5;
            this.label_Threshold.Text = "0dB";
            // 
            // hSlider_Threshold
            // 
            this.hSlider_Threshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Threshold.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Threshold.Location = new System.Drawing.Point(6, 20);
            this.hSlider_Threshold.MoveDelta = ((uint)(1u));
            this.hSlider_Threshold.Name = "hSlider_Threshold";
            this.hSlider_Threshold.Position = ((uint)(0u));
            this.hSlider_Threshold.PositionFloat = 0F;
            this.hSlider_Threshold.Size = new System.Drawing.Size(463, 29);
            this.hSlider_Threshold.TabIndex = 5;
            this.hSlider_Threshold.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Threshold_PositionChangeNotify);
            // 
            // groupBox_Knee
            // 
            this.groupBox_Knee.Controls.Add(this.onOffSwitch_AutoKnee);
            this.groupBox_Knee.Controls.Add(this.label_AutoKnee);
            this.groupBox_Knee.Controls.Add(this.label_Knee);
            this.groupBox_Knee.Controls.Add(this.hSlider_Knee);
            this.groupBox_Knee.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Knee.Location = new System.Drawing.Point(12, 140);
            this.groupBox_Knee.Name = "groupBox_Knee";
            this.groupBox_Knee.Size = new System.Drawing.Size(271, 115);
            this.groupBox_Knee.TabIndex = 5;
            this.groupBox_Knee.TabStop = false;
            this.groupBox_Knee.Text = "$COMPRESSOR_KNEEWIDTH";
            // 
            // onOffSwitch_AutoKnee
            // 
            this.onOffSwitch_AutoKnee.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoKnee.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_AutoKnee.Location = new System.Drawing.Point(22, 41);
            this.onOffSwitch_AutoKnee.Name = "onOffSwitch_AutoKnee";
            this.onOffSwitch_AutoKnee.Size = new System.Drawing.Size(49, 22);
            this.onOffSwitch_AutoKnee.SwitchedOn = false;
            this.onOffSwitch_AutoKnee.TabIndex = 6;
            this.onOffSwitch_AutoKnee.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoKnee_SwitchChangeNotify);
            // 
            // label_AutoKnee
            // 
            this.label_AutoKnee.AutoSize = true;
            this.label_AutoKnee.ForeColor = System.Drawing.Color.Snow;
            this.label_AutoKnee.Location = new System.Drawing.Point(20, 26);
            this.label_AutoKnee.Name = "label_AutoKnee";
            this.label_AutoKnee.Size = new System.Drawing.Size(146, 13);
            this.label_AutoKnee.TabIndex = 6;
            this.label_AutoKnee.Text = "$COMPRESSOR_AUTOKNEE";
            // 
            // label_Knee
            // 
            this.label_Knee.AutoSize = true;
            this.label_Knee.ForeColor = System.Drawing.Color.Snow;
            this.label_Knee.Location = new System.Drawing.Point(198, 81);
            this.label_Knee.Name = "label_Knee";
            this.label_Knee.Size = new System.Drawing.Size(26, 13);
            this.label_Knee.TabIndex = 5;
            this.label_Knee.Text = "0dB";
            // 
            // hSlider_Knee
            // 
            this.hSlider_Knee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Knee.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Knee.Location = new System.Drawing.Point(7, 72);
            this.hSlider_Knee.MoveDelta = ((uint)(1u));
            this.hSlider_Knee.Name = "hSlider_Knee";
            this.hSlider_Knee.Position = ((uint)(0u));
            this.hSlider_Knee.PositionFloat = 0F;
            this.hSlider_Knee.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Knee.TabIndex = 5;
            this.hSlider_Knee.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Knee_PositionChangeNotify);
            // 
            // groupBox_Ratio
            // 
            this.groupBox_Ratio.Controls.Add(this.label_Ratio);
            this.groupBox_Ratio.Controls.Add(this.hSlider_Ratio);
            this.groupBox_Ratio.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Ratio.Location = new System.Drawing.Point(289, 140);
            this.groupBox_Ratio.Name = "groupBox_Ratio";
            this.groupBox_Ratio.Size = new System.Drawing.Size(271, 115);
            this.groupBox_Ratio.TabIndex = 6;
            this.groupBox_Ratio.TabStop = false;
            this.groupBox_Ratio.Text = "$COMPRESSOR_RATIO";
            // 
            // label_Ratio
            // 
            this.label_Ratio.AutoSize = true;
            this.label_Ratio.ForeColor = System.Drawing.Color.Snow;
            this.label_Ratio.Location = new System.Drawing.Point(198, 54);
            this.label_Ratio.Name = "label_Ratio";
            this.label_Ratio.Size = new System.Drawing.Size(37, 13);
            this.label_Ratio.TabIndex = 5;
            this.label_Ratio.Text = "1.00:1";
            // 
            // hSlider_Ratio
            // 
            this.hSlider_Ratio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Ratio.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Ratio.Location = new System.Drawing.Point(7, 45);
            this.hSlider_Ratio.MoveDelta = ((uint)(1u));
            this.hSlider_Ratio.Name = "hSlider_Ratio";
            this.hSlider_Ratio.Position = ((uint)(0u));
            this.hSlider_Ratio.PositionFloat = 0F;
            this.hSlider_Ratio.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Ratio.TabIndex = 5;
            this.hSlider_Ratio.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Ratio_PositionChangeNotify);
            // 
            // groupBox_Release
            // 
            this.groupBox_Release.Controls.Add(this.onOffSwitch_AutoRelease);
            this.groupBox_Release.Controls.Add(this.label_AutoRelease);
            this.groupBox_Release.Controls.Add(this.label_Release);
            this.groupBox_Release.Controls.Add(this.hSlider_Release);
            this.groupBox_Release.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Release.Location = new System.Drawing.Point(289, 261);
            this.groupBox_Release.Name = "groupBox_Release";
            this.groupBox_Release.Size = new System.Drawing.Size(271, 115);
            this.groupBox_Release.TabIndex = 8;
            this.groupBox_Release.TabStop = false;
            this.groupBox_Release.Text = "$COMPRESSOR_RELEASE";
            // 
            // onOffSwitch_AutoRelease
            // 
            this.onOffSwitch_AutoRelease.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoRelease.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_AutoRelease.Location = new System.Drawing.Point(22, 41);
            this.onOffSwitch_AutoRelease.Name = "onOffSwitch_AutoRelease";
            this.onOffSwitch_AutoRelease.Size = new System.Drawing.Size(49, 22);
            this.onOffSwitch_AutoRelease.SwitchedOn = false;
            this.onOffSwitch_AutoRelease.TabIndex = 6;
            this.onOffSwitch_AutoRelease.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoRelease_SwitchChangeNotify);
            // 
            // label_AutoRelease
            // 
            this.label_AutoRelease.AutoSize = true;
            this.label_AutoRelease.ForeColor = System.Drawing.Color.Snow;
            this.label_AutoRelease.Location = new System.Drawing.Point(20, 26);
            this.label_AutoRelease.Name = "label_AutoRelease";
            this.label_AutoRelease.Size = new System.Drawing.Size(163, 13);
            this.label_AutoRelease.TabIndex = 6;
            this.label_AutoRelease.Text = "$COMPRESSOR_AUTORELEASE";
            // 
            // label_Release
            // 
            this.label_Release.AutoSize = true;
            this.label_Release.ForeColor = System.Drawing.Color.Snow;
            this.label_Release.Location = new System.Drawing.Point(198, 81);
            this.label_Release.Name = "label_Release";
            this.label_Release.Size = new System.Drawing.Size(42, 13);
            this.label_Release.TabIndex = 5;
            this.label_Release.Text = "5.00ms";
            // 
            // hSlider_Release
            // 
            this.hSlider_Release.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Release.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Release.Location = new System.Drawing.Point(7, 72);
            this.hSlider_Release.MoveDelta = ((uint)(1u));
            this.hSlider_Release.Name = "hSlider_Release";
            this.hSlider_Release.Position = ((uint)(0u));
            this.hSlider_Release.PositionFloat = 0F;
            this.hSlider_Release.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Release.TabIndex = 5;
            this.hSlider_Release.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Release_PositionChangeNotify);
            // 
            // groupBox_Attack
            // 
            this.groupBox_Attack.Controls.Add(this.onOffSwitch_AutoAttack);
            this.groupBox_Attack.Controls.Add(this.label_AutoAttack);
            this.groupBox_Attack.Controls.Add(this.label_Attack);
            this.groupBox_Attack.Controls.Add(this.hSlider_Attack);
            this.groupBox_Attack.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Attack.Location = new System.Drawing.Point(12, 261);
            this.groupBox_Attack.Name = "groupBox_Attack";
            this.groupBox_Attack.Size = new System.Drawing.Size(271, 115);
            this.groupBox_Attack.TabIndex = 7;
            this.groupBox_Attack.TabStop = false;
            this.groupBox_Attack.Text = "$COMPRESSOR_ATTACK";
            // 
            // onOffSwitch_AutoAttack
            // 
            this.onOffSwitch_AutoAttack.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoAttack.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_AutoAttack.Location = new System.Drawing.Point(22, 41);
            this.onOffSwitch_AutoAttack.Name = "onOffSwitch_AutoAttack";
            this.onOffSwitch_AutoAttack.Size = new System.Drawing.Size(49, 22);
            this.onOffSwitch_AutoAttack.SwitchedOn = false;
            this.onOffSwitch_AutoAttack.TabIndex = 6;
            this.onOffSwitch_AutoAttack.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoAttack_SwitchChangeNotify);
            // 
            // label_AutoAttack
            // 
            this.label_AutoAttack.AutoSize = true;
            this.label_AutoAttack.ForeColor = System.Drawing.Color.Snow;
            this.label_AutoAttack.Location = new System.Drawing.Point(20, 26);
            this.label_AutoAttack.Name = "label_AutoAttack";
            this.label_AutoAttack.Size = new System.Drawing.Size(157, 13);
            this.label_AutoAttack.TabIndex = 6;
            this.label_AutoAttack.Text = "$COMPRESSOR_AUTOATTACK";
            // 
            // label_Attack
            // 
            this.label_Attack.AutoSize = true;
            this.label_Attack.ForeColor = System.Drawing.Color.Snow;
            this.label_Attack.Location = new System.Drawing.Point(198, 81);
            this.label_Attack.Name = "label_Attack";
            this.label_Attack.Size = new System.Drawing.Size(42, 13);
            this.label_Attack.TabIndex = 5;
            this.label_Attack.Text = "0.10ms";
            // 
            // hSlider_Attack
            // 
            this.hSlider_Attack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Attack.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Attack.Location = new System.Drawing.Point(7, 72);
            this.hSlider_Attack.MoveDelta = ((uint)(1u));
            this.hSlider_Attack.Name = "hSlider_Attack";
            this.hSlider_Attack.Position = ((uint)(0u));
            this.hSlider_Attack.PositionFloat = 0F;
            this.hSlider_Attack.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Attack.TabIndex = 5;
            this.hSlider_Attack.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Attack_PositionChangeNotify);
            // 
            // groupBox_MakeUpGain
            // 
            this.groupBox_MakeUpGain.Controls.Add(this.onOffSwitch_AutoGain);
            this.groupBox_MakeUpGain.Controls.Add(this.label_AutoGain);
            this.groupBox_MakeUpGain.Controls.Add(this.label_Gain);
            this.groupBox_MakeUpGain.Controls.Add(this.hSlider_Gain);
            this.groupBox_MakeUpGain.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_MakeUpGain.Location = new System.Drawing.Point(12, 516);
            this.groupBox_MakeUpGain.Name = "groupBox_MakeUpGain";
            this.groupBox_MakeUpGain.Size = new System.Drawing.Size(548, 110);
            this.groupBox_MakeUpGain.TabIndex = 11;
            this.groupBox_MakeUpGain.TabStop = false;
            this.groupBox_MakeUpGain.Text = "$COMPRESSOR_MAKEUPGAIN";
            // 
            // onOffSwitch_AutoGain
            // 
            this.onOffSwitch_AutoGain.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoGain.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_AutoGain.Location = new System.Drawing.Point(22, 41);
            this.onOffSwitch_AutoGain.Name = "onOffSwitch_AutoGain";
            this.onOffSwitch_AutoGain.Size = new System.Drawing.Size(49, 22);
            this.onOffSwitch_AutoGain.SwitchedOn = false;
            this.onOffSwitch_AutoGain.TabIndex = 8;
            this.onOffSwitch_AutoGain.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoGain_SwitchChangeNotify);
            // 
            // label_AutoGain
            // 
            this.label_AutoGain.AutoSize = true;
            this.label_AutoGain.ForeColor = System.Drawing.Color.Snow;
            this.label_AutoGain.Location = new System.Drawing.Point(20, 26);
            this.label_AutoGain.Name = "label_AutoGain";
            this.label_AutoGain.Size = new System.Drawing.Size(146, 13);
            this.label_AutoGain.TabIndex = 7;
            this.label_AutoGain.Text = "$COMPRESSOR_AUTOGAIN";
            // 
            // label_Gain
            // 
            this.label_Gain.AutoSize = true;
            this.label_Gain.ForeColor = System.Drawing.Color.Snow;
            this.label_Gain.Location = new System.Drawing.Point(475, 79);
            this.label_Gain.Name = "label_Gain";
            this.label_Gain.Size = new System.Drawing.Size(26, 13);
            this.label_Gain.TabIndex = 5;
            this.label_Gain.Text = "0dB";
            // 
            // hSlider_Gain
            // 
            this.hSlider_Gain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Gain.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Gain.Location = new System.Drawing.Point(7, 71);
            this.hSlider_Gain.MoveDelta = ((uint)(1u));
            this.hSlider_Gain.Name = "hSlider_Gain";
            this.hSlider_Gain.Position = ((uint)(0u));
            this.hSlider_Gain.PositionFloat = 0F;
            this.hSlider_Gain.Size = new System.Drawing.Size(462, 29);
            this.hSlider_Gain.TabIndex = 5;
            this.hSlider_Gain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Gain_PositionChangeNotify);
            // 
            // label_NoClip
            // 
            this.label_NoClip.AutoSize = true;
            this.label_NoClip.ForeColor = System.Drawing.Color.Snow;
            this.label_NoClip.Location = new System.Drawing.Point(163, 14);
            this.label_NoClip.Name = "label_NoClip";
            this.label_NoClip.Size = new System.Drawing.Size(129, 13);
            this.label_NoClip.TabIndex = 12;
            this.label_NoClip.Text = "$COMPRESSOR_NOCLIP";
            // 
            // onOffSwitch_NoClip
            // 
            this.onOffSwitch_NoClip.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_NoClip.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_NoClip.Location = new System.Drawing.Point(165, 29);
            this.onOffSwitch_NoClip.Name = "onOffSwitch_NoClip";
            this.onOffSwitch_NoClip.Size = new System.Drawing.Size(107, 28);
            this.onOffSwitch_NoClip.SwitchedOn = false;
            this.onOffSwitch_NoClip.TabIndex = 13;
            this.onOffSwitch_NoClip.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_NoClip_SwitchChangeNotify);
            // 
            // groupBox_Misc
            // 
            this.groupBox_Misc.Controls.Add(this.label_Adapt);
            this.groupBox_Misc.Controls.Add(this.label_AdaptValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_Adapt);
            this.groupBox_Misc.Controls.Add(this.label_Crest);
            this.groupBox_Misc.Controls.Add(this.label_CrestValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_Crest);
            this.groupBox_Misc.Controls.Add(this.label_KneeMult);
            this.groupBox_Misc.Controls.Add(this.label_KneeMultValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_KneeMult);
            this.groupBox_Misc.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_Misc.Location = new System.Drawing.Point(12, 382);
            this.groupBox_Misc.Name = "groupBox_Misc";
            this.groupBox_Misc.Size = new System.Drawing.Size(548, 128);
            this.groupBox_Misc.TabIndex = 14;
            this.groupBox_Misc.TabStop = false;
            this.groupBox_Misc.Text = "$COMPRESSOR_MISC";
            // 
            // label_Adapt
            // 
            this.label_Adapt.AutoSize = true;
            this.label_Adapt.ForeColor = System.Drawing.Color.Snow;
            this.label_Adapt.Location = new System.Drawing.Point(297, 76);
            this.label_Adapt.Name = "label_Adapt";
            this.label_Adapt.Size = new System.Drawing.Size(150, 13);
            this.label_Adapt.TabIndex = 12;
            this.label_Adapt.Text = "$COMPRESSOR_ADAPTTIME";
            // 
            // label_AdaptValue
            // 
            this.label_AdaptValue.AutoSize = true;
            this.label_AdaptValue.ForeColor = System.Drawing.Color.Snow;
            this.label_AdaptValue.Location = new System.Drawing.Point(475, 100);
            this.label_AdaptValue.Name = "label_AdaptValue";
            this.label_AdaptValue.Size = new System.Drawing.Size(42, 13);
            this.label_AdaptValue.TabIndex = 11;
            this.label_AdaptValue.Text = "0.00ms";
            // 
            // hSlider_Adapt
            // 
            this.hSlider_Adapt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Adapt.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Adapt.Location = new System.Drawing.Point(284, 91);
            this.hSlider_Adapt.MoveDelta = ((uint)(1u));
            this.hSlider_Adapt.Name = "hSlider_Adapt";
            this.hSlider_Adapt.Position = ((uint)(0u));
            this.hSlider_Adapt.PositionFloat = 0F;
            this.hSlider_Adapt.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Adapt.TabIndex = 10;
            this.hSlider_Adapt.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Adapt_PositionChangeNotify);
            // 
            // label_Crest
            // 
            this.label_Crest.AutoSize = true;
            this.label_Crest.ForeColor = System.Drawing.Color.Snow;
            this.label_Crest.Location = new System.Drawing.Point(297, 20);
            this.label_Crest.Name = "label_Crest";
            this.label_Crest.Size = new System.Drawing.Size(148, 13);
            this.label_Crest.TabIndex = 9;
            this.label_Crest.Text = "$COMPRESSOR_CRESTTIME";
            // 
            // label_CrestValue
            // 
            this.label_CrestValue.AutoSize = true;
            this.label_CrestValue.ForeColor = System.Drawing.Color.Snow;
            this.label_CrestValue.Location = new System.Drawing.Point(475, 44);
            this.label_CrestValue.Name = "label_CrestValue";
            this.label_CrestValue.Size = new System.Drawing.Size(42, 13);
            this.label_CrestValue.TabIndex = 8;
            this.label_CrestValue.Text = "0.00ms";
            // 
            // hSlider_Crest
            // 
            this.hSlider_Crest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Crest.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Crest.Location = new System.Drawing.Point(284, 35);
            this.hSlider_Crest.MoveDelta = ((uint)(1u));
            this.hSlider_Crest.Name = "hSlider_Crest";
            this.hSlider_Crest.Position = ((uint)(0u));
            this.hSlider_Crest.PositionFloat = 0F;
            this.hSlider_Crest.Size = new System.Drawing.Size(185, 31);
            this.hSlider_Crest.TabIndex = 7;
            this.hSlider_Crest.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Crest_PositionChangeNotify);
            // 
            // label_KneeMult
            // 
            this.label_KneeMult.AutoSize = true;
            this.label_KneeMult.ForeColor = System.Drawing.Color.Snow;
            this.label_KneeMult.Location = new System.Drawing.Point(20, 43);
            this.label_KneeMult.Name = "label_KneeMult";
            this.label_KneeMult.Size = new System.Drawing.Size(145, 13);
            this.label_KneeMult.TabIndex = 6;
            this.label_KneeMult.Text = "$COMPRESSOR_KNEEMULT";
            // 
            // label_KneeMultValue
            // 
            this.label_KneeMultValue.AutoSize = true;
            this.label_KneeMultValue.ForeColor = System.Drawing.Color.Snow;
            this.label_KneeMultValue.Location = new System.Drawing.Point(198, 67);
            this.label_KneeMultValue.Name = "label_KneeMultValue";
            this.label_KneeMultValue.Size = new System.Drawing.Size(33, 13);
            this.label_KneeMultValue.TabIndex = 5;
            this.label_KneeMultValue.Text = "2.00x";
            // 
            // hSlider_KneeMult
            // 
            this.hSlider_KneeMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_KneeMult.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_KneeMult.Location = new System.Drawing.Point(7, 58);
            this.hSlider_KneeMult.MoveDelta = ((uint)(1u));
            this.hSlider_KneeMult.Name = "hSlider_KneeMult";
            this.hSlider_KneeMult.Position = ((uint)(0u));
            this.hSlider_KneeMult.PositionFloat = 0F;
            this.hSlider_KneeMult.Size = new System.Drawing.Size(185, 31);
            this.hSlider_KneeMult.TabIndex = 5;
            this.hSlider_KneeMult.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_KneeMult_PositionChangeNotify);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(453, 25);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 26;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(341, 25);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(89, 32);
            this.singleButton_OK.TabIndex = 26;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "VisualStudio2012Dark";
            // 
            // frmCompressor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 637);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.groupBox_Misc);
            this.Controls.Add(this.onOffSwitch_NoClip);
            this.Controls.Add(this.label_NoClip);
            this.Controls.Add(this.groupBox_MakeUpGain);
            this.Controls.Add(this.groupBox_Release);
            this.Controls.Add(this.groupBox_Attack);
            this.Controls.Add(this.groupBox_Ratio);
            this.Controls.Add(this.groupBox_Knee);
            this.Controls.Add(this.groupBox_Threshold);
            this.Controls.Add(this.onOffSwitch_Compressor);
            this.Controls.Add(this.label_Compressor_Enable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompressor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$COMPRESSOR";
            this.ThemeName = "VisualStudio2012Dark";
            this.groupBox_Threshold.ResumeLayout(false);
            this.groupBox_Threshold.PerformLayout();
            this.groupBox_Knee.ResumeLayout(false);
            this.groupBox_Knee.PerformLayout();
            this.groupBox_Ratio.ResumeLayout(false);
            this.groupBox_Ratio.PerformLayout();
            this.groupBox_Release.ResumeLayout(false);
            this.groupBox_Release.PerformLayout();
            this.groupBox_Attack.ResumeLayout(false);
            this.groupBox_Attack.PerformLayout();
            this.groupBox_MakeUpGain.ResumeLayout(false);
            this.groupBox_MakeUpGain.PerformLayout();
            this.groupBox_Misc.ResumeLayout(false);
            this.groupBox_Misc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public bool CompressorEnabled
        {
            get => m_bCompressorEnabled;
            set
            {
                m_bCompressorEnabled = value;
                UpdateUI();
            }
        }

        public float Threshold
        {
            get => m_rThreshold;
            set
            {
                m_rThreshold = value;
                UpdateUI();
            }
        }

        public float KneeWidth
        {
            get => m_rKneewidth;
            set
            {
                m_rKneewidth = value;
                UpdateUI();
            }
        }

        public bool AutoKnee
        {
            get => m_bAutoKnee;
            set
            {
                m_bAutoKnee = value;
                UpdateUI();
            }
        }

        public float Ratio
        {
            get => m_rRatio;
            set
            {
                m_rRatio = value;
                UpdateUI();
            }
        }

        public float AttackTime
        {
            get => m_rAttack;
            set
            {
                m_rAttack = value;
                UpdateUI();
            }
        }

        public bool AutoAttack
        {
            get => m_bAutoAttack;
            set
            {
                m_bAutoAttack = value;
                UpdateUI();
            }
        }

        public float ReleaseTime
        {
            get => m_rRelease;
            set
            {
                m_rRelease = value;
                UpdateUI();
            }
        }

        public bool AutoRelease
        {
            get => m_bAutoRelease;
            set
            {
                m_bAutoRelease = value;
                UpdateUI();
            }
        }

        public float MakeupGain
        {
            get => m_rMakeupGain;
            set
            {
                m_rMakeupGain = value;
                UpdateUI();
            }
        }

        public bool AutoGain
        {
            get => m_bAutoGain;
            set
            {
                m_bAutoGain = value;
                UpdateUI();
            }
        }

        public bool NoClip
        {
            get => m_bNoClip;
            set
            {
                m_bNoClip = value;
                UpdateUI();
            }
        }

        public float KneeMult
        {
            get => m_rKneeMult;
            set
            {
                m_rKneeMult = value;
                UpdateUI();
            }
        }

        public float CrestTime
        {
            get => m_rCrestTime;
            set
            {
                m_rCrestTime = value;
                UpdateUI();
            }
        }

        public float AdaptTime
        {
            get => m_rAdaptTime;
            set
            {
                m_rAdaptTime = value;
                UpdateUI();
            }
        }

        public frmCompressor()
        {
            InitializeComponent();
            Text = GlobalMessages.COMPRESSOR;
            singleButton_OK.Text = GlobalMessages.OK;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            label_Compressor_Enable.Text = GlobalMessages.ENABLE;
            label_NoClip.Text = GlobalMessages.COMPRESSOR_NOCLIP;
            groupBox_Threshold.Text = GlobalMessages.COMPRESSOR_THRESHOLD;
            groupBox_Knee.Text = GlobalMessages.COMPRESSOR_KNEEWIDTH;
            label_AutoKnee.Text = GlobalMessages.COMPRESSOR_AUTOKNEE;
            groupBox_Ratio.Text = GlobalMessages.COMPRESSOR_RATIO;
            groupBox_Attack.Text = GlobalMessages.COMPRESSOR_ATTACK;
            label_AutoAttack.Text = GlobalMessages.COMPRESSOR_AUTOATTACK;
            groupBox_Release.Text = GlobalMessages.COMPRESSOR_RELEASE;
            label_AutoRelease.Text = GlobalMessages.COMPRESSOR_AUTORELEASE;
            groupBox_Misc.Text = GlobalMessages.COMPRESSOR_MISC;
            label_KneeMult.Text = GlobalMessages.COMPRESSOR_KNEEMULT;
            label_Crest.Text = GlobalMessages.COMPRESSOR_CRESTTIME;
            label_Adapt.Text = GlobalMessages.COMPRESSOR_ADAPTTIME;
            groupBox_MakeUpGain.Text = GlobalMessages.COMPRESSOR_MAKEUPGAIN;
            label_AutoGain.Text = GlobalMessages.COMPRESSOR_AUTOGAIN;
            UpdateUI();
        }

        private void UpdateUI()
        {
            onOffSwitch_Compressor.SwitchedOn = m_bCompressorEnabled;
            onOffSwitch_NoClip.SwitchedOn = m_bNoClip;
            onOffSwitch_AutoKnee.SwitchedOn = m_bAutoKnee;
            onOffSwitch_AutoAttack.SwitchedOn = m_bAutoAttack;
            onOffSwitch_AutoRelease.SwitchedOn = m_bAutoRelease;
            onOffSwitch_AutoGain.SwitchedOn = m_bAutoGain;
            hSlider_Threshold.Position = (uint)(m_rThreshold * 100.0);
            hSlider_Knee.Position = (uint)(m_rKneewidth * 100.0);
            hSlider_Ratio.Position = (uint)(m_rRatio * 100.0);
            hSlider_Attack.Position = (uint)(m_rAttack * 100.0);
            hSlider_Release.Position = (uint)(m_rRelease * 100.0);
            hSlider_KneeMult.Position = (uint)(m_rKneeMult * 100.0);
            hSlider_Crest.Position = (uint)(m_rCrestTime * 100.0);
            hSlider_Adapt.Position = (uint)(m_rAdaptTime * 100.0);
            hSlider_Gain.Position = (uint)(m_rMakeupGain * 100.0);
        }

        private void onOffSwitch_Compressor_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bCompressorEnabled = bSwitchedOn;
        }

        private void onOffSwitch_NoClip_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bNoClip = bSwitchedOn;
        }

        private void onOffSwitch_AutoKnee_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bAutoKnee = bSwitchedOn;
        }

        private void onOffSwitch_AutoAttack_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bAutoAttack = bSwitchedOn;
        }

        private void onOffSwitch_AutoRelease_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bAutoRelease = bSwitchedOn;
        }

        private void onOffSwitch_AutoGain_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bAutoGain = bSwitchedOn;
        }

        private void hSlider_Threshold_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rThreshold = fPercent;
            label_Threshold.Text = (20.0 * Math.Log10(Math.Pow(10.0, fPercent * -60.0 / 20.0))).ToString("F02") + "dB";
        }

        private void hSlider_Knee_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rKneewidth = fPercent;
            label_Knee.Text = (20.0 * Math.Log10(Math.Pow(10.0, fPercent * 60.0 / 20.0))).ToString("F02") + "dB";
        }

        private void hSlider_Ratio_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rRatio = fPercent;
            if (fPercent > 0.990000009536743)
            {
                label_Ratio.Text = "oo:1";
            }
            else
            {
                label_Ratio.Text = (1.0 / (1.0 - fPercent)).ToString("F02") + ":1";
            }
        }

        private void hSlider_Attack_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rAttack = fPercent;
            label_Attack.Text = (Parameters.PARAM2LOG(fPercent, 0.0001f, 0.2f) * 1000.0).ToString("F02") + "ms";
        }

        private void hSlider_Release_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rRelease = fPercent;
            label_Release.Text = (Parameters.PARAM2LOG(fPercent, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
        }

        private void hSlider_KneeMult_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rKneeMult = fPercent;
            label_KneeMultValue.Text = Parameters.PARAM2LIN(fPercent, 0.0f, 4f).ToString("F02") + "x";
        }

        private void hSlider_Crest_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rCrestTime = fPercent;
            label_CrestValue.Text = (Parameters.PARAM2LOG(fPercent, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
        }

        private void hSlider_Adapt_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rAdaptTime = fPercent;
            label_AdaptValue.Text = (Parameters.PARAM2LOG(fPercent, 1f, 4f) * 1000.0).ToString("F02") + "ms";
        }

        private void hSlider_Gain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rMakeupGain = fPercent;
            label_Gain.Text = (20.0 * Math.Log10(Math.Pow(10.0, fPercent * 60.0 / 20.0))).ToString("F02") + "dB";
        }

        private void singleButton_OK_ButtonClickNotify(SingleButton objSender)
        {
            DialogResult = DialogResult.OK;
        }

        private void singleButton_Cancel_ButtonClickNotify(SingleButton objSender)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
