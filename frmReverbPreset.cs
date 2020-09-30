// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmReverbPreset
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
    public class frmReverbPreset : Telerik.WinControls.UI.RadForm
    {
        private float m_rReverbBandwidth = 1f;
        private float m_rReverbSize;
        private float m_rReverbPredelay;
        private float m_rReverbDamping;
        private float m_rReverbDensity;
        private float m_rReverbDecay;
        private float m_rReverbEarlyMix;
        private float m_rReverbMix;
        private readonly IContainer components;
        private Telerik.WinControls.UI.RadButton singleButton_Load;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;
        private ButtonBox buttonBox_Preset;

        public float ReverbSize
        {
            get => m_rReverbSize;
            set => m_rReverbSize = value;
        }

        public float ReverbPredelay
        {
            get => m_rReverbPredelay;
            set => m_rReverbPredelay = value;
        }

        public float ReverbDamping
        {
            get => m_rReverbDamping;
            set => m_rReverbDamping = value;
        }

        public float ReverbDensity
        {
            get => m_rReverbDensity;
            set => m_rReverbDensity = value;
        }

        public float ReverbBandwidth
        {
            get => m_rReverbBandwidth;
            set => m_rReverbBandwidth = value;
        }

        public float ReverbDecay
        {
            get => m_rReverbDecay;
            set => m_rReverbDecay = value;
        }

        public float ReverbEarlyMix
        {
            get => m_rReverbEarlyMix;
            set => m_rReverbEarlyMix = value;
        }

        public float ReverbMix
        {
            get => m_rReverbMix;
            set => m_rReverbMix = value;
        }

        public frmReverbPreset()
        {
            InitializeComponent();
            Text = GlobalMessages.REVERB_PRESET;
            singleButton_Load.Text = GlobalMessages.LOAD_PRESET;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_LIVINGROOM, "0"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_BATHROOM, "1"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_BATHROOM_BATHING, "2"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_BEDROOM, "3"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_THEATER, "4"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_AUDITORIUM, "5"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_UNDERGROUND_PLAZA, "6"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_UNDERGROUND_PARKING, "7"));
            buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.REVERB_PRESET_SCENE_SHOW, "8"));
            buttonBox_Preset.ItemSelectedNotify += new ButtonBox.ItemSelectDelegate(PresetSelected);
        }

        private void Apply01Preset()
        {
            m_rReverbDamping = 0.3f;
            m_rReverbDensity = 0.3f;
            m_rReverbBandwidth = 0.96f;
            m_rReverbPredelay = 0.2f;
            m_rReverbSize = 0.15f;
            m_rReverbDecay = 0.41f;
            m_rReverbMix = 0.36f;
            m_rReverbEarlyMix = 0.51f;
        }

        private void Apply02Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.8f;
            m_rReverbBandwidth = 1f;
            m_rReverbPredelay = 0.0f;
            m_rReverbSize = 0.05f;
            m_rReverbDecay = 0.26f;
            m_rReverbMix = 0.51f;
            m_rReverbEarlyMix = 0.59f;
        }

        private void Apply03Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.8f;
            m_rReverbBandwidth = 0.11f;
            m_rReverbPredelay = 0.0f;
            m_rReverbSize = 0.05f;
            m_rReverbDecay = 0.26f;
            m_rReverbMix = 0.51f;
            m_rReverbEarlyMix = 0.59f;
        }

        private void Apply04Preset()
        {
            m_rReverbDamping = 0.3f;
            m_rReverbDensity = 0.3f;
            m_rReverbBandwidth = 0.8f;
            m_rReverbPredelay = 0.14f;
            m_rReverbSize = 0.08f;
            m_rReverbDecay = 0.41f;
            m_rReverbMix = 0.29f;
            m_rReverbEarlyMix = 0.41f;
        }

        private void Apply05Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.3f;
            m_rReverbBandwidth = 0.25f;
            m_rReverbPredelay = 0.0f;
            m_rReverbSize = 0.51f;
            m_rReverbDecay = 0.06f;
            m_rReverbMix = 0.39f;
            m_rReverbEarlyMix = 0.5f;
        }

        private void Apply06Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.16f;
            m_rReverbBandwidth = 1f;
            m_rReverbPredelay = 0.37f;
            m_rReverbSize = 0.6f;
            m_rReverbDecay = 0.26f;
            m_rReverbMix = 0.51f;
            m_rReverbEarlyMix = 0.59f;
        }

        private void Apply07Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.3f;
            m_rReverbBandwidth = 0.0f;
            m_rReverbPredelay = 0.0f;
            m_rReverbSize = 1f;
            m_rReverbDecay = 0.0f;
            m_rReverbMix = 0.39f;
            m_rReverbEarlyMix = 0.5f;
        }

        private void Apply08Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.16f;
            m_rReverbBandwidth = 0.91f;
            m_rReverbPredelay = 0.18f;
            m_rReverbSize = 1f;
            m_rReverbDecay = 0.0f;
            m_rReverbMix = 0.59f;
            m_rReverbEarlyMix = 0.33f;
        }

        private void Apply09Preset()
        {
            m_rReverbDamping = 0.65f;
            m_rReverbDensity = 0.33f;
            m_rReverbBandwidth = 0.15f;
            m_rReverbPredelay = 0.0f;
            m_rReverbSize = 0.81f;
            m_rReverbDecay = 0.0f;
            m_rReverbMix = 0.4f;
            m_rReverbEarlyMix = 0.25f;
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
                    Apply01Preset();
                    break;
                case 1:
                    Apply02Preset();
                    break;
                case 2:
                    Apply03Preset();
                    break;
                case 3:
                    Apply04Preset();
                    break;
                case 4:
                    Apply05Preset();
                    break;
                case 5:
                    Apply06Preset();
                    break;
                case 6:
                    Apply07Preset();
                    break;
                case 7:
                    Apply08Preset();
                    break;
                case 8:
                    Apply09Preset();
                    break;
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReverbPreset));
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
            this.buttonBox_Preset.TabIndex = 3;
            // 
            // singleButton_Load
            // 
            this.singleButton_Load.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_Load.Location = new System.Drawing.Point(193, 12);
            this.singleButton_Load.Name = "singleButton_Load";
            this.singleButton_Load.Size = new System.Drawing.Size(89, 32);
            this.singleButton_Load.TabIndex = 29;
            this.singleButton_Load.Text = "$LOAD_PRESET";
            this.singleButton_Load.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(193, 311);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 30;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // frmReverbPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 355);
            this.Controls.Add(this.singleButton_Load);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.buttonBox_Preset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReverbPreset";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$REVERB_PRESET";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void singleButton_Load_Load(object sender, System.EventArgs e)
        {

        }
    }
}
