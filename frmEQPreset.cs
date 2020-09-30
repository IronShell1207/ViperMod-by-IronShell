// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmEQPreset
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
    public class frmEQPreset : Telerik.WinControls.UI.RadForm
    {
        private readonly float[] m_faEQPreset_Flat = new float[18]
        {
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f
        };
        private readonly float[] m_faEQPreset_SuperBass = new float[18]
        {
      3.5f,
      2.5f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f
        };
        private readonly float[] m_faEQPreset_SoftBass = new float[18]
        {
      3.5f,
      1f,
      0.5f,
      0.5f,
      0.7f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1f,
      1.1f,
      1.1f,
      1.2f,
      1.2f,
      1.3f,
      1.4f,
      1f
        };
        private readonly float[] m_faEQPreset_Rock = new float[18]
        {
      2f,
      3f,
      2f,
      0.7f,
      0.7f,
      0.8f,
      1f,
      1f,
      1f,
      1f,
      0.8f,
      0.8f,
      1.3f,
      2f,
      2f,
      1.5f,
      1f,
      1f
        };
        private readonly float[] m_faEQPreset_RandB = new float[18]
        {
      1f,
      1.5f,
      2f,
      2.2f,
      0.8f,
      0.8f,
      1f,
      1.4f,
      0.8f,
      1f,
      1.2f,
      1.4f,
      1.6f,
      2f,
      0.8f,
      1f,
      1.4f,
      1.4f
        };
        private readonly float[] m_faEQPreset_Classic = new float[18]
        {
      1f,
      1.2f,
      1.8f,
      2.2f,
      2.5f,
      3f,
      2f,
      0.8f,
      0.7f,
      0.7f,
      0.7f,
      0.7f,
      0.8f,
      1f,
      1.5f,
      1.8f,
      2f,
      2f
        };
        private readonly float[] m_faEQPreset_Pop = new float[18]
        {
      2f,
      1.8f,
      1.7f,
      1.6f,
      1.5f,
      1.4f,
      1.2f,
      0.8f,
      0.7f,
      0.6f,
      0.7f,
      0.8f,
      1f,
      1.2f,
      1.4f,
      1.6f,
      1.8f,
      1.8f
        };
        private readonly float[] m_faEQPreset_Jazz = new float[18]
        {
      1f,
      1f,
      1f,
      1f,
      1.5f,
      1.8f,
      2f,
      2f,
      2f,
      1.6f,
      1f,
      0.8f,
      0.6f,
      0.9f,
      1.2f,
      1.2f,
      1.3f,
      1.3f
        };
        private readonly float[] m_faEQPreset_Blues = new float[18]
        {
      0.7f,
      0.8f,
      0.9f,
      1f,
      1.2f,
      1.5f,
      1.2f,
      1f,
      1f,
      1f,
      0.8f,
      0.8f,
      0.8f,
      0.7f,
      0.7f,
      0.7f,
      0.65f,
      0.5f
        };
        private readonly float[] m_faEQPreset_Electronic = new float[18]
        {
      1.8f,
      1f,
      0.8f,
      0.6f,
      0.4f,
      0.4f,
      0.6f,
      0.8f,
      1f,
      1f,
      0.8f,
      0.8f,
      1.2f,
      1.4f,
      1.6f,
      1.6f,
      1.6f,
      1.6f
        };
        private readonly float[] m_faEQPreset_Vocal = new float[18]
        {
      0.8f,
      0.8f,
      0.8f,
      0.8f,
      0.8f,
      0.8f,
      1f,
      1.2f,
      1.6f,
      2f,
      2f,
      1.6f,
      1.4f,
      1.2f,
      1f,
      0.8f,
      0.6f,
      0.6f
        };
        private readonly float[] m_faEQPreset = new float[18];
        private readonly IContainer components;
        private ButtonBox buttonBox_Preset;
        private Telerik.WinControls.UI.RadButton singleButton_Load;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;

        public frmEQPreset()
        {
            InitializeComponent();
            Text = GlobalMessages.EQUALIZER_PRESET;
            singleButton_Load.Text = GlobalMessages.LOAD_PRESET;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_FLAT, "0"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_SUPERBASS, "1"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_SOFTBASS, "2"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_ROCK, "3"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_RANDB, "4"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_CLASSIC, "5"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_POP, "6"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_JAZZ, "7"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_BLUES, "8"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_ELECTRONIC, "9"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_VOCAL, "10"));
            buttonBox_Preset.ItemSelectedNotify += new ButtonBox.ItemSelectDelegate(PresetSelected);
            for (int index = 0; index < m_faEQPreset.Length; ++index)
            {
                m_faEQPreset[index] = 1f;
            }
        }

        private void PresetSelected(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem.Tag == null || !(itCurrItem.Tag is string))
            {
                return;
            }

            string tag = itCurrItem.Tag as string;
            if (tag == "")
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result))
            {
                return;
            }

            switch (result)
            {
                case 0:
                    Array.Copy(m_faEQPreset_Flat, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 1:
                    Array.Copy(m_faEQPreset_SuperBass, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 2:
                    Array.Copy(m_faEQPreset_SoftBass, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 3:
                    Array.Copy(m_faEQPreset_Rock, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 4:
                    Array.Copy(m_faEQPreset_RandB, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 5:
                    Array.Copy(m_faEQPreset_Classic, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 6:
                    Array.Copy(m_faEQPreset_Pop, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 7:
                    Array.Copy(m_faEQPreset_Jazz, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 8:
                    Array.Copy(m_faEQPreset_Blues, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 9:
                    Array.Copy(m_faEQPreset_Electronic, m_faEQPreset, m_faEQPreset.Length);
                    break;
                case 10:
                    Array.Copy(m_faEQPreset_Vocal, m_faEQPreset, m_faEQPreset.Length);
                    break;
            }
        }

        public void SetPreset(float[] faPreset)
        {
            if (faPreset == null || faPreset.Length != m_faEQPreset.Length)
            {
                return;
            }

            Array.Copy(faPreset, m_faEQPreset, m_faEQPreset.Length);
        }

        public float[] GetPreset()
        {
            return m_faEQPreset;
        }

        private void singleButton_Load_ButtonClickNotify(SingleButton objSender)
        {
            DialogResult = DialogResult.OK;
        }

        private void singleButton_Cancel_ButtonClickNotify(SingleButton objSender)
        {
            DialogResult = DialogResult.Cancel;
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEQPreset));
            this.buttonBox_Preset = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.singleButton_Load = new Telerik.WinControls.UI.RadButton();
            this.singleButton_Cancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBox_Preset
            // 
            this.buttonBox_Preset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonBox_Preset.Location = new System.Drawing.Point(12, 12);
            this.buttonBox_Preset.Name = "buttonBox_Preset";
            this.buttonBox_Preset.Size = new System.Drawing.Size(175, 331);
            this.buttonBox_Preset.TabIndex = 0;
            // 
            // singleButton_Load
            // 
            this.singleButton_Load.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_Load.Location = new System.Drawing.Point(193, 12);
            this.singleButton_Load.Name = "singleButton_Load";
            this.singleButton_Load.Size = new System.Drawing.Size(89, 32);
            this.singleButton_Load.TabIndex = 27;
            this.singleButton_Load.Text = "$LOAD_PRESET";
            this.singleButton_Load.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(193, 311);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 28;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // frmEQPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 355);
            this.Controls.Add(this.singleButton_Load);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.buttonBox_Preset);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEQPreset";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$EQUALIZER_PRESET";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
