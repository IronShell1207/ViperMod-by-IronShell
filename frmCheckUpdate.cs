// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmCheckUpdate
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
    public class frmCheckUpdate : Telerik.WinControls.UI.RadForm
    {
        private string m_szDownloadLink = "";
        private const string m_szCheckUpdateLink = "http://vipersaudio.com/swupdate/viper4windows/version.bin";
        private readonly IContainer components;
        private Label label_CodeName;
        private Label label_DriverVersion;
        private Label label_ControlPanelVersion;
        private GroupBox groupBox_VersionFromInternet;
        private Label label_CodeName_Net;
        private Label label_DriverVerion_Net;
        private Label label_ControlPanelVersion_Net;
        private SingleButton singleButton_Check;
        private SingleButton singleButton_Copy;

        public frmCheckUpdate()
        {
            InitializeComponent();
            Text = GlobalMessages.CHECK_UPDATE;
            label_ControlPanelVersion.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : " + 1U.ToString() + "." + 0U.ToString() + "." + 5U.ToString();
            label_DriverVersion.Text = GlobalMessages.DRIVER_VERSION + " : " + RuntimeUtils.EffectDriver.GetVersion();
            label_CodeName.Text = GlobalMessages.CODE_NAME + " : " + RuntimeUtils.EffectDriver.GetCodeName();
            groupBox_VersionFromInternet.Text = GlobalMessages.VERSION_FROM_INTERNET;
            label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
            label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
            label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
            singleButton_Check.ButtonText = GlobalMessages.CHECK;
            singleButton_Copy.ButtonText = GlobalMessages.COPY_DOWNLOAD_LINK;
            singleButton_Copy.Enabled = false;
        }

        private void singleButton_Check_ButtonClickNotify(SingleButton objSender)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = baseDirectory.EndsWith("\\") ? baseDirectory + "version.txt" : baseDirectory + "\\version.txt";
            try
            {
                singleButton_Check.Enabled = false;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://vipersaudio.com/swupdate/viper4windows/version.bin");
                HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = response.GetResponseStream();
                Stream stream = new FileStream(path, FileMode.Create);
                byte[] buffer = new byte[1024];
                for (int count = responseStream.Read(buffer, 0, buffer.Length); count > 0; count = responseStream.Read(buffer, 0, buffer.Length))
                {
                    stream.Write(buffer, 0, count);
                }

                stream.Flush();
                stream.Close();
                responseStream.Close();
                response.Close();
                httpWebRequest.Abort();
                StreamReader streamReader = new StreamReader(path, Encoding.Unicode);
                string str1 = streamReader.ReadLine();
                string str2 = streamReader.ReadLine();
                string str3 = streamReader.ReadLine();
                string str4 = streamReader.ReadLine();
                streamReader.Close();
                System.IO.File.Delete(path);
                if (str1 == null || str2 == null || (str3 == null || str4 == null))
                {
                    label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
                    label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
                    label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
                    singleButton_Check.Enabled = true;
                    singleButton_Copy.Enabled = false;
                }
                else if (str1.Split('.').Length != 3)
                {
                    label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
                    label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
                    label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
                    singleButton_Check.Enabled = true;
                    singleButton_Copy.Enabled = false;
                }
                else if (str2.Split('.').Length != 3)
                {
                    label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
                    label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
                    label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
                    singleButton_Check.Enabled = true;
                    singleButton_Copy.Enabled = false;
                }
                else if (str3 == "" || str4.Length < 32)
                {
                    label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
                    label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
                    label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
                    singleButton_Check.Enabled = true;
                    singleButton_Copy.Enabled = false;
                }
                else
                {
                    label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : " + str1;
                    label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : " + str2;
                    label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : " + str3;
                    m_szDownloadLink = str4;
                    singleButton_Check.Enabled = true;
                    singleButton_Copy.Enabled = true;
                }
            }
            catch
            {
                System.IO.File.Delete(path);
                label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
                label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
                label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
                singleButton_Check.Enabled = true;
                singleButton_Copy.Enabled = false;
            }
        }

        private void singleButton_Copy_ButtonClickNotify(SingleButton objSender)
        {
            Clipboard.Clear();
            Clipboard.SetText(m_szDownloadLink);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckUpdate));
            this.label_CodeName = new System.Windows.Forms.Label();
            this.label_DriverVersion = new System.Windows.Forms.Label();
            this.label_ControlPanelVersion = new System.Windows.Forms.Label();
            this.groupBox_VersionFromInternet = new System.Windows.Forms.GroupBox();
            this.label_CodeName_Net = new System.Windows.Forms.Label();
            this.label_DriverVerion_Net = new System.Windows.Forms.Label();
            this.label_ControlPanelVersion_Net = new System.Windows.Forms.Label();
            this.singleButton_Copy = new ViPER4WindowsBin.UIControls.SingleButton();
            this.singleButton_Check = new ViPER4WindowsBin.UIControls.SingleButton();
            this.groupBox_VersionFromInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CodeName
            // 
            this.label_CodeName.AutoSize = true;
            this.label_CodeName.ForeColor = System.Drawing.Color.Snow;
            this.label_CodeName.Location = new System.Drawing.Point(12, 63);
            this.label_CodeName.Name = "label_CodeName";
            this.label_CodeName.Size = new System.Drawing.Size(79, 13);
            this.label_CodeName.TabIndex = 5;
            this.label_CodeName.Text = "$CODE_NAME";
            // 
            // label_DriverVersion
            // 
            this.label_DriverVersion.AutoSize = true;
            this.label_DriverVersion.ForeColor = System.Drawing.Color.Snow;
            this.label_DriverVersion.Location = new System.Drawing.Point(12, 41);
            this.label_DriverVersion.Name = "label_DriverVersion";
            this.label_DriverVersion.Size = new System.Drawing.Size(102, 13);
            this.label_DriverVersion.TabIndex = 4;
            this.label_DriverVersion.Text = "$DRIVER_VERSION";
            // 
            // label_ControlPanelVersion
            // 
            this.label_ControlPanelVersion.AutoSize = true;
            this.label_ControlPanelVersion.ForeColor = System.Drawing.Color.Snow;
            this.label_ControlPanelVersion.Location = new System.Drawing.Point(12, 19);
            this.label_ControlPanelVersion.Name = "label_ControlPanelVersion";
            this.label_ControlPanelVersion.Size = new System.Drawing.Size(146, 13);
            this.label_ControlPanelVersion.TabIndex = 3;
            this.label_ControlPanelVersion.Text = "$CONTROLPANEL_VERSION";
            // 
            // groupBox_VersionFromInternet
            // 
            this.groupBox_VersionFromInternet.Controls.Add(this.label_CodeName_Net);
            this.groupBox_VersionFromInternet.Controls.Add(this.label_DriverVerion_Net);
            this.groupBox_VersionFromInternet.Controls.Add(this.label_ControlPanelVersion_Net);
            this.groupBox_VersionFromInternet.ForeColor = System.Drawing.Color.Snow;
            this.groupBox_VersionFromInternet.Location = new System.Drawing.Point(14, 97);
            this.groupBox_VersionFromInternet.Name = "groupBox_VersionFromInternet";
            this.groupBox_VersionFromInternet.Size = new System.Drawing.Size(332, 96);
            this.groupBox_VersionFromInternet.TabIndex = 6;
            this.groupBox_VersionFromInternet.TabStop = false;
            this.groupBox_VersionFromInternet.Text = "$VERSION_FROM_INTERNET";
            // 
            // label_CodeName_Net
            // 
            this.label_CodeName_Net.AutoSize = true;
            this.label_CodeName_Net.ForeColor = System.Drawing.Color.Snow;
            this.label_CodeName_Net.Location = new System.Drawing.Point(17, 70);
            this.label_CodeName_Net.Name = "label_CodeName_Net";
            this.label_CodeName_Net.Size = new System.Drawing.Size(79, 13);
            this.label_CodeName_Net.TabIndex = 8;
            this.label_CodeName_Net.Text = "$CODE_NAME";
            // 
            // label_DriverVerion_Net
            // 
            this.label_DriverVerion_Net.AutoSize = true;
            this.label_DriverVerion_Net.ForeColor = System.Drawing.Color.Snow;
            this.label_DriverVerion_Net.Location = new System.Drawing.Point(17, 48);
            this.label_DriverVerion_Net.Name = "label_DriverVerion_Net";
            this.label_DriverVerion_Net.Size = new System.Drawing.Size(102, 13);
            this.label_DriverVerion_Net.TabIndex = 7;
            this.label_DriverVerion_Net.Text = "$DRIVER_VERSION";
            // 
            // label_ControlPanelVersion_Net
            // 
            this.label_ControlPanelVersion_Net.AutoSize = true;
            this.label_ControlPanelVersion_Net.ForeColor = System.Drawing.Color.Snow;
            this.label_ControlPanelVersion_Net.Location = new System.Drawing.Point(17, 26);
            this.label_ControlPanelVersion_Net.Name = "label_ControlPanelVersion_Net";
            this.label_ControlPanelVersion_Net.Size = new System.Drawing.Size(146, 13);
            this.label_ControlPanelVersion_Net.TabIndex = 6;
            this.label_ControlPanelVersion_Net.Text = "$CONTROLPANEL_VERSION";
            // 
            // singleButton_Copy
            // 
            this.singleButton_Copy.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Copy.ButtonText = "$COPY_DOWNLOAD_LINK";
            this.singleButton_Copy.ForeColor = System.Drawing.Color.Snow;
            this.singleButton_Copy.Location = new System.Drawing.Point(14, 199);
            this.singleButton_Copy.Name = "singleButton_Copy";
            this.singleButton_Copy.Size = new System.Drawing.Size(166, 40);
            this.singleButton_Copy.TabIndex = 8;
            this.singleButton_Copy.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Copy_ButtonClickNotify);
            // 
            // singleButton_Check
            // 
            this.singleButton_Check.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Check.ButtonText = "$CHECK";
            this.singleButton_Check.ForeColor = System.Drawing.Color.Snow;
            this.singleButton_Check.Location = new System.Drawing.Point(239, 19);
            this.singleButton_Check.Name = "singleButton_Check";
            this.singleButton_Check.Size = new System.Drawing.Size(112, 40);
            this.singleButton_Check.TabIndex = 7;
            this.singleButton_Check.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Check_ButtonClickNotify);
            // 
            // frmCheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 250);
            this.Controls.Add(this.singleButton_Copy);
            this.Controls.Add(this.singleButton_Check);
            this.Controls.Add(this.groupBox_VersionFromInternet);
            this.Controls.Add(this.label_CodeName);
            this.Controls.Add(this.label_DriverVersion);
            this.Controls.Add(this.label_ControlPanelVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheckUpdate";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$CHECK_UPDATE";
            this.ThemeName = "VisualStudio2012Dark";
            this.groupBox_VersionFromInternet.ResumeLayout(false);
            this.groupBox_VersionFromInternet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
