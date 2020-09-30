// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmLatency
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
    public class frmLatency : Telerik.WinControls.UI.RadForm
    {
        private int m_iShortLen = 4096;
        private readonly IContainer components;
        private Label label_CurrentLatency;
        private Label label_DesiredLatency;
        private ButtonBox buttonBox_Latency;
        private Label label_LowLatencyNote;
        private int m_iMiddleLen;
        private Telerik.WinControls.UI.RadButton singleButton_OK;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;
        private int m_iLongLen;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLatency));
            this.label_CurrentLatency = new System.Windows.Forms.Label();
            this.label_DesiredLatency = new System.Windows.Forms.Label();
            this.buttonBox_Latency = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.label_LowLatencyNote = new System.Windows.Forms.Label();
            this.singleButton_OK = new Telerik.WinControls.UI.RadButton();
            this.singleButton_Cancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CurrentLatency
            // 
            this.label_CurrentLatency.AutoSize = true;
            this.label_CurrentLatency.ForeColor = System.Drawing.Color.Snow;
            this.label_CurrentLatency.Location = new System.Drawing.Point(12, 10);
            this.label_CurrentLatency.Name = "label_CurrentLatency";
            this.label_CurrentLatency.Size = new System.Drawing.Size(139, 13);
            this.label_CurrentLatency.TabIndex = 0;
            this.label_CurrentLatency.Text = "$CURRENT_LATENCY : 0ms";
            // 
            // label_DesiredLatency
            // 
            this.label_DesiredLatency.AutoSize = true;
            this.label_DesiredLatency.ForeColor = System.Drawing.Color.Snow;
            this.label_DesiredLatency.Location = new System.Drawing.Point(12, 44);
            this.label_DesiredLatency.Name = "label_DesiredLatency";
            this.label_DesiredLatency.Size = new System.Drawing.Size(105, 13);
            this.label_DesiredLatency.TabIndex = 1;
            this.label_DesiredLatency.Text = "$DESIRED_LATENCY";
            // 
            // buttonBox_Latency
            // 
            this.buttonBox_Latency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonBox_Latency.Location = new System.Drawing.Point(12, 80);
            this.buttonBox_Latency.Name = "buttonBox_Latency";
            this.buttonBox_Latency.Size = new System.Drawing.Size(137, 206);
            this.buttonBox_Latency.TabIndex = 2;
            this.buttonBox_Latency.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_Latency_ItemSelectedNotify);
            // 
            // label_LowLatencyNote
            // 
            this.label_LowLatencyNote.AutoSize = true;
            this.label_LowLatencyNote.ForeColor = System.Drawing.Color.Red;
            this.label_LowLatencyNote.Location = new System.Drawing.Point(12, 64);
            this.label_LowLatencyNote.Name = "label_LowLatencyNote";
            this.label_LowLatencyNote.Size = new System.Drawing.Size(120, 13);
            this.label_LowLatencyNote.TabIndex = 3;
            this.label_LowLatencyNote.Text = "$LOW_LATENCY_NOTE";
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(155, 204);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(93, 32);
            this.singleButton_OK.TabIndex = 31;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(155, 242);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 32;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // frmLatency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 302);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.label_LowLatencyNote);
            this.Controls.Add(this.buttonBox_Latency);
            this.Controls.Add(this.label_DesiredLatency);
            this.Controls.Add(this.label_CurrentLatency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLatency";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$LATENCY_SETTING";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public int ShortFilterLen
        {
            get => m_iShortLen;
            set
            {
                m_iShortLen = value;
                UpdateUI();
            }
        }

        public int MiddleFilterLen
        {
            get => m_iMiddleLen;
            set
            {
                m_iMiddleLen = value;
                UpdateUI();
            }
        }

        public int LongFilterLen
        {
            get => m_iLongLen;
            set
            {
                m_iLongLen = value;
                UpdateUI();
            }
        }

        public frmLatency()
        {
            InitializeComponent();
            Text = GlobalMessages.LATENCY_SETTING;
            label_CurrentLatency.Text = GlobalMessages.CURRENT_LATENCY + " : " + (GetLatency() * 1000f).ToString("F04") + " ms";
            label_DesiredLatency.Text = GlobalMessages.DESIRED_LATENCY;
            label_LowLatencyNote.Text = GlobalMessages.LOW_LATENCY_NOTE;
            singleButton_OK.Text = GlobalMessages.OK;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(16384) * 1000f).ToString("F04") + " ms", "16384"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(8192) * 1000f).ToString("F04") + " ms", "8192"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(4096) * 1000f).ToString("F04") + " ms", "4096"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(2048) * 1000f).ToString("F04") + " ms", "2048"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(1024) * 1000f).ToString("F04") + " ms", "1024"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(512) * 1000f).ToString("F04") + " ms", "512"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(256) * 1000f).ToString("F04") + " ms", "256"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(128) * 1000f).ToString("F04") + " ms", "128"));
            buttonBox_Latency.AddItem(new ButtonBox.Item((GetLatency(64) * 1000f).ToString("F04") + " ms", "64"));
        }

        private float GetLatency()
        {
            return m_iShortLen / 44100f;
        }

        private float GetLatency(int nLength)
        {
            return nLength / 44100f;
        }

        private void UpdateUI()
        {
            label_CurrentLatency.Text = GlobalMessages.CURRENT_LATENCY + " : " + (GetLatency() * 1000f).ToString("F04") + " ms";
        }

        private void buttonBox_Latency_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || (!(itCurrItem.Tag is string tag) || tag == ""))
            {
                return;
            }

            switch (tag)
            {
                case "64":
                    m_iShortLen = 64;
                    m_iMiddleLen = 2048;
                    m_iLongLen = 16384;
                    break;
                case "128":
                    m_iShortLen = 128;
                    m_iMiddleLen = 2048;
                    m_iLongLen = 8192;
                    break;
                case "256":
                    m_iShortLen = 256;
                    m_iMiddleLen = 8192;
                    m_iLongLen = 0;
                    break;
                case "512":
                    m_iShortLen = 512;
                    m_iMiddleLen = 4096;
                    m_iLongLen = 0;
                    break;
                case "1024":
                    m_iShortLen = 1024;
                    m_iMiddleLen = 2048;
                    m_iLongLen = 0;
                    break;
                case "2048":
                    m_iShortLen = 2048;
                    m_iMiddleLen = 0;
                    m_iLongLen = 0;
                    break;
                case "4096":
                    m_iShortLen = 4096;
                    m_iMiddleLen = 0;
                    m_iLongLen = 0;
                    break;
                case "8192":
                    m_iShortLen = 8192;
                    m_iMiddleLen = 0;
                    m_iLongLen = 0;
                    break;
                case "16384":
                    m_iShortLen = 16384;
                    m_iMiddleLen = 0;
                    m_iLongLen = 0;
                    break;
            }
        }

    }
}
