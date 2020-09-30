// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmEqualizer
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
    public class frmEqualizer : Telerik.WinControls.UI.RadForm
    {
        private readonly float[] m_faEQBands = new float[18];
        private readonly List<VSlider> m_ctlEQBandList = new List<VSlider>();
        private readonly IContainer components;
        private Label label_Equalizer_Enable;
        private OnOffSwitch onOffSwitch_Equalizer;
        private VSlider vSlider1;
        private VSlider vSlider2;
        private VSlider vSlider3;
        private VSlider vSlider4;
        private VSlider vSlider5;
        private VSlider vSlider6;
        private VSlider vSlider7;
        private VSlider vSlider8;
        private VSlider vSlider9;
        private VSlider vSlider10;
        private VSlider vSlider11;
        private VSlider vSlider12;
        private VSlider vSlider13;
        private VSlider vSlider14;
        private VSlider vSlider15;
        private VSlider vSlider16;
        private VSlider vSlider17;
        private VSlider vSlider18;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label_dB_Max;
        private Label label_dB_Min;
        private Label label_dB_Zero;
        private CheckBox checkBox_RealtimeAdjust;
        private bool m_bEQEnabled;
        private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramBaseSystem;
        private RuntimeUtils.ConfigProxy._ParamOfMusicMode m_paramMusicMode;
        private RuntimeUtils.ConfigProxy._ParamOfMovieMode m_paramMovieMode;
        private RuntimeUtils.ConfigProxy._ParamOfFreestyle m_paramFreestyle;
        private Telerik.WinControls.UI.RadButton singleButton_Preset;
        private Telerik.WinControls.UI.RadButton singleButton_OK;
        private RuntimeUtils.ConfigProxy m_cpConfigProxy;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEqualizer));
            this.label_Equalizer_Enable = new System.Windows.Forms.Label();
            this.onOffSwitch_Equalizer = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.vSlider1 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider2 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider3 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider4 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider5 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider6 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider7 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider8 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider9 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider10 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider11 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider12 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider13 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider14 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider15 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider16 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider17 = new ViPER4WindowsBin.UIControls.VSlider();
            this.vSlider18 = new ViPER4WindowsBin.UIControls.VSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_dB_Max = new System.Windows.Forms.Label();
            this.label_dB_Min = new System.Windows.Forms.Label();
            this.label_dB_Zero = new System.Windows.Forms.Label();
            this.checkBox_RealtimeAdjust = new System.Windows.Forms.CheckBox();
            this.singleButton_Preset = new Telerik.WinControls.UI.RadButton();
            this.singleButton_OK = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Preset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Equalizer_Enable
            // 
            this.label_Equalizer_Enable.AutoSize = true;
            this.label_Equalizer_Enable.ForeColor = System.Drawing.Color.Snow;
            this.label_Equalizer_Enable.Location = new System.Drawing.Point(24, 22);
            this.label_Equalizer_Enable.Name = "label_Equalizer_Enable";
            this.label_Equalizer_Enable.Size = new System.Drawing.Size(51, 13);
            this.label_Equalizer_Enable.TabIndex = 0;
            this.label_Equalizer_Enable.Text = "$ENABLE";
            // 
            // onOffSwitch_Equalizer
            // 
            this.onOffSwitch_Equalizer.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_Equalizer.ForeColor = System.Drawing.Color.Snow;
            this.onOffSwitch_Equalizer.Location = new System.Drawing.Point(24, 37);
            this.onOffSwitch_Equalizer.Name = "onOffSwitch_Equalizer";
            this.onOffSwitch_Equalizer.Size = new System.Drawing.Size(107, 28);
            this.onOffSwitch_Equalizer.SwitchedOn = false;
            this.onOffSwitch_Equalizer.TabIndex = 1;
            // 
            // vSlider1
            // 
            this.vSlider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider1.Location = new System.Drawing.Point(53, 83);
            this.vSlider1.MoveDelta = ((uint)(1u));
            this.vSlider1.Name = "vSlider1";
            this.vSlider1.Position = ((uint)(50u));
            this.vSlider1.Size = new System.Drawing.Size(47, 204);
            this.vSlider1.TabIndex = 2;
            // 
            // vSlider2
            // 
            this.vSlider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider2.Location = new System.Drawing.Point(106, 83);
            this.vSlider2.MoveDelta = ((uint)(1u));
            this.vSlider2.Name = "vSlider2";
            this.vSlider2.Position = ((uint)(50u));
            this.vSlider2.Size = new System.Drawing.Size(47, 204);
            this.vSlider2.TabIndex = 3;
            // 
            // vSlider3
            // 
            this.vSlider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider3.Location = new System.Drawing.Point(159, 83);
            this.vSlider3.MoveDelta = ((uint)(1u));
            this.vSlider3.Name = "vSlider3";
            this.vSlider3.Position = ((uint)(50u));
            this.vSlider3.Size = new System.Drawing.Size(47, 204);
            this.vSlider3.TabIndex = 4;
            // 
            // vSlider4
            // 
            this.vSlider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider4.Location = new System.Drawing.Point(212, 83);
            this.vSlider4.MoveDelta = ((uint)(1u));
            this.vSlider4.Name = "vSlider4";
            this.vSlider4.Position = ((uint)(50u));
            this.vSlider4.Size = new System.Drawing.Size(47, 204);
            this.vSlider4.TabIndex = 5;
            // 
            // vSlider5
            // 
            this.vSlider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider5.Location = new System.Drawing.Point(265, 83);
            this.vSlider5.MoveDelta = ((uint)(1u));
            this.vSlider5.Name = "vSlider5";
            this.vSlider5.Position = ((uint)(50u));
            this.vSlider5.Size = new System.Drawing.Size(47, 204);
            this.vSlider5.TabIndex = 6;
            // 
            // vSlider6
            // 
            this.vSlider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider6.Location = new System.Drawing.Point(318, 83);
            this.vSlider6.MoveDelta = ((uint)(1u));
            this.vSlider6.Name = "vSlider6";
            this.vSlider6.Position = ((uint)(50u));
            this.vSlider6.Size = new System.Drawing.Size(47, 204);
            this.vSlider6.TabIndex = 7;
            // 
            // vSlider7
            // 
            this.vSlider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider7.Location = new System.Drawing.Point(371, 83);
            this.vSlider7.MoveDelta = ((uint)(1u));
            this.vSlider7.Name = "vSlider7";
            this.vSlider7.Position = ((uint)(50u));
            this.vSlider7.Size = new System.Drawing.Size(47, 204);
            this.vSlider7.TabIndex = 8;
            // 
            // vSlider8
            // 
            this.vSlider8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider8.Location = new System.Drawing.Point(424, 83);
            this.vSlider8.MoveDelta = ((uint)(1u));
            this.vSlider8.Name = "vSlider8";
            this.vSlider8.Position = ((uint)(50u));
            this.vSlider8.Size = new System.Drawing.Size(47, 204);
            this.vSlider8.TabIndex = 9;
            // 
            // vSlider9
            // 
            this.vSlider9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider9.Location = new System.Drawing.Point(477, 83);
            this.vSlider9.MoveDelta = ((uint)(1u));
            this.vSlider9.Name = "vSlider9";
            this.vSlider9.Position = ((uint)(50u));
            this.vSlider9.Size = new System.Drawing.Size(47, 204);
            this.vSlider9.TabIndex = 10;
            // 
            // vSlider10
            // 
            this.vSlider10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider10.Location = new System.Drawing.Point(530, 83);
            this.vSlider10.MoveDelta = ((uint)(1u));
            this.vSlider10.Name = "vSlider10";
            this.vSlider10.Position = ((uint)(50u));
            this.vSlider10.Size = new System.Drawing.Size(47, 204);
            this.vSlider10.TabIndex = 11;
            // 
            // vSlider11
            // 
            this.vSlider11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider11.Location = new System.Drawing.Point(583, 83);
            this.vSlider11.MoveDelta = ((uint)(1u));
            this.vSlider11.Name = "vSlider11";
            this.vSlider11.Position = ((uint)(50u));
            this.vSlider11.Size = new System.Drawing.Size(47, 204);
            this.vSlider11.TabIndex = 12;
            // 
            // vSlider12
            // 
            this.vSlider12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider12.Location = new System.Drawing.Point(636, 83);
            this.vSlider12.MoveDelta = ((uint)(1u));
            this.vSlider12.Name = "vSlider12";
            this.vSlider12.Position = ((uint)(50u));
            this.vSlider12.Size = new System.Drawing.Size(47, 204);
            this.vSlider12.TabIndex = 13;
            // 
            // vSlider13
            // 
            this.vSlider13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider13.Location = new System.Drawing.Point(689, 83);
            this.vSlider13.MoveDelta = ((uint)(1u));
            this.vSlider13.Name = "vSlider13";
            this.vSlider13.Position = ((uint)(50u));
            this.vSlider13.Size = new System.Drawing.Size(47, 204);
            this.vSlider13.TabIndex = 14;
            // 
            // vSlider14
            // 
            this.vSlider14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider14.Location = new System.Drawing.Point(742, 83);
            this.vSlider14.MoveDelta = ((uint)(1u));
            this.vSlider14.Name = "vSlider14";
            this.vSlider14.Position = ((uint)(50u));
            this.vSlider14.Size = new System.Drawing.Size(47, 204);
            this.vSlider14.TabIndex = 15;
            // 
            // vSlider15
            // 
            this.vSlider15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider15.Location = new System.Drawing.Point(795, 83);
            this.vSlider15.MoveDelta = ((uint)(1u));
            this.vSlider15.Name = "vSlider15";
            this.vSlider15.Position = ((uint)(50u));
            this.vSlider15.Size = new System.Drawing.Size(47, 204);
            this.vSlider15.TabIndex = 16;
            // 
            // vSlider16
            // 
            this.vSlider16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider16.Location = new System.Drawing.Point(848, 83);
            this.vSlider16.MoveDelta = ((uint)(1u));
            this.vSlider16.Name = "vSlider16";
            this.vSlider16.Position = ((uint)(50u));
            this.vSlider16.Size = new System.Drawing.Size(47, 204);
            this.vSlider16.TabIndex = 17;
            // 
            // vSlider17
            // 
            this.vSlider17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider17.Location = new System.Drawing.Point(901, 83);
            this.vSlider17.MoveDelta = ((uint)(1u));
            this.vSlider17.Name = "vSlider17";
            this.vSlider17.Position = ((uint)(50u));
            this.vSlider17.Size = new System.Drawing.Size(47, 204);
            this.vSlider17.TabIndex = 18;
            // 
            // vSlider18
            // 
            this.vSlider18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.vSlider18.Location = new System.Drawing.Point(954, 83);
            this.vSlider18.MoveDelta = ((uint)(1u));
            this.vSlider18.Name = "vSlider18";
            this.vSlider18.Position = ((uint)(50u));
            this.vSlider18.Size = new System.Drawing.Size(47, 204);
            this.vSlider18.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(69, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "65";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(121, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "93";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(173, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "131";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(225, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "185";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(279, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "262";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(332, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "370";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(384, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "523";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(437, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "740";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(487, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "1.0k";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(540, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "1.5k";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(593, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "2.1k";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(646, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "3.0k";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(699, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "4.2k";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Snow;
            this.label14.Location = new System.Drawing.Point(752, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "6.0k";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(806, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "8.4k";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Snow;
            this.label16.Location = new System.Drawing.Point(857, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "11.8k";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Snow;
            this.label17.Location = new System.Drawing.Point(910, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "16.7k";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Snow;
            this.label18.Location = new System.Drawing.Point(967, 290);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "20k";
            // 
            // label_dB_Max
            // 
            this.label_dB_Max.AutoSize = true;
            this.label_dB_Max.ForeColor = System.Drawing.Color.Snow;
            this.label_dB_Max.Location = new System.Drawing.Point(12, 101);
            this.label_dB_Max.Name = "label_dB_Max";
            this.label_dB_Max.Size = new System.Drawing.Size(32, 13);
            this.label_dB_Max.TabIndex = 41;
            this.label_dB_Max.Text = "13dB";
            // 
            // label_dB_Min
            // 
            this.label_dB_Min.AutoSize = true;
            this.label_dB_Min.ForeColor = System.Drawing.Color.Snow;
            this.label_dB_Min.Location = new System.Drawing.Point(12, 256);
            this.label_dB_Min.Name = "label_dB_Min";
            this.label_dB_Min.Size = new System.Drawing.Size(42, 13);
            this.label_dB_Min.TabIndex = 42;
            this.label_dB_Min.Text = "-120dB";
            // 
            // label_dB_Zero
            // 
            this.label_dB_Zero.AutoSize = true;
            this.label_dB_Zero.ForeColor = System.Drawing.Color.Snow;
            this.label_dB_Zero.Location = new System.Drawing.Point(12, 179);
            this.label_dB_Zero.Name = "label_dB_Zero";
            this.label_dB_Zero.Size = new System.Drawing.Size(26, 13);
            this.label_dB_Zero.TabIndex = 43;
            this.label_dB_Zero.Text = "0dB";
            // 
            // checkBox_RealtimeAdjust
            // 
            this.checkBox_RealtimeAdjust.AutoSize = true;
            this.checkBox_RealtimeAdjust.ForeColor = System.Drawing.Color.Snow;
            this.checkBox_RealtimeAdjust.Location = new System.Drawing.Point(386, 37);
            this.checkBox_RealtimeAdjust.Name = "checkBox_RealtimeAdjust";
            this.checkBox_RealtimeAdjust.Size = new System.Drawing.Size(186, 17);
            this.checkBox_RealtimeAdjust.TabIndex = 44;
            this.checkBox_RealtimeAdjust.Text = "$EQUALIZER_REALTIME_ADJUST";
            this.checkBox_RealtimeAdjust.UseVisualStyleBackColor = true;
            this.checkBox_RealtimeAdjust.CheckedChanged += new System.EventHandler(this.checkBox_RealtimeAdjust_CheckedChanged);
            // 
            // singleButton_Preset
            // 
            this.singleButton_Preset.Location = new System.Drawing.Point(176, 22);
            this.singleButton_Preset.Name = "singleButton_Preset";
            this.singleButton_Preset.Size = new System.Drawing.Size(136, 42);
            this.singleButton_Preset.TabIndex = 45;
            this.singleButton_Preset.Text = "$PRESET";
            this.singleButton_Preset.ThemeName = "VisualStudio2012Dark";
            this.singleButton_Preset.Click += new System.EventHandler(this.singleButton_Load_Click);
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(836, 22);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(136, 42);
            this.singleButton_OK.TabIndex = 46;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "VisualStudio2012Dark";
            // 
            // frmEqualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 324);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Preset);
            this.Controls.Add(this.checkBox_RealtimeAdjust);
            this.Controls.Add(this.label_dB_Zero);
            this.Controls.Add(this.label_dB_Min);
            this.Controls.Add(this.label_dB_Max);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vSlider18);
            this.Controls.Add(this.vSlider17);
            this.Controls.Add(this.vSlider16);
            this.Controls.Add(this.vSlider15);
            this.Controls.Add(this.vSlider14);
            this.Controls.Add(this.vSlider13);
            this.Controls.Add(this.vSlider12);
            this.Controls.Add(this.vSlider11);
            this.Controls.Add(this.vSlider10);
            this.Controls.Add(this.vSlider9);
            this.Controls.Add(this.vSlider8);
            this.Controls.Add(this.vSlider7);
            this.Controls.Add(this.vSlider6);
            this.Controls.Add(this.vSlider5);
            this.Controls.Add(this.vSlider4);
            this.Controls.Add(this.vSlider3);
            this.Controls.Add(this.vSlider2);
            this.Controls.Add(this.vSlider1);
            this.Controls.Add(this.onOffSwitch_Equalizer);
            this.Controls.Add(this.label_Equalizer_Enable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEqualizer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$EQUALIZER";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Preset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void SetRealtimeParameters(
          RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem,
          RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode,
          RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode,
          RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle,
          RuntimeUtils.ConfigProxy cpConfigProxy)
        {
            m_paramBaseSystem = paramBaseSystem;
            m_paramMusicMode = paramMusicMode;
            m_paramMovieMode = paramMovieMode;
            m_paramFreestyle = paramFreestyle;
            m_cpConfigProxy = cpConfigProxy;
        }

        public frmEqualizer()
        {
            InitializeComponent();
            Text = GlobalMessages.EQUALIZER;
            label_Equalizer_Enable.Text = GlobalMessages.ENABLE;
            checkBox_RealtimeAdjust.Text = GlobalMessages.EQUALIZER_REALTIME_ADJUST;
            singleButton_Preset.Text = GlobalMessages.PRESET;
            singleButton_OK.Text = GlobalMessages.OK;
            m_ctlEQBandList.Add(vSlider1);
            m_ctlEQBandList.Add(vSlider2);
            m_ctlEQBandList.Add(vSlider3);
            m_ctlEQBandList.Add(vSlider4);
            m_ctlEQBandList.Add(vSlider5);
            m_ctlEQBandList.Add(vSlider6);
            m_ctlEQBandList.Add(vSlider7);
            m_ctlEQBandList.Add(vSlider8);
            m_ctlEQBandList.Add(vSlider9);
            m_ctlEQBandList.Add(vSlider10);
            m_ctlEQBandList.Add(vSlider11);
            m_ctlEQBandList.Add(vSlider12);
            m_ctlEQBandList.Add(vSlider13);
            m_ctlEQBandList.Add(vSlider14);
            m_ctlEQBandList.Add(vSlider15);
            m_ctlEQBandList.Add(vSlider16);
            m_ctlEQBandList.Add(vSlider17);
            m_ctlEQBandList.Add(vSlider18);
            for (int index = 0; index < m_ctlEQBandList.Count; ++index)
            {
                m_ctlEQBandList[index].Tag = index.ToString();
            }

            for (int index = 0; index < m_faEQBands.Length; ++index)
            {
                m_faEQBands[index] = 1f;
            }

            m_bEQEnabled = false;
            UpdateUI();
            foreach (VSlider ctlEqBand in m_ctlEQBandList)
            {
                ctlEqBand.PositionChangeNotify += new VSlider.PositionChangeEventDelegate(EQBandChanged);
            }

            onOffSwitch_Equalizer.SwitchChangeNotify += new OnOffSwitch.SwitchChangeEventDelegate(EQSwitchChange);
        }

        private void UpdateUI()
        {
            onOffSwitch_Equalizer.SwitchedOn = m_bEQEnabled;
            for (int index = 0; index < m_faEQBands.Length; ++index)
            {
                float faEqBand = m_faEQBands[index];
                uint num = (uint)((faEqBand > 1.0 ? (faEqBand - 1f) / 4f * 0.5f + 0.5f : faEqBand * 0.5f) * 100.0);
                if (num > 100U)
                {
                    num = 100U;
                }

                m_ctlEQBandList[index].Position = num;
            }
        }

        private void EQBandChanged(float fPercent, VSlider objSender)
        {
            if (objSender == null || objSender.Tag == null || !(objSender.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result >= m_faEQBands.Length)
            {
                return;
            }

            float num = fPercent >= 0.5 ? (float)((fPercent - 0.5) / 0.5 * 4.0 + 1.0) : fPercent / 0.5f;
            m_faEQBands[result] = num;
            if (!checkBox_RealtimeAdjust.Checked)
            {
                return;
            }

            if (m_paramBaseSystem.m_nEffectMode == 0U)
            {
                m_paramMusicMode.m_rpEqualizerBands[result] = num;
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode == 1U)
            {
                m_paramMovieMode.m_rpEqualizerBands[result] = num;
                m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode != 2U)
            {
                return;
            }

            m_paramFreestyle.m_rpEqualizerBands[result] = num;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void EQSwitchChange(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bEQEnabled = bSwitchedOn;
            if (!checkBox_RealtimeAdjust.Checked)
            {
                return;
            }

            if (m_paramBaseSystem.m_nEffectMode == 0U)
            {
                m_paramMusicMode.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode == 1U)
            {
                m_paramMovieMode.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
                m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode != 2U)
            {
                return;
            }

            m_paramFreestyle.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        public void SetParameters(float[] faEQBands, bool bEQEnabled)
        {
            if (faEQBands == null || faEQBands.Length != m_faEQBands.Length)
            {
                return;
            }

            Array.Copy(faEQBands, m_faEQBands, m_faEQBands.Length);
            m_bEQEnabled = bEQEnabled;
            UpdateUI();
        }

        public float[] GetParameter()
        {
            return m_faEQBands;
        }

        public bool GetEQEnabled()
        {
            return m_bEQEnabled;
        }

        private void singleButton_OK_ButtonClickNotify(SingleButton objSender)
        {
            DialogResult = DialogResult.OK;
        }

        private void singleButton_Preset_ButtonClickNotify(SingleButton objSender)
        {
           
        }

        private void checkBox_RealtimeAdjust_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_RealtimeAdjust.Checked)
            {
                return;
            }

            if (m_paramBaseSystem.m_nEffectMode == 0U)
            {
                m_paramMusicMode.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
                Array.Copy(m_faEQBands, m_paramMusicMode.m_rpEqualizerBands, m_faEQBands.Length);
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode == 1U)
            {
                m_paramMovieMode.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
                Array.Copy(m_faEQBands, m_paramMovieMode.m_rpEqualizerBands, m_faEQBands.Length);
                m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
                m_cpConfigProxy.SyncConfig();
            }
            if (m_paramBaseSystem.m_nEffectMode != 2U)
            {
                return;
            }

            m_paramFreestyle.m_bEqualizerEnabled = !m_bEQEnabled ? 0 : 1;
            Array.Copy(m_faEQBands, m_paramFreestyle.m_rpEqualizerBands, m_faEQBands.Length);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void singleButton_Load_Click(object sender, EventArgs e)
        {
            frmEQPreset frmEqPreset = new frmEQPreset();
            frmEqPreset.SetPreset(m_faEQBands);
            if (frmEqPreset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            float[] preset = frmEqPreset.GetPreset();
            if (preset == null || preset.Length != m_faEQBands.Length)
            {
                return;
            }

            Array.Copy(preset, m_faEQBands, m_faEQBands.Length);
            if (checkBox_RealtimeAdjust.Checked)
            {
                if (m_paramBaseSystem.m_nEffectMode == 0U)
                {
                    Array.Copy(m_faEQBands, m_paramMusicMode.m_rpEqualizerBands, m_faEQBands.Length);
                    m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                    m_cpConfigProxy.SyncConfig();
                }
                if (m_paramBaseSystem.m_nEffectMode == 1U)
                {
                    Array.Copy(m_faEQBands, m_paramMovieMode.m_rpEqualizerBands, m_faEQBands.Length);
                    m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
                    m_cpConfigProxy.SyncConfig();
                }
                if (m_paramBaseSystem.m_nEffectMode == 2U)
                {
                    Array.Copy(m_faEQBands, m_paramFreestyle.m_rpEqualizerBands, m_faEQBands.Length);
                    m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
                    m_cpConfigProxy.SyncConfig();
                }
            }
            UpdateUI();
        }
    }
}
