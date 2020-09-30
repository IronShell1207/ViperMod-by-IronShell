// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmAbout
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.Utils;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ViPER4WindowsBin
{
    public class frmAbout : Telerik.WinControls.UI. RadForm
    {
        private readonly IContainer components;
        private Label label_ControlPanelVersion;
        private Label label_DriverVersion;
        private Label label_CodeName;
        private Label label_LanVersion;
        private Label label_LanTranslator;
        private Label label_Copyright;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Label label_SupportForum;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.label_ControlPanelVersion = new System.Windows.Forms.Label();
            this.label_DriverVersion = new System.Windows.Forms.Label();
            this.label_CodeName = new System.Windows.Forms.Label();
            this.label_LanVersion = new System.Windows.Forms.Label();
            this.label_LanTranslator = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.label_SupportForum = new System.Windows.Forms.Label();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ControlPanelVersion
            // 
            this.label_ControlPanelVersion.AutoSize = true;
            this.label_ControlPanelVersion.ForeColor = System.Drawing.Color.Snow;
            this.label_ControlPanelVersion.Location = new System.Drawing.Point(12, 20);
            this.label_ControlPanelVersion.Name = "label_ControlPanelVersion";
            this.label_ControlPanelVersion.Size = new System.Drawing.Size(146, 13);
            this.label_ControlPanelVersion.TabIndex = 0;
            this.label_ControlPanelVersion.Text = "$CONTROLPANEL_VERSION";
            // 
            // label_DriverVersion
            // 
            this.label_DriverVersion.AutoSize = true;
            this.label_DriverVersion.ForeColor = System.Drawing.Color.Snow;
            this.label_DriverVersion.Location = new System.Drawing.Point(12, 43);
            this.label_DriverVersion.Name = "label_DriverVersion";
            this.label_DriverVersion.Size = new System.Drawing.Size(102, 13);
            this.label_DriverVersion.TabIndex = 1;
            this.label_DriverVersion.Text = "$DRIVER_VERSION";
            // 
            // label_CodeName
            // 
            this.label_CodeName.AutoSize = true;
            this.label_CodeName.ForeColor = System.Drawing.Color.Snow;
            this.label_CodeName.Location = new System.Drawing.Point(12, 67);
            this.label_CodeName.Name = "label_CodeName";
            this.label_CodeName.Size = new System.Drawing.Size(79, 13);
            this.label_CodeName.TabIndex = 2;
            this.label_CodeName.Text = "$CODE_NAME";
            // 
            // label_LanVersion
            // 
            this.label_LanVersion.AutoSize = true;
            this.label_LanVersion.ForeColor = System.Drawing.Color.Snow;
            this.label_LanVersion.Location = new System.Drawing.Point(12, 91);
            this.label_LanVersion.Name = "label_LanVersion";
            this.label_LanVersion.Size = new System.Drawing.Size(121, 13);
            this.label_LanVersion.TabIndex = 3;
            this.label_LanVersion.Text = "$LANGUAGE_VERSION";
            // 
            // label_LanTranslator
            // 
            this.label_LanTranslator.AutoSize = true;
            this.label_LanTranslator.ForeColor = System.Drawing.Color.Snow;
            this.label_LanTranslator.Location = new System.Drawing.Point(12, 115);
            this.label_LanTranslator.Name = "label_LanTranslator";
            this.label_LanTranslator.Size = new System.Drawing.Size(141, 13);
            this.label_LanTranslator.TabIndex = 4;
            this.label_LanTranslator.Text = "$LANGUAGE_TRANSLATOR";
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.ForeColor = System.Drawing.Color.Snow;
            this.label_Copyright.Location = new System.Drawing.Point(12, 152);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(72, 13);
            this.label_Copyright.TabIndex = 5;
            this.label_Copyright.Text = "$COPYRIGHT";
            // 
            // label_SupportForum
            // 
            this.label_SupportForum.AutoSize = true;
            this.label_SupportForum.ForeColor = System.Drawing.Color.Snow;
            this.label_SupportForum.Location = new System.Drawing.Point(12, 176);
            this.label_SupportForum.Name = "label_SupportForum";
            this.label_SupportForum.Size = new System.Drawing.Size(106, 13);
            this.label_SupportForum.TabIndex = 6;
            this.label_SupportForum.Text = "$SUPPORT_FORUM";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 206);
            this.Controls.Add(this.label_SupportForum);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.label_LanTranslator);
            this.Controls.Add(this.label_LanVersion);
            this.Controls.Add(this.label_CodeName);
            this.Controls.Add(this.label_DriverVersion);
            this.Controls.Add(this.label_ControlPanelVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$ABOUT";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public frmAbout()
        {
            InitializeComponent();
            Text = GlobalMessages.ABOUT;
            label_ControlPanelVersion.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : " + "1.0.8" ;//менял версию тут
            label_DriverVersion.Text = GlobalMessages.DRIVER_VERSION + " : " + RuntimeUtils.EffectDriver.GetVersion();
            label_CodeName.Text = GlobalMessages.CODE_NAME + " : " + RuntimeUtils.EffectDriver.GetCodeName();
            label_LanVersion.Text = GlobalMessages.LANGUAGE_VERSION + " : " + GlobalMessages.LANGUAGE_VERSION_STR;
            label_LanTranslator.Text = GlobalMessages.LANGUAGE_TRANSLATOR + " : " + GlobalMessages.LANGUAGE_TRANSLATOR_STR;
            label_Copyright.Text = GlobalMessages.COPYRIGHT;
            label_SupportForum.Text = @"Website https://droidapps.cf";
        }

        private void frmAbout_Load(object sender, System.EventArgs e)
        {

        }
    }
}
