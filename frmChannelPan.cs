// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmChannelPan
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
    public class frmChannelPan : Telerik.WinControls.UI.RadForm
    {
        private float m_rChannelPan;
        private readonly IContainer components;
        private Label label_Left;
        private Label label_Right;
        private HSlider hSlider_Pan;
        private Telerik.WinControls.UI.RadButton singleButton_Center;
        private Label label_Value;

        public float ChannelPan
        {
            get => m_rChannelPan;
            set
            {
                m_rChannelPan = value;
                hSlider_Pan.PositionFloat = (float)(m_rChannelPan * 0.5 + 0.5);
            }
        }

        public frmChannelPan()
        {
            InitializeComponent();
            Text = GlobalMessages.CHANNEL_PAN;
            label_Left.Text = GlobalMessages.LEFT;
            label_Right.Text = GlobalMessages.RIGHT;
            singleButton_Center.Text = GlobalMessages.BALANCE;
        }

        private void hSlider_Pan_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_rChannelPan = (float)((fPercent - 0.5) * 2.0);
            label_Value.Text = m_rChannelPan.ToString("F01");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChannelPan));
            this.label_Left = new System.Windows.Forms.Label();
            this.label_Right = new System.Windows.Forms.Label();
            this.hSlider_Pan = new ViPER4WindowsBin.UIControls.HSlider();
            this.label_Value = new System.Windows.Forms.Label();
            this.singleButton_Center = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.ForeColor = System.Drawing.Color.Snow;
            this.label_Left.Location = new System.Drawing.Point(48, 10);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(36, 13);
            this.label_Left.TabIndex = 0;
            this.label_Left.Text = "$LEFT";
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.ForeColor = System.Drawing.Color.Snow;
            this.label_Right.Location = new System.Drawing.Point(386, 10);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(45, 13);
            this.label_Right.TabIndex = 1;
            this.label_Right.Text = "$RIGHT";
            // 
            // hSlider_Pan
            // 
            this.hSlider_Pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hSlider_Pan.ForeColor = System.Drawing.Color.Snow;
            this.hSlider_Pan.Location = new System.Drawing.Point(24, 31);
            this.hSlider_Pan.MoveDelta = ((uint)(1u));
            this.hSlider_Pan.Name = "hSlider_Pan";
            this.hSlider_Pan.Position = ((uint)(50u));
            this.hSlider_Pan.PositionFloat = 0.5F;
            this.hSlider_Pan.Size = new System.Drawing.Size(403, 51);
            this.hSlider_Pan.TabIndex = 2;
            this.hSlider_Pan.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Pan_PositionChangeNotify);
            // 
            // label_Value
            // 
            this.label_Value.ForeColor = System.Drawing.Color.Snow;
            this.label_Value.Location = new System.Drawing.Point(170, 10);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(114, 18);
            this.label_Value.TabIndex = 4;
            this.label_Value.Text = "0.0";
            this.label_Value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // singleButton_Center
            // 
            this.singleButton_Center.Location = new System.Drawing.Point(162, 88);
            this.singleButton_Center.Name = "singleButton_Center";
            this.singleButton_Center.Size = new System.Drawing.Size(130, 32);
            this.singleButton_Center.TabIndex = 25;
            this.singleButton_Center.Text = "$BALANCE";
            this.singleButton_Center.ThemeName = "VisualStudio2012Dark";
            this.singleButton_Center.Click += new System.EventHandler(this.singleButton_Center1_Click);
            // 
            // frmChannelPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 137);
            this.Controls.Add(this.singleButton_Center);
            this.Controls.Add(this.label_Value);
            this.Controls.Add(this.hSlider_Pan);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChannelPan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$CHANNEL_PAN";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.frmChannelPan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void singleButton_Center1_Click(object sender, System.EventArgs e)
        {
            m_rChannelPan = 0.0f;
            hSlider_Pan.Position = 50U;
        }

        private void frmChannelPan_Load(object sender, System.EventArgs e)
        {

        }
    }
}
