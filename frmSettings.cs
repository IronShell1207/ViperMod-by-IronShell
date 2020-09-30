// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmSettings
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
    public class frmSettings : Telerik.WinControls.UI.RadForm
    {
        private readonly List<TrayMenuPreset> m_lstTrayMenuPreset = new List<TrayMenuPreset>();
        private string m_szPresetPath = "";
        private bool m_bCloseToTray;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip_TrayItem;
        private ToolStripMenuItem toolStripMenuItem_RemoveItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem_Name;
        private ToolStripTextBox toolStripTextBox_Name;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem_Mode;
        private ToolStripComboBox toolStripComboBox_Mode;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem_Preset;
        private Label label_EnableCoexist;
        private Telerik.WinControls.UI.RadButton singleButton_OK;
        private Telerik.WinControls.UI.RadButton singleButton_Cancel;
        private OnOffSwitch onOffSwitch_EnableCoexist;

        private string EffectModeToString(int nMode)
        {
            switch (nMode)
            {
                case 0:
                    return GlobalMessages.MUSIC_MODE;
                case 1:
                    return GlobalMessages.MOVIE_MODE;
                case 2:
                    return GlobalMessages.FREESTYLE_MODE;
                default:
                    return "";
            }
        }

        public void SetPresetPath(string szPath)
        {
            m_szPresetPath = szPath;
        }


        public bool GetCloseToTray()
        {
            return m_bCloseToTray;
        }

        public void SetTrayMenuPresetList(List<TrayMenuPreset> lstTrayMenuPreset)
        {
            m_lstTrayMenuPreset.Clear();
            //listView_TrayMenuSetting.Items.Clear();
            if (lstTrayMenuPreset == null || lstTrayMenuPreset.Count <= 0)
            {
                return;
            }

            foreach (TrayMenuPreset trayMenuPreset1 in lstTrayMenuPreset)
            {
                if (trayMenuPreset1.Valid())
                {
                    if (string.IsNullOrEmpty(trayMenuPreset1.PresetName))
                    {
                        trayMenuPreset1.PresetName = GlobalMessages.UNNAMED;
                    }

                    TrayMenuPreset trayMenuPreset2 = trayMenuPreset1.Clone();
                    //        listView_TrayMenuSetting.Items.Add(new ListViewItem()
                    //        {
                    //            Text = trayMenuPreset2.PresetName,
                    //            SubItems = {
                    //  EffectModeToString(trayMenuPreset2.PresetMode),
                    //  trayMenuPreset2.PresetFileShort
                    //},
                    //            Tag = trayMenuPreset2
                    //        });
                    //       
                    m_lstTrayMenuPreset.Add(trayMenuPreset2);
                }
            }
        }

        public List<TrayMenuPreset> GetTrayMenuPresetList()
        {
            return m_lstTrayMenuPreset;
        }

        public bool GetAPOCoexistEnabled()
        {
            return onOffSwitch_EnableCoexist.SwitchedOn;
        }

        public frmSettings()
        {
            InitializeComponent();
            Text = GlobalMessages.SETTINGS;
            //label_CloseToTray.Text = GlobalMessages.CLOSE_TO_TRAY;
            //groupBox_TrayMenuSetting.Text = GlobalMessages.TRAY_MENU_SETTING;
            //listView_TrayMenuSetting.Items.Clear();
            //listView_TrayMenuSetting.Columns[0].Text = GlobalMessages.TRAY_MENU_PRESETNAME;
            //listView_TrayMenuSetting.Columns[1].Text = GlobalMessages.TRAY_MENU_PRESETMODE;
            //listView_TrayMenuSetting.Columns[2].Text = GlobalMessages.TRAY_MENU_PRESETFILE;
            //singleButton_AddNewItem.ButtonText = GlobalMessages.ADD_NEW_ITEM;
            singleButton_OK.Text = GlobalMessages.OK;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            toolStripMenuItem_RemoveItem.Text = GlobalMessages.REMOVE_ITEM;
            toolStripMenuItem_Name.Text = GlobalMessages.MENU_TIPS_NAME;
            toolStripMenuItem_Mode.Text = GlobalMessages.MENU_TIPS_MODE;
            toolStripMenuItem_Preset.Text = GlobalMessages.SELECT_PRESET_FILE;
            toolStripComboBox_Mode.Items.Clear();
            toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(0));
            toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(1));
            toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(2));
            m_lstTrayMenuPreset.Clear();
            m_bCloseToTray = false;
            //onOffSwitch_CloseToTray.SwitchedOn = false;
            label_EnableCoexist.Text = GlobalMessages.ENABLE_APO_COEXIST;
            if (RegHelper.QueryDWORD("LoadChildAPO", 0U) == 1U)
            {
                onOffSwitch_EnableCoexist.SwitchedOn = true;
            }
            else
            {
                onOffSwitch_EnableCoexist.SwitchedOn = false;
            }
        }

        private void RefreshList()
        {
            //listView_TrayMenuSetting.Items.Clear();
            foreach (TrayMenuPreset trayMenuPreset in m_lstTrayMenuPreset)
            {
                if (trayMenuPreset.Valid())
                {
                    if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
                    {
                        trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
                    }


                }
            }
        }

        private void onOffSwitch_CloseToTray_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_bCloseToTray = bSwitchedOn;
        }

        private void singleButton_AddNewItem_ButtonClickNotify(SingleButton objSender)
        {
            m_lstTrayMenuPreset.Add(new TrayMenuPreset(GlobalMessages.UNNAMED, 0, ""));
            RefreshList();
        }


        private void toolStripMenuItem_RemoveItem_Click(object sender, EventArgs e)
        {
            //if (listView_TrayMenuSetting.SelectedItems.Count != 1 || listView_TrayMenuSetting.SelectedItems[0].Tag == null || (listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset) || MessageBox.Show(GlobalMessages.REMOVE_ITEM_QUESTION, GlobalMessages.REMOVE_ITEM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            //{
            //    return;
            //}

            //TrayMenuPreset tag = listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
            //if (m_lstTrayMenuPreset.Contains(tag))
            //{
            //    m_lstTrayMenuPreset.Remove(tag);
            //}

            RefreshList();
        }

        private void toolStripTextBox_Name_KeyUp(object sender, KeyEventArgs e)
        {
            //    if (listView_TrayMenuSetting.SelectedItems.Count != 1 || listView_TrayMenuSetting.SelectedItems[0].Tag == null || listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
            //    {
            //        return;
            //    }

            // TrayMenuPreset tag = listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
            //tag.PresetName = toolStripTextBox_Name.Text;
            //if (string.IsNullOrEmpty(tag.PresetName))
            //{
            //    tag.PresetName = GlobalMessages.UNNAMED;
            //}

            //listView_TrayMenuSetting.SelectedItems[0].Text = tag.PresetName;
        }

        private void toolStripComboBox_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView_TrayMenuSetting.SelectedItems.Count != 1 || listView_TrayMenuSetting.SelectedItems[0].Tag == null || listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
            //{
            //    return;
            //}

            //TrayMenuPreset tag = listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
            if (toolStripComboBox_Mode.SelectedItem == null || toolStripComboBox_Mode.SelectedItem.GetType() != typeof(frmSettings.PresetModeItem))
            {
                return;
            }

            //frmSettings.PresetModeItem selectedItem = toolStripComboBox_Mode.SelectedItem as frmSettings.PresetModeItem;
            //tag.PresetMode = selectedItem.PresetMode;
            //listView_TrayMenuSetting.SelectedItems[0].SubItems[1].Text = EffectModeToString(tag.PresetMode);
        }

        private void toolStripMenuItem_Preset_Click(object sender, EventArgs e)
        {
            //if (listView_TrayMenuSetting.SelectedItems.Count != 1 || listView_TrayMenuSetting.SelectedItems[0].Tag == null || listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
            //{
            //    return;
            //}

            //TrayMenuPreset tag = listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = GlobalMessages.LOAD_PRESET,
                Filter = "*.vpf|*.vpf",
                DefaultExt = "vpf",
                InitialDirectory = m_szPresetPath
            };
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            //   tag.PresetFile = openFileDialog.FileName;
            RefreshList();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.contextMenuStrip_TrayItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_RemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Name = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_Mode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Preset = new System.Windows.Forms.ToolStripMenuItem();
            this.label_EnableCoexist = new System.Windows.Forms.Label();
            this.onOffSwitch_EnableCoexist = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.singleButton_OK = new Telerik.WinControls.UI.RadButton();
            this.singleButton_Cancel = new Telerik.WinControls.UI.RadButton();
            this.contextMenuStrip_TrayItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip_TrayItem
            // 
            this.contextMenuStrip_TrayItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_RemoveItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Name,
            this.toolStripTextBox_Name,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Mode,
            this.toolStripComboBox_Mode,
            this.toolStripSeparator3,
            this.toolStripMenuItem_Preset});
            this.contextMenuStrip_TrayItem.Name = "contextMenuStrip_TrayItem";
            this.contextMenuStrip_TrayItem.Size = new System.Drawing.Size(188, 162);
            // 
            // toolStripMenuItem_RemoveItem
            // 
            this.toolStripMenuItem_RemoveItem.Name = "toolStripMenuItem_RemoveItem";
            this.toolStripMenuItem_RemoveItem.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem_RemoveItem.Text = "$REMOVE_ITEM";
            this.toolStripMenuItem_RemoveItem.Click += new System.EventHandler(this.toolStripMenuItem_RemoveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem_Name
            // 
            this.toolStripMenuItem_Name.Enabled = false;
            this.toolStripMenuItem_Name.Name = "toolStripMenuItem_Name";
            this.toolStripMenuItem_Name.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem_Name.Text = "$MENU_TIPS_NAME";
            // 
            // toolStripTextBox_Name
            // 
            this.toolStripTextBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_Name.Name = "toolStripTextBox_Name";
            this.toolStripTextBox_Name.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_Name_KeyUp);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem_Mode
            // 
            this.toolStripMenuItem_Mode.Enabled = false;
            this.toolStripMenuItem_Mode.Name = "toolStripMenuItem_Mode";
            this.toolStripMenuItem_Mode.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem_Mode.Text = "$MENU_TIPS_MODE";
            // 
            // toolStripComboBox_Mode
            // 
            this.toolStripComboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Mode.Name = "toolStripComboBox_Mode";
            this.toolStripComboBox_Mode.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_Mode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Mode_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem_Preset
            // 
            this.toolStripMenuItem_Preset.Name = "toolStripMenuItem_Preset";
            this.toolStripMenuItem_Preset.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem_Preset.Text = "$SELECT_PRESET_FILE";
            this.toolStripMenuItem_Preset.Click += new System.EventHandler(this.toolStripMenuItem_Preset_Click);
            // 
            // label_EnableCoexist
            // 
            this.label_EnableCoexist.AutoSize = true;
            this.label_EnableCoexist.ForeColor = System.Drawing.Color.Snow;
            this.label_EnableCoexist.Location = new System.Drawing.Point(12, 22);
            this.label_EnableCoexist.Name = "label_EnableCoexist";
            this.label_EnableCoexist.Size = new System.Drawing.Size(126, 13);
            this.label_EnableCoexist.TabIndex = 5;
            this.label_EnableCoexist.Text = "$ENABLE_APO_COEXIST";
            // 
            // onOffSwitch_EnableCoexist
            // 
            this.onOffSwitch_EnableCoexist.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_EnableCoexist.Location = new System.Drawing.Point(277, 15);
            this.onOffSwitch_EnableCoexist.Name = "onOffSwitch_EnableCoexist";
            this.onOffSwitch_EnableCoexist.Size = new System.Drawing.Size(66, 25);
            this.onOffSwitch_EnableCoexist.SwitchedOn = false;
            this.onOffSwitch_EnableCoexist.TabIndex = 6;
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.singleButton_OK.Location = new System.Drawing.Point(77, 58);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Size = new System.Drawing.Size(89, 32);
            this.singleButton_OK.TabIndex = 29;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "VisualStudio2012Dark";
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.singleButton_Cancel.Location = new System.Drawing.Point(189, 58);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(93, 32);
            this.singleButton_Cancel.TabIndex = 30;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "VisualStudio2012Dark";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 100);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.onOffSwitch_EnableCoexist);
            this.Controls.Add(this.label_EnableCoexist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$SETTINGS";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.contextMenuStrip_TrayItem.ResumeLayout(false);
            this.contextMenuStrip_TrayItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private class PresetModeItem
        {
            private int m_nPresetMode = -1;

            public int PresetMode
            {
                get => m_nPresetMode;
                set => m_nPresetMode = value;
            }

            public string PresetModeString
            {
                get
                {
                    if (m_nPresetMode == 0)
                    {
                        return GlobalMessages.MUSIC_MODE;
                    }

                    if (m_nPresetMode == 1)
                    {
                        return GlobalMessages.MOVIE_MODE;
                    }

                    return m_nPresetMode == 2 ? GlobalMessages.FREESTYLE_MODE : "";
                }
            }

            public PresetModeItem(int nMode)
            {
                m_nPresetMode = nMode;
            }

            public override bool Equals(object obj)
            {
                return obj != null && obj.GetType() == typeof(frmSettings.PresetModeItem) && (obj as frmSettings.PresetModeItem).PresetMode == m_nPresetMode;
            }

            public override int GetHashCode()
            {
                return m_nPresetMode;
            }

            public override string ToString()
            {
                return PresetModeString;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
