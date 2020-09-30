// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.frmMain
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;
using EzShell;
using MetroFramework;
using System.Threading;
using System.Security.Principal;
using inifiles;

namespace ViPER4WindowsBin
{
    public class frmMain : RadForm
    {
        private static string m_szLanguagePath = "";
        private static string m_szLanguageFile = "";
        private static string m_szLanguageName = "";
        private readonly string m_szLocalPresetFileName = "LocalPreset.bin";
        private readonly string m_szImpulseResponsePath = "ImpulseResponse";
        private readonly string m_szUserPresetPath = "Presets";
        private readonly string m_szLocalPreset = "";
        private string m_szIRSPath = "";
        private string m_szPresetsPath = "";
        private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramBaseSystem = new RuntimeUtils.ConfigProxy._ParamOfBaseSystem();
        private RuntimeUtils.ConfigProxy._ParamOfMusicMode m_paramMusicMode = new RuntimeUtils.ConfigProxy._ParamOfMusicMode();
        private RuntimeUtils.ConfigProxy._ParamOfMovieMode m_paramMovieMode = new RuntimeUtils.ConfigProxy._ParamOfMovieMode();
        private RuntimeUtils.ConfigProxy._ParamOfFreestyle m_paramFreestyle = new RuntimeUtils.ConfigProxy._ParamOfFreestyle();
        private readonly List<TrayMenuPreset> m_lstTrayMenuPreset = new List<TrayMenuPreset>();
        private readonly bool m_bArgvStartupToMinimized;
        private bool m_bCloseToTray;
        private readonly RuntimeUtils.ConfigProxy m_cpConfigProxy;
        private IContainer components;
        private Label label_MasterPower;
        private OnOffSwitch onOffSwitch_Master;
        //     private MenuStrip menuStrip_Main;
        private ToolStripMenuItem toolStripMenuItem_Language;
        private ToolStripMenuItem toolStripMenuItem_Setting;
        private ToolStripMenuItem toolStripMenuItem_Help;
        private ToolStripMenuItem toolStripMenuItem_CheckUpdate;
        private ToolStripMenuItem toolStripMenuItem_AboutV4W;
        private ToolStripMenuItem toolStripMenuItem_LatencySetting;
        private ToolStripMenuItem toolStripMenuItem_ResetEffect;
        private ToolStripMenuItem toolStripMenuItem_ChannelPan;
        private ToolStripMenuItem toolStripMenuItem_Virtualization;
        private ToolStripMenuItem toolStripMenuItem_Settings;
        private HSlider Freestyle_hSlider_SmartVolumeLevel;
        private Label Freestyle_label_SmartVolume_Level;
        private HSlider Freestyle_hSlider_SmartVolumeMaxLevel;
        private Label Freestyle_label_SmartVolume_MaxLevel;
        private HSlider Freestyle_hSlider_SmartVolumeRatio;
        private Label Freestyle_label_SmartVolume_ControlStrength;
        private OnOffSwitch Freestyle_onOffSwitch_SmartVolume;
        private HSlider Freestyle_hSlider_SurroundImage;
        private Label Freestyle_label_Surround_Image;
        private HSlider Freestyle_hSlider_Surround3D;
        private Label Freestyle_label_Surround_3D;
        private OnOffSwitch Freestyle_onOffSwitch_Surround3D;
        private HSlider Freestyle_hSlider_ReverbMix;
        private Label Freestyle_label_Reverb_Mix;
        private HSlider Freestyle_hSlider_ReverbEarlyMix;
        private Label Freestyle_label_Reverb_EarlyMix;
        private HSlider Freestyle_hSlider_ReverbPreDelay;
        private Label Freestyle_label_Reverb_PreDelay;
        private HSlider Freestyle_hSlider_ReverbDecay;
        private Label Freestyle_label_Reverb_Decay;
        private HSlider Freestyle_hSlider_ReverbBandWidth;
        private Label Freestyle_label_Reverb_BandWidth;
        private HSlider Freestyle_hSlider_ReverbDensity;
        private Label Freestyle_label_Reverb_Density;
        private HSlider Freestyle_hSlider_ReverbDamping;
        private Label Freestyle_label_Reverb_Damping;
        private HSlider Freestyle_hSlider_ReverbSize;
        private Label Freestyle_label_Reverb_Size;
        private OnOffSwitch Freestyle_onOffSwitch_Reverb;
        private ButtonBox Freestyle_buttonBox_CureLevel;
        private OnOffSwitch Freestyle_onOffSwitch_Cure;
        private Label Freestyle_label_Tube;
        private OnOffSwitch Freestyle_onOffSwitch_Tube;
        private ButtonBox Freestyle_buttonBox_ClarityMode;
        private HSlider Freestyle_hSlider_Clarity;
        private Label Freestyle_label_Clarity;
        private OnOffSwitch Freestyle_onOffSwitch_Clarity;
        private ButtonBox Freestyle_buttonBox_BassMode;
        private HSlider Freestyle_hSlider_BassGain;
        private Label Freestyle_label_Bass_Gain;
        private HSlider Freestyle_hSlider_BassSpkSize;
        private Label Freestyle_label_Bass_SpkSize;
        private OnOffSwitch Freestyle_onOffSwitch_Bass;
        private ButtonBox Freestyle_buttonBox_SurroundVHERoomSize;
        private OnOffSwitch Freestyle_onOffSwitch_SurroundVHE;
        private IRShape Freestyle_irShape_ConvIR;
        private OnOffSwitch Freestyle_onOffSwitch_Convolver;
        private HSlider Freestyle_hSlider_ConvIRGain;
        private OpenFileBox Freestyle_openFileBox_ConvIRS;
        private Label Freestyle_label_ConvolverIRGain;
        private HSlider Freestyle_hSlider_PostVolume;
        private Label Freestyle_label_PostVolume;
        private HSlider Freestyle_hSlider_PreVolume;
        private Label Freestyle_label_PreVolume;
        private RadMenuItem radMenuItem2;
        private RadMenuItem MENU_SETTING;
        private RadMenuItem CHECKUPDATE;
        private RadMenuItem ABOUTV4W;
        private RadMenuItem LATENCY_SETTING;
        private RadMenuItem CHANNEL_PAN;
        private RadMenuItem RESETEFFECT;
        private RadMenuItem SETTINGS;
        private RadMenuItem VIRTUALIZATION;
        private RadButton button_Freestyle;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private RadMenuItem radMenuItem1;
        private RadMenuItem radMenuItem3;
        private RadMenuItem radMenuItem4;
        private RadButton Freestyle_singleButton_ReverbPreset1;
        private RadButton radButton1;
        private RadButton radButton2;
        private RadButton radButton3;
        private RadButton radButton4;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Panel panel7;
        private Label label6;
        private Panel panel8;
        private Label label8;
        private Label label7;
        private MetroFramework.Controls.MetroPanel panelUpdateDownloading;
        public MetroFramework.Controls.MetroProgressBar progressProg;
        private Label labelKB;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Label label9;
        public NotifyIcon notifyIcon1;
        private RadMenuItem radMenuItem5;
        private RadMenuItem radMenuItem6;
        private RadMenuItem radMenuItem7;
        private RadMenuItem radMenuItem8;
        private RadMenuItem radMenuItem9;
        private PictureBox pictureBox1;
        private RadMenuItem radMenuItem10;
        private RadMenuItem radMenuItem11;
        private RadMenu radMenu1;

        public static void SetLanguage(string szLanguagePath, string szLanguageFile)
        {
            frmMain.m_szLanguagePath = szLanguagePath;
            frmMain.m_szLanguageFile = szLanguageFile;
            if (frmMain.m_szLanguagePath == "" || frmMain.m_szLanguageFile == "")
            {
                frmMain.m_szLanguageName = "";
            }
            else
            {
                frmMain.m_szLanguageName = new ConfigFile(szLanguageFile).ReadConfig("$LANGUAGE_NAME");
            }
        }
        private Font OldFont;

        Font myFont;
        PrivateFontCollection private_fonts = new PrivateFontCollection();
        private void LoadFont()
        {
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.Roboto_Regular))
            {
                // create an unsafe memory block for the font data
                System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                // create a buffer to read in to
                byte[] fontdata = new byte[fontStream.Length];
                // read the font data from the resource
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                // copy the bytes to the unsafe memory block
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                // pass the font to the font collection
                private_fonts.AddMemoryFont(data, (int)fontStream.Length);
                // close the resource stream
                fontStream.Close();
                // free the unsafe memory
                Marshal.FreeCoTaskMem(data);
            }

        }
        public frmMain form1;
        public DialogResult messageBoxCaller(string message, string header, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Thread.Sleep(100);
            DialogResult r = DialogResult.Cancel;
            form1.Invoke(new Action(() =>
                r = MetroMessageBox.Show(form1, message, header, buttons, icon, 300)));
            return r;
        }
        public frmMain(string[] szArgs)
        {
            InitializeComponent();
            form1 = this;
            CheckUpdate = new CheckUpdates("ViPER", Application.ProductVersion, @"https://droidapps.cf/Files/ViPER.zip", messageBoxCaller, progressProg, notifyIcon1, panelUpdateDownloading, labelKB);

            m_bArgvStartupToMinimized = false;
            if (szArgs != null)
            {
                int length = szArgs.Length;
            }
            m_szLocalPreset = AppDomain.CurrentDomain.BaseDirectory;
            if (!m_szLocalPreset.EndsWith("\\"))
            {
                m_szLocalPreset += "\\";
            }

            m_szLocalPreset += m_szLocalPresetFileName;
            m_szIRSPath = AppDomain.CurrentDomain.BaseDirectory;
            if (!m_szIRSPath.EndsWith("\\"))
            {
                m_szIRSPath += "\\";
            }

            frmMain frmMain1 = this;
            frmMain1.m_szIRSPath = frmMain1.m_szIRSPath + m_szImpulseResponsePath + "\\";
            if (!Directory.Exists(m_szIRSPath))
            {
                try
                {
                    Directory.CreateDirectory(m_szIRSPath);
                }
                catch
                {
                }
            }
            m_szPresetsPath = AppDomain.CurrentDomain.BaseDirectory;
            if (!m_szPresetsPath.EndsWith("\\"))
            {
                m_szPresetsPath += "\\";
            }

            frmMain frmMain2 = this;
            frmMain2.m_szPresetsPath = frmMain2.m_szPresetsPath + m_szUserPresetPath + "\\";
            if (!Directory.Exists(m_szPresetsPath))
            {
                try
                {
                    Directory.CreateDirectory(m_szPresetsPath);
                }
                catch
                {
                }
            }
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (!baseDirectory.EndsWith("\\"))
            {
                baseDirectory += "\\";
            }

            ConfigFile configFile = new ConfigFile(baseDirectory + "Config.ini");
            string str1 = configFile.ReadConfig("$CLOSE_APP_TO_TRAY");
            m_bCloseToTray = !string.IsNullOrEmpty(str1) && str1.ToUpper() == "TRUE";
            m_lstTrayMenuPreset.Clear();
            string s = configFile.ReadConfig("$TRAY_MENU_PRESET_COUNT");
            if (!string.IsNullOrEmpty(s))
            {
                int result = 0;
                try
                {
                    if (int.TryParse(s, out result))
                    {
                        for (int index = 0; index < result; ++index)
                        {
                            string szName = configFile.ReadConfig("$TRAY_MENU_PRESET_NAME_" + index.ToString());
                            string str2 = configFile.ReadConfig("$TRAY_MENU_PRESET_MODE_" + index.ToString());
                            string szFile = configFile.ReadConfig("$TRAY_MENU_PRESET_FILE_" + index.ToString());
                            if (string.IsNullOrEmpty(szName))
                            {
                                szName = GlobalMessages.UNNAMED;
                            }

                            if (!string.IsNullOrEmpty(str2))
                            {
                                int nMode = -1;
                                if (str2 == "EFFECT_MODE_MUSIC")
                                {
                                    nMode = 0;
                                }

                                if (str2 == "EFFECT_MODE_MOVIE")
                                {
                                    nMode = 1;
                                }

                                if (str2 == "EFFECT_MODE_FREESTYLE")
                                {
                                    nMode = 2;
                                }

                                if (nMode != -1)
                                {
                                    m_lstTrayMenuPreset.Add(new TrayMenuPreset(szName, nMode, szFile));
                                }
                            }
                        }
                    }
                }
                catch
                {
                    m_lstTrayMenuPreset.Clear();
                }
            }
            string config = RegHelper.GetConfig();
            if (!RuntimeUtils.ConfigProxy.CheckConfigVersion(config))
            {
                RuntimeUtils.ConfigProxy.UpdateConfigToCurrent(config);
            }

            m_cpConfigProxy = new RuntimeUtils.ConfigProxy(config);
            Parameters.LoadDefaultParameter(ref m_paramBaseSystem);
            Parameters.LoadDefaultParameter(ref m_paramMusicMode);
            Parameters.LoadDefaultParameter(ref m_paramMovieMode);
            Parameters.LoadDefaultParameter(ref m_paramFreestyle);
            if (!Parameters.ReadPreset(m_szLocalPreset, ref m_paramBaseSystem, ref m_paramMusicMode, ref m_paramMovieMode, ref m_paramFreestyle, out bool bPBaseSystem, out bool bPMusicMode, out bool bPMovieMode, out bool bPFreestyle))
            {
                Parameters.LoadDefaultParameter(ref m_paramBaseSystem);
                Parameters.LoadDefaultParameter(ref m_paramMusicMode);
                Parameters.LoadDefaultParameter(ref m_paramMovieMode);
                Parameters.LoadDefaultParameter(ref m_paramFreestyle);
            }
            else
            {
                if (!bPBaseSystem)
                {
                    Parameters.LoadDefaultParameter(ref m_paramBaseSystem);
                }

                if (!bPMusicMode)
                {
                    Parameters.LoadDefaultParameter(ref m_paramMusicMode);
                }

                if (!bPMovieMode)
                {
                    Parameters.LoadDefaultParameter(ref m_paramMovieMode);
                }

                if (!bPFreestyle)
                {
                    Parameters.LoadDefaultParameter(ref m_paramFreestyle);
                }
            }
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
            //   MENU_LANGUAGE.Text = GlobalMessages.MENU_LANGUAGE;
            MENU_SETTING.Text = GlobalMessages.MENU_SETTING;
            LATENCY_SETTING.Text = GlobalMessages.LATENCY_SETTING;
            CHANNEL_PAN.Text = GlobalMessages.CHANNEL_PAN;
            VIRTUALIZATION.Text = GlobalMessages.VIRTUALIZATION;
            RESETEFFECT.Text = GlobalMessages.RESET_EFFECT;
            SETTINGS.Text = GlobalMessages.SETTINGS;
            //    HELP.Text = GlobalMessages.MENU_HELP;
            CHECKUPDATE.Text = GlobalMessages.CHECK_UPDATE;
            ABOUTV4W.Text = GlobalMessages.ABOUT;
            label_MasterPower.Text = GlobalMessages.MASTER_POWER;
            radButton1.Text = GlobalMessages.LOAD_PRESET;
            radButton2.Text = GlobalMessages.SAVE_PRESET;
            //label_Copyright.Text = GlobalMessages.COPYRIGHT;
            //buttonBox_Mode.AddItem(new ButtonBox.Item(GlobalMessages.MUSIC_MODE, 0.ToString()));
            //buttonBox_Mode.AddItem(new ButtonBox.Item(GlobalMessages.MOVIE_MODE, 1.ToString()));
            //buttonBox_Mode.AddItem(new ButtonBox.Item(GlobalMessages.FREESTYLE_MODE, 2.ToString()));
            //Music_label_PreVolume.Text = GlobalMessages.PRE_VOLUME;
            //Music_label_PostVolume.Text = GlobalMessages.POST_VOLUME;
            //Music_groupBox_Convolver.Text = GlobalMessages.CONVOLVER;
            //Music_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN;
            //Music_openFileBox_ConvIRS.DialogTitle = GlobalMessages.OPEN_CONV_IRS;
            //Music_openFileBox_ConvIRS.FileFilter = "*.irs; *.wav|*.irs;*.wav|*.*|*.*";
            if (Directory.Exists(m_szIRSPath))
            {
                //        Music_openFileBox_ConvIRS.OpenDirectory = m_szIRSPath;
            }

            //Music_groupBox_Surround.Text = GlobalMessages.SURROUND;
            //Music_buttonBox_SurroundRoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALLEST_ROOM, "0"));
            //Music_buttonBox_SurroundRoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALL_ROOM, "1"));
            //Music_buttonBox_SurroundRoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_MID_ROOM, "2"));
            //Music_buttonBox_SurroundRoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGE_ROOM, "3"));
            //Music_buttonBox_SurroundRoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGEST_ROOM, "4"));
            //Music_groupBox_Bass.Text = GlobalMessages.BASS;
            //Music_label_Bass_SpkSize.Text = GlobalMessages.BASS_SPKSIZE;
            //Music_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN;
            //Music_groupBox_Clarity.Text = GlobalMessages.CLARITY;
            //Music_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.NATURAL_CLARITY, "0"));
            //Music_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.OZONE_CLARITY, "1"));
            //Music_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.XHIFI_CLARITY, "2"));
            //Music_label_Clarity.Text = GlobalMessages.CLARITY;
            //Music_groupBox_Cure.Text = GlobalMessages.CURE;
            //Music_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.SLIGHT_CURE, 6226570U.ToString()));
            //Music_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.MODERATE_CURE, 3932860U.ToString()));
            //Music_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.EXTREME_CURE, 2949820U.ToString()));
            //Music_label_Tube.Text = GlobalMessages.TUBE;
            //Music_groupBox_Reverb.Text = GlobalMessages.REVERB;
            //Music_singleButton_ReverbPreset.ButtonText = GlobalMessages.PRESET;
            //Music_label_Reverb_Size.Text = GlobalMessages.REVERB_SIZE;
            //Music_label_Reverb_Damping.Text = GlobalMessages.REVERB_DAMPING;
            //Music_label_Reverb_Density.Text = GlobalMessages.REVERB_DENSITY;
            //Music_label_Reverb_BandWidth.Text = GlobalMessages.REVERB_BANDWIDTH;
            //Music_label_Reverb_Decay.Text = GlobalMessages.REVERB_DECAY;
            //Music_label_Reverb_PreDelay.Text = GlobalMessages.REVERB_PREDELAY;
            //Music_label_Reverb_EarlyMix.Text = GlobalMessages.REVERB_EARLYMIX;
            //Music_label_Reverb_Mix.Text = GlobalMessages.REVERB_MIX;
            //Music_singleButton_Equalizer.ButtonText = GlobalMessages.EQUALIZER_ADJUST;
            //Music_singleButton_Compressor.ButtonText = GlobalMessages.COMPRESSOR_ADJUST;
            //Movie_label_PreVolume.Text = GlobalMessages.PRE_VOLUME;
            //Movie_label_PostVolume.Text = GlobalMessages.POST_VOLUME;
            //Movie_groupBox_Convolver.Text = GlobalMessages.CONVOLVER;
            //Movie_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN;
            //Movie_openFileBox_ConvIRS.DialogTitle = GlobalMessages.OPEN_CONV_IRS;
            //if (Directory.Exists(m_szIRSPath))
            //{
            //    Movie_openFileBox_ConvIRS.FileFilter = "*.irs; *.wav|*.irs;*.wav|*.*|*.*";
            //}

            //Movie_openFileBox_ConvIRS.OpenDirectory = m_szIRSPath;
            //Movie_groupBox_Surround.Text = GlobalMessages.SURROUND;
            //Movie_label_Surround_3D.Text = GlobalMessages.SURROUND_3D;
            //Movie_label_Surround_Image.Text = GlobalMessages.SURROUND_IMAGE;
            //Movie_groupBox_Bass.Text = GlobalMessages.BASS;
            //Movie_label_Bass_SpkSize.Text = GlobalMessages.BASS_SPKSIZE;
            //Movie_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN;
            //Movie_groupBox_Clarity.Text = GlobalMessages.CLARITY;
            //Movie_label_Clarity.Text = GlobalMessages.CLARITY;
            //Movie_groupBox_SmartVolume.Text = GlobalMessages.SMART_VOLUME;
            //Movie_label_SmartVolume_ControlStrength.Text = GlobalMessages.SMART_VOLUME_CONTROL_STRENGTH;
            //Movie_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL;
            //Movie_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL;
            //Movie_groupBox_Reverb.Text = GlobalMessages.REVERB;
            //Movie_singleButton_ReverbPreset.ButtonText = GlobalMessages.PRESET;
            //Movie_label_Reverb_Size.Text = GlobalMessages.REVERB_SIZE;
            //Movie_label_Reverb_Damping.Text = GlobalMessages.REVERB_DAMPING;
            //Movie_label_Reverb_Density.Text = GlobalMessages.REVERB_DENSITY;
            //Movie_label_Reverb_BandWidth.Text = GlobalMessages.REVERB_BANDWIDTH;
            //Movie_label_Reverb_Decay.Text = GlobalMessages.REVERB_DECAY;
            //Movie_label_Reverb_PreDelay.Text = GlobalMessages.REVERB_PREDELAY;
            //Movie_label_Reverb_EarlyMix.Text = GlobalMessages.REVERB_EARLYMIX;
            //Movie_label_Reverb_Mix.Text = GlobalMessages.REVERB_MIX;
            //Movie_singleButton_Equalizer.ButtonText = GlobalMessages.EQUALIZER_ADJUST;
            //Movie_singleButton_Compressor.ButtonText = GlobalMessages.COMPRESSOR_ADJUST;
            Freestyle_label_PreVolume.Text = GlobalMessages.PRE_VOLUME;
            Freestyle_label_PostVolume.Text = GlobalMessages.POST_VOLUME;
            //Freestyle_groupBox_Convolver.Text = GlobalMessages.CONVOLVER;
            Freestyle_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN;
            Freestyle_openFileBox_ConvIRS.DialogTitle = GlobalMessages.OPEN_CONV_IRS;
            Freestyle_openFileBox_ConvIRS.FileFilter = "*.irs; *.wav|*.irs;*.wav|*.*|*.*";
            if (Directory.Exists(m_szIRSPath))
            {
                Freestyle_openFileBox_ConvIRS.OpenDirectory = m_szIRSPath;
            }

            label8.Text = GlobalMessages.THREE_D_SURROUND;
            Freestyle_label_Surround_3D.Text = GlobalMessages.SURROUND_3D;
            Freestyle_label_Surround_Image.Text = GlobalMessages.SURROUND_IMAGE;
            // label7.Text = GlobalMessages.VHE_SURROUND;
            Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALLEST_ROOM, "0"));
            Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALL_ROOM, "1"));
            Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_MID_ROOM, "2"));
            Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGE_ROOM, "3"));
            Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGEST_ROOM, "4"));
            //Freestyle_groupBox_Bass.Text = GlobalMessages.BASS;
            Freestyle_label_Bass_SpkSize.Text = GlobalMessages.BASS_SPKSIZE;
            Freestyle_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN;
            Freestyle_buttonBox_BassMode.AddItem(new ButtonBox.Item(GlobalMessages.NATURAL_BASS, "0"));
            Freestyle_buttonBox_BassMode.AddItem(new ButtonBox.Item(GlobalMessages.PURE_BASS, "1"));
            //Freestyle_groupBox_Clarity.Text = GlobalMessages.CLARITY;
            Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.NATURAL_CLARITY, "0"));
            Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.OZONE_CLARITY, "1"));
            Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.XHIFI_CLARITY, "2"));
            Freestyle_label_Clarity.Text = GlobalMessages.CLARITY;
            // Freestyle_groupBox_Cure.Text = GlobalMessages.CURE;
            Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.SLIGHT_CURE, 6226570U.ToString()));
            Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.MODERATE_CURE, 3932860U.ToString()));
            Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.EXTREME_CURE, 2949820U.ToString()));
            Freestyle_label_Tube.Text = GlobalMessages.TUBE;
            //Freestyle_groupBox_Reverb.Text = GlobalMessages.REVERB;
            Freestyle_singleButton_ReverbPreset1.Text = GlobalMessages.PRESET;
            Freestyle_label_Reverb_Size.Text = GlobalMessages.REVERB_SIZE;
            Freestyle_label_Reverb_Damping.Text = GlobalMessages.REVERB_DAMPING;
            Freestyle_label_Reverb_Density.Text = GlobalMessages.REVERB_DENSITY;
            Freestyle_label_Reverb_BandWidth.Text = GlobalMessages.REVERB_BANDWIDTH;
            Freestyle_label_Reverb_Decay.Text = GlobalMessages.REVERB_DECAY;
            Freestyle_label_Reverb_PreDelay.Text = GlobalMessages.REVERB_PREDELAY;
            Freestyle_label_Reverb_EarlyMix.Text = GlobalMessages.REVERB_EARLYMIX;
            Freestyle_label_Reverb_Mix.Text = GlobalMessages.REVERB_MIX;
            //Freestyle_groupBox_SmartVolume.Text = GlobalMessages.SMART_VOLUME;
            Freestyle_label_SmartVolume_ControlStrength.Text = GlobalMessages.SMART_VOLUME_CONTROL_STRENGTH;
            Freestyle_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL;
            Freestyle_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL;
            radButton3.Text = GlobalMessages.EQUALIZER_ADJUST;
            radButton4.Text = GlobalMessages.COMPRESSOR_ADJUST;
            //toolStripMenuItem_Language.DropDownItems.Clear();
            //foreach (string listFile in new FolderExplorer().ListFiles(frmMain.m_szLanguagePath))
            //{
            //    string str2 = new ConfigFile(listFile).ReadConfig("$LANGUAGE_NAME");
            //    ToolStripItem toolStripItem = new ToolStripMenuItem
            //    {
            //        Text = str2,
            //        Tag = listFile
            //    };
            //    toolStripItem.Click += new EventHandler(LanguageChanged);
            //    toolStripMenuItem_Language.DropDownItems.Add(toolStripItem);
            //}
            //   this.MENU_LANGUAGE.EnableRippleAnimation = false;
            //     this.MENU_LANGUAGE.Items.Clear();
            //var toolStripItem = new Telerik.WinControls.RadItem();
            //foreach (string listFile in new FolderExplorer().ListFiles(frmMain.m_szLanguagePath))
            //{
            //    string str2 = new ConfigFile(listFile).ReadConfig("$LANGUAGE_NAME");
            //    toolStripItem.Text = str2;
            //    toolStripItem.Tag = listFile;
            //    toolStripItem.Click += new EventHandler(LanguageChanged);
            //    //    MENU_LANGUAGE.Items.Add(toolStripItem);
            //    MENU_LANGUAGE.Items.AddRange(toolStripItem);
            //}
            //this.MENU_LANGUAGE.Items.AddRange(new Telerik.WinControls.RadItem[] {
            //   toolStripItem

            //});
            //   MENU_LANGUAGE.Items.Clear();
            foreach (string listFile in new FolderExplorer().ListFiles(frmMain.m_szLanguagePath))
            {
                string str2 = new ConfigFile(listFile).ReadConfig("$LANGUAGE_NAME");
                RadItem toolStripItem = new RadItem
                {
                    Text = str2,
                    Tag = listFile
                };
                toolStripItem.Click += new EventHandler(LanguageChanged);
                //     MENU_LANGUAGE.Items.AddRange(toolStripItem);
            }
            //this.MENU_LANGUAGE.Name = "MENU_LANGUAGE";
            //this.MENU_LANGUAGE.Text = "MENU_LANGUAGE";
            //   this.MENU_LANGUAGE.Click += new System.EventHandler(this.radMenuItem1_Click);
            // groupBox_Main.Controls.Clear();
            //     groupBox_Main.Controls.Add(panel_MusicMode);
            //    groupBox_Main.Controls.Add(panel_MovieMode);
            //groupBox_Main.Controls.Add(panel_Freestyle);
            //   panel_MusicMode.Dock = DockStyle.Fill;
            //   panel_MovieMode.Dock = DockStyle.Fill;
            //panel_Freestyle.Dock = DockStyle.Fill;
            UpdateAllControlsFromParameters();
            if (szArgs == null || szArgs.Length <= 0)
            {
                return;
            }

            for (int index = 0; index < szArgs.Length; ++index)
            {
                if (szArgs[index].ToLower().Trim() == "--hide")
                {
                    m_bArgvStartupToMinimized = m_bCloseToTray;
                }
                else if (szArgs[index].ToLower().Trim() == "-m")
                {
                    m_bArgvStartupToMinimized = m_bCloseToTray;
                }
            }
        }

        private void SaveAppSettings()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (!baseDirectory.EndsWith("\\"))
            {
                baseDirectory += "\\";
            }

            ConfigFile configFile = new ConfigFile(baseDirectory + "Config.ini");
            if (m_bCloseToTray)
            {
                configFile.SetConfig("$CLOSE_APP_TO_TRAY", "TRUE");
            }
            else
            {
                configFile.SetConfig("$CLOSE_APP_TO_TRAY", "FALSE");
            }

            int num1 = 0;
            for (int index = 0; index < m_lstTrayMenuPreset.Count; ++index)
            {
                if (m_lstTrayMenuPreset[index].Valid())
                {
                    ++num1;
                }
            }
            configFile.SetConfig("$TRAY_MENU_PRESET_COUNT", num1.ToString());
            int index1 = 0;
            int num2 = 0;
            for (; index1 < m_lstTrayMenuPreset.Count; ++index1)
            {
                if (m_lstTrayMenuPreset[index1].Valid())
                {
                    if (string.IsNullOrEmpty(m_lstTrayMenuPreset[index1].PresetName))
                    {
                        m_lstTrayMenuPreset[index1].PresetName = GlobalMessages.UNNAMED;
                    }

                    string szValue = "";
                    if (m_lstTrayMenuPreset[index1].PresetMode == 0)
                    {
                        szValue = "EFFECT_MODE_MUSIC";
                    }

                    if (m_lstTrayMenuPreset[index1].PresetMode == 1)
                    {
                        szValue = "EFFECT_MODE_MOVIE";
                    }

                    if (m_lstTrayMenuPreset[index1].PresetMode == 2)
                    {
                        szValue = "EFFECT_MODE_FREESTYLE";
                    }

                    configFile.SetConfig("$TRAY_MENU_PRESET_NAME_" + num2.ToString(), m_lstTrayMenuPreset[index1].PresetName);
                    configFile.SetConfig("$TRAY_MENU_PRESET_MODE_" + num2.ToString(), szValue);
                    configFile.SetConfig("$TRAY_MENU_PRESET_FILE_" + num2.ToString(), m_lstTrayMenuPreset[index1].PresetFile);
                    ++num2;
                }
            }
        }


        private void TrayMenu_ExitApplication(object sender, EventArgs e)
        {
            Parameters.SaveLocalPreset(m_szLocalPreset, m_paramBaseSystem, m_paramMusicMode, m_paramMovieMode, m_paramFreestyle);
            SaveAppSettings();
            Application.Exit();
        }

        private void TrayMenu_SwitchEffectOnOff(object sender, EventArgs e)
        {
            if (sender == null || sender.GetType() != typeof(ToolStripMenuItem))
            {
                return;
            }

            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            m_paramBaseSystem.m_bEffectEnabled = m_paramBaseSystem.m_bEffectEnabled != 0 ? 0 : 1;
            if (m_paramBaseSystem.m_bEffectEnabled == 0)
            {
                toolStripMenuItem.Text = GlobalMessages.SWITCH_ON_EFFECT;
            }
            else
            {
                toolStripMenuItem.Text = GlobalMessages.SWITCH_OFF_EFFECT;
            }

            UpdateAllControlsFromParameters();
        }






        private float PostVolumeToFloat(float fPostVolume)
        {
            return fPostVolume / 6f;
        }

        private float FloatToPostVolume(float fValue)
        {
            return fValue * 6f;
        }

        private float BassSpeakerSizeToFloat(int nSpkSize)
        {
            return 1f - (float)((nSpkSize - 40.0) / 85.0);
        }

        private int FloatToBassSpeakerSize(float fValue)
        {
            fValue = 1f - fValue;
            int num = (int)(fValue * 85.0 + 40.0);
            if (num < 40)
            {
                num = 40;
            }

            if (num > 125)
            {
                num = 125;
            }

            return num;
        }

        private float BassGainToFloat(float fBassGain)
        {
            return fBassGain / 7f;
        }

        private float FloatToBassGain(float fValue)
        {
            return fValue * 7f;
        }

        private float ClarityToFloat(float fClarity)
        {
            return fClarity / 2f;
        }

        public float FloatToClarity(float fValue)
        {
            return fValue * 2f;
        }

        public float Surround3DToFloat(float fSurround3D)
        {
            float num = (float)((fSurround3D - 1.0) / 2.0);
            if (num < 0.0)
            {
                num = 0.0f;
            }

            if (num > 1.0)
            {
                num = 1f;
            }

            return num;
        }

        public float FloatToSurround3D(float fValue)
        {
            return (float)(fValue * 2.0 + 1.0);
        }

        public float SVCSToFloat(float fSVCS)
        {
            return (float)((fSVCS - 0.5) / 4.5);
        }

        public float FloatToSVCS(float fValue)
        {
            return (float)(fValue * 4.5 + 0.5);
        }

        public float SVMaxLevelToFloat(float fSVMaxLevel)
        {
            return (float)((fSVMaxLevel - 1.0) / 9.0);
        }

        public float FloatToSVMaxLevel(float fValue)
        {
            return (float)(fValue * 9.0 + 1.0);
        }

        public float SVLevelToFloat(float fSVLevel)
        {
            return (float)((fSVLevel - 0.200000002980232) / 0.800000011920929);
        }

        public float FloatToSVLevel(float fValue)
        {
            return (float)(fValue * 0.800000011920929 + 0.200000002980232);
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            try
            {
                if (!((sender as ToolStripMenuItem).Tag is string tag) || !(tag != ""))
                {
                    return;
                }

                string szValue = new ConfigFile(tag).ReadConfig("$LANGUAGE_NAME");
                if (szValue == "")
                {
                    return;
                }

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                if (!baseDirectory.EndsWith("\\"))
                {
                    baseDirectory += "\\";
                }

                new ConfigFile(baseDirectory + "Config.ini").SetConfig("$LANGUAGE_NAME", szValue);
                if (MessageBox.Show(GlobalMessages.LANGUAGE_CHANGE_NOTICE, GlobalMessages.INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                Application.Exit();
            }
            catch
            {
            }
        }

        private void UpdateAllControlsFromParameters()
        {
            onOffSwitch_Master.SwitchedOn = m_paramBaseSystem.m_bEffectEnabled != 0;
            //if (m_paramBaseSystem.m_nEffectMode == 0U)
            //{
            //    buttonBox_Mode.SelectItem(0);
            //}
            //else if (m_paramBaseSystem.m_nEffectMode == 1U)
            //{
            //    buttonBox_Mode.SelectItem(1);
            //}
            //else if (m_paramBaseSystem.m_nEffectMode == 2U)
            //{
            //    buttonBox_Mode.SelectItem(2);
            //}

            //Music_hSlider_PreVolume.PositionFloat = m_paramMusicMode.m_rPreVolume;
            //Music_hSlider_PostVolume.PositionFloat = PostVolumeToFloat(m_paramMusicMode.m_rPostVolume);
            //Music_onOffSwitch_Convolver.SwitchedOn = m_paramMusicMode.m_bConvolverEnabled != 0;
            //Music_openFileBox_ConvIRS.FilePathName = RuntimeUtils.GeneralUtils.CharArrayToString(m_paramMusicMode.m_szConvolverIR);
            //Music_hSlider_ConvIRGain.PositionFloat = m_paramMusicMode.m_rConvolverIRGain;
            //Music_onOffSwitch_Surround.SwitchedOn = m_paramMusicMode.m_bSurroundEnabled != 0;
            //Music_buttonBox_SurroundRoomSize.SelectItem(m_paramMusicMode.m_nVHERoomSize);
            //Music_onOffSwitch_Bass.SwitchedOn = m_paramMusicMode.m_bViPERBassEnabled != 0;
            //Music_hSlider_BassSpkSize.PositionFloat = BassSpeakerSizeToFloat(m_paramMusicMode.m_nViPERBassSpkSize);
            //Music_hSlider_BassGain.PositionFloat = BassGainToFloat(m_paramMusicMode.m_rViPERBassFactor);
            //Music_onOffSwitch_Clarity.SwitchedOn = m_paramMusicMode.m_bViPERClarityEnabled != 0;
            //Music_buttonBox_ClarityMode.SelectItem(m_paramMusicMode.m_nViPERClarityMode);
            //Music_hSlider_Clarity.PositionFloat = ClarityToFloat(m_paramMusicMode.m_rViPERClarityFactor);
            //Music_onOffSwitch_Cure.SwitchedOn = m_paramMusicMode.m_bCureEnabled != 0;
            //if (m_paramMusicMode.m_uiCureLevel == 6226570U)
            //{
            //    Music_buttonBox_CureLevel.SelectItem(0);
            //}
            //else if (m_paramMusicMode.m_uiCureLevel == 3932860U)
            //{
            //    Music_buttonBox_CureLevel.SelectItem(1);
            //}
            //else if (m_paramMusicMode.m_uiCureLevel == 2949820U)
            //{
            //    Music_buttonBox_CureLevel.SelectItem(2);
            //}

            //Music_onOffSwitch_Tube.SwitchedOn = m_paramMusicMode.m_bTubeEnabled != 0;
            //Music_onOffSwitch_Reverb.SwitchedOn = m_paramMusicMode.m_bReverbEnabled != 0;
            //Music_hSlider_ReverbSize.PositionFloat = m_paramMusicMode.m_rReverbSize;
            //Music_hSlider_ReverbDamping.PositionFloat = m_paramMusicMode.m_rReverbDamping;
            //Music_hSlider_ReverbDensity.PositionFloat = m_paramMusicMode.m_rReverbDensity;
            //Music_hSlider_ReverbBandWidth.PositionFloat = m_paramMusicMode.m_rReverbBandwidth;
            //Music_hSlider_ReverbDecay.PositionFloat = m_paramMusicMode.m_rReverbDecay;
            //Music_hSlider_ReverbPreDelay.PositionFloat = m_paramMusicMode.m_rReverbPredelay;
            //Music_hSlider_ReverbEarlyMix.PositionFloat = m_paramMusicMode.m_rReverbEarlyMix;
            //Music_hSlider_ReverbMix.PositionFloat = m_paramMusicMode.m_rReverbMix;
            //Movie_hSlider_PreVolume.PositionFloat = m_paramMovieMode.m_rPreVolume;
            //Movie_hSlider_PostVolume.PositionFloat = PostVolumeToFloat(m_paramMovieMode.m_rPostVolume);
            //Movie_onOffSwitch_Convolver.SwitchedOn = m_paramMovieMode.m_bConvolverEnabled != 0;
            //Movie_openFileBox_ConvIRS.FilePathName = RuntimeUtils.GeneralUtils.CharArrayToString(m_paramMovieMode.m_szConvolverIR);
            //Movie_hSlider_ConvIRGain.PositionFloat = m_paramMovieMode.m_rConvolverIRGain;
            //Movie_onOffSwitch_Surround.SwitchedOn = m_paramMovieMode.m_bSurroundEnabled != 0;
            //Movie_hSlider_Surround3D.PositionFloat = Surround3DToFloat(m_paramMovieMode.m_r3DSurroundStereo);
            //Movie_hSlider_SurroundImage.PositionFloat = Surround3DToFloat(m_paramMovieMode.m_r3DSurroundImage);
            //Movie_onOffSwitch_Bass.SwitchedOn = m_paramMovieMode.m_bViPERBassEnabled != 0;
            //Movie_hSlider_BassSpkSize.PositionFloat = BassSpeakerSizeToFloat(m_paramMovieMode.m_nViPERBassSpkSize);
            //Movie_hSlider_BassGain.PositionFloat = BassGainToFloat(m_paramMovieMode.m_rViPERBassFactor);
            //Movie_onOffSwitch_Clarity.SwitchedOn = m_paramMovieMode.m_bViPERClarityEnabled != 0;
            //Movie_hSlider_Clarity.PositionFloat = ClarityToFloat(m_paramMovieMode.m_rViPERClarityFactor);
            //Movie_onOffSwitch_SmartVolume.SwitchedOn = m_paramMovieMode.m_bSmartVolumeEnabled != 0;
            //Movie_hSlider_SmartVolumeRatio.PositionFloat = SVCSToFloat(m_paramMovieMode.m_rSVRatio);
            //Movie_hSlider_SmartVolumeMaxLevel.PositionFloat = SVMaxLevelToFloat(m_paramMovieMode.m_rSVMaxGain);
            //Movie_hSlider_SmartVolumeLevel.PositionFloat = SVLevelToFloat(m_paramMovieMode.m_rSVVolume);
            //Movie_onOffSwitch_Reverb.SwitchedOn = m_paramMovieMode.m_bReverbEnabled != 0;
            //Movie_hSlider_ReverbSize.PositionFloat = m_paramMovieMode.m_rReverbSize;
            //Movie_hSlider_ReverbDamping.PositionFloat = m_paramMovieMode.m_rReverbDamping;
            //Movie_hSlider_ReverbDensity.PositionFloat = m_paramMovieMode.m_rReverbDensity;
            //Movie_hSlider_ReverbBandWidth.PositionFloat = m_paramMovieMode.m_rReverbBandwidth;
            //Movie_hSlider_ReverbDecay.PositionFloat = m_paramMovieMode.m_rReverbDecay;
            //Movie_hSlider_ReverbPreDelay.PositionFloat = m_paramMovieMode.m_rReverbPredelay;
            //Movie_hSlider_ReverbEarlyMix.PositionFloat = m_paramMovieMode.m_rReverbEarlyMix;
            //Movie_hSlider_ReverbMix.PositionFloat = m_paramMovieMode.m_rReverbMix;
            Freestyle_hSlider_PreVolume.PositionFloat = m_paramFreestyle.m_rPreVolume;
            Freestyle_hSlider_PostVolume.PositionFloat = PostVolumeToFloat(m_paramFreestyle.m_rPostVolume);
            Freestyle_onOffSwitch_Convolver.SwitchedOn = m_paramFreestyle.m_bConvolverEnabled != 0;
            Freestyle_openFileBox_ConvIRS.FilePathName = RuntimeUtils.GeneralUtils.CharArrayToString(m_paramFreestyle.m_szConvolverIR);
            Freestyle_hSlider_ConvIRGain.PositionFloat = m_paramFreestyle.m_rConvolverIRGain;
            Freestyle_onOffSwitch_Surround3D.SwitchedOn = m_paramFreestyle.m_b3DSurroundEnabled != 0;
            Freestyle_hSlider_Surround3D.PositionFloat = Surround3DToFloat(m_paramFreestyle.m_r3DSurroundStereo);
            Freestyle_hSlider_SurroundImage.PositionFloat = Surround3DToFloat(m_paramFreestyle.m_r3DSurroundImage);
            Freestyle_onOffSwitch_SurroundVHE.SwitchedOn = m_paramFreestyle.m_bVHESurroundEnabled != 0;
            Freestyle_buttonBox_SurroundVHERoomSize.SelectItem(m_paramFreestyle.m_nVHERoomSize);
            Freestyle_onOffSwitch_Bass.SwitchedOn = m_paramFreestyle.m_bViPERBassEnabled != 0;
            Freestyle_buttonBox_BassMode.SelectItem(m_paramFreestyle.m_nViPERBassMode);
            Freestyle_hSlider_BassSpkSize.PositionFloat = BassSpeakerSizeToFloat(m_paramFreestyle.m_nViPERBassSpkSize);
            Freestyle_hSlider_BassGain.PositionFloat = BassGainToFloat(m_paramFreestyle.m_rViPERBassFactor);
            Freestyle_onOffSwitch_Clarity.SwitchedOn = m_paramFreestyle.m_bViPERClarityEnabled != 0;
            Freestyle_buttonBox_ClarityMode.SelectItem(m_paramFreestyle.m_nViPERClarityMode);
            Freestyle_hSlider_Clarity.PositionFloat = ClarityToFloat(m_paramFreestyle.m_rViPERClarityFactor);
            Freestyle_onOffSwitch_Cure.SwitchedOn = m_paramFreestyle.m_bCureEnabled != 0;
            if (m_paramFreestyle.m_uiCureLevel == 6226570U)
            {
                Freestyle_buttonBox_CureLevel.SelectItem(0);
            }
            else if (m_paramFreestyle.m_uiCureLevel == 3932860U)
            {
                Freestyle_buttonBox_CureLevel.SelectItem(1);
            }
            else if (m_paramFreestyle.m_uiCureLevel == 2949820U)
            {
                Freestyle_buttonBox_CureLevel.SelectItem(2);
            }

            Freestyle_onOffSwitch_Tube.SwitchedOn = m_paramFreestyle.m_bTubeEnabled != 0;
            Freestyle_onOffSwitch_SmartVolume.SwitchedOn = m_paramFreestyle.m_bSmartVolumeEnabled != 0;
            Freestyle_hSlider_SmartVolumeRatio.PositionFloat = SVCSToFloat(m_paramFreestyle.m_rSVRatio);
            Freestyle_hSlider_SmartVolumeMaxLevel.PositionFloat = SVMaxLevelToFloat(m_paramFreestyle.m_rSVMaxGain);
            Freestyle_hSlider_SmartVolumeLevel.PositionFloat = SVLevelToFloat(m_paramFreestyle.m_rSVVolume);
            Freestyle_onOffSwitch_Reverb.SwitchedOn = m_paramFreestyle.m_bReverbEnabled != 0;
            Freestyle_hSlider_ReverbSize.PositionFloat = m_paramFreestyle.m_rReverbSize;
            Freestyle_hSlider_ReverbDamping.PositionFloat = m_paramFreestyle.m_rReverbDamping;
            Freestyle_hSlider_ReverbDensity.PositionFloat = m_paramFreestyle.m_rReverbDensity;
            Freestyle_hSlider_ReverbBandWidth.PositionFloat = m_paramFreestyle.m_rReverbBandwidth;
            Freestyle_hSlider_ReverbDecay.PositionFloat = m_paramFreestyle.m_rReverbDecay;
            Freestyle_hSlider_ReverbPreDelay.PositionFloat = m_paramFreestyle.m_rReverbPredelay;
            Freestyle_hSlider_ReverbEarlyMix.PositionFloat = m_paramFreestyle.m_rReverbEarlyMix;
            Freestyle_hSlider_ReverbMix.PositionFloat = m_paramFreestyle.m_rReverbMix;
        }

        private void toolStripMenuItem_LatencySetting_Click(object sender, EventArgs e)
        {
            frmLatency frmLatency = new frmLatency
            {
                ShortFilterLen = m_paramBaseSystem.m_nFilterShortLen,
                MiddleFilterLen = m_paramBaseSystem.m_nFilterMediumLen,
                LongFilterLen = m_paramBaseSystem.m_nFilterLongLen
            };
            if (frmLatency.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramBaseSystem.m_nFilterShortLen = frmLatency.ShortFilterLen;
            m_paramBaseSystem.m_nFilterMediumLen = frmLatency.MiddleFilterLen;
            m_paramBaseSystem.m_nFilterLongLen = frmLatency.LongFilterLen;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void toolStripMenuItem_ChannelPan_Click(object sender, EventArgs e)
        {
            frmChannelPan frmChannelPan = new frmChannelPan
            {
                ChannelPan = m_paramBaseSystem.m_rChannelPan
            };
            int num = (int)frmChannelPan.ShowDialog();
            m_paramBaseSystem.m_rChannelPan = frmChannelPan.ChannelPan;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void toolStripMenuItem_Virtualization_Click(object sender, EventArgs e)
        {
            metroFormVirt frmVirtualization = new metroFormVirt();
            frmVirtualization.SetBaseSystemParam(m_paramBaseSystem);
            if (frmVirtualization.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramBaseSystem = frmVirtualization.GetBaseSystemParam();
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void toolStripMenuItem_ResetEffect_Click(object sender, EventArgs e)
        {
            Parameters.LoadDefaultParameter(ref m_paramMusicMode);
            Parameters.LoadDefaultParameter(ref m_paramMovieMode);
            Parameters.LoadDefaultParameter(ref m_paramFreestyle);
            UpdateAllControlsFromParameters();
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            uint num1 = RegHelper.QueryDWORD("LoadChildAPO", 0U);
            frmSettings frmSettings = new frmSettings();
            frmSettings.SetPresetPath(m_szPresetsPath);
            // frmSettings.SetCloseToTray(m_bCloseToTray);
            frmSettings.SetTrayMenuPresetList(m_lstTrayMenuPreset);
            if (frmSettings.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_bCloseToTray = frmSettings.GetCloseToTray();
            List<TrayMenuPreset> trayMenuPresetList = frmSettings.GetTrayMenuPresetList();
            m_lstTrayMenuPreset.Clear();
            foreach (TrayMenuPreset trayMenuPreset in trayMenuPresetList)
            {
                if (trayMenuPreset.Valid())
                {
                    if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
                    {
                        trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
                    }

                    m_lstTrayMenuPreset.Add(trayMenuPreset.Clone());
                }
            }
            SaveAppSettings();
            uint uiValue = !frmSettings.GetAPOCoexistEnabled() ? 0U : 1U;
            if ((int)uiValue == (int)num1)
            {
                return;
            }

            RegHelper.WriteDWORD("LoadChildAPO", uiValue);
            if (uiValue == 1U)
            {
                int num2 = (int)MessageBox.Show(GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE1 + "\n" + GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE2 + "\n\n" + GlobalMessages.ENABLE_APO_COEXIST_RESTART, GlobalMessages.ENABLE_APO_COEXIST, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int num3 = (int)MessageBox.Show(GlobalMessages.ENABLE_APO_COEXIST_RESTART, GlobalMessages.ENABLE_APO_COEXIST, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        CheckUpdates CheckUpdate;
        private void toolStripMenuItem_CheckUpdate_Click(object sender, EventArgs e)
        {
            if (IsAdministrator())
                CheckUpdate.UpdaterProg(messageBoxCaller);
            else messageBoxCaller("This is require admin rights", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void toolStripMenuItem_AboutV4W_Click(object sender, EventArgs e)
        {
            int num = (int)new frmAbout().ShowDialog();
        }

        private void onOffSwitch_Master_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_paramBaseSystem.m_bEffectEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void buttonBox_Mode_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            if (tag == 0.ToString())
            {
                //       panel_MusicMode.Visible = true;
                //panel_MovieMode.Visible = false;
                //panel_Freestyle.Visible = false;
                m_paramBaseSystem.m_nEffectMode = 0U;
                m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
                m_cpConfigProxy.SyncConfig();
            }
            else if (tag == 1.ToString())
            {
                //panel_MusicMode.Visible = false;
                //panel_MovieMode.Visible = true;
                //panel_Freestyle.Visible = false;
                m_paramBaseSystem.m_nEffectMode = 1U;
                m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
                m_cpConfigProxy.SyncConfig();
            }
            else
            {
                if (!(tag == 2.ToString()))
                {
                    return;
                }

                //    panel_MusicMode.Visible = false;
                //   panel_MovieMode.Visible = false;
                //panel_Freestyle.Visible = true;
                m_paramBaseSystem.m_nEffectMode = 2U;
                m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
                m_cpConfigProxy.SyncConfig();
            }
        }

        private void singleButton_LoadPreset_ButtonClickNotify(SingleButton objSender)
        {

        }

        private void singleButton_SavePreset_ButtonClickNotify(SingleButton objSender)
        {

        }

        private void Freestyle_hSlider_PreVolume_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramFreestyle.m_rPreVolume = fPercent;
            Freestyle_label_PreVolume.Text = GlobalMessages.PRE_VOLUME + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_PostVolume_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rPostVolume = FloatToPostVolume(fPercent);
            Freestyle_label_PostVolume.Text = GlobalMessages.POST_VOLUME + " : " + (20.0 * Math.Log10(FloatToPostVolume(fPercent) + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Convolver_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bConvolverEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ConvIRGain_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rConvolverIRGain = fPercent;
            Freestyle_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_openFileBox_ConvIRS_FileChangeNotify(
          string szFilePathName,
          OpenFileBox objSender)
        {
            m_paramFreestyle.m_szConvolverIR = Parameters.WriteStringToArray260(szFilePathName);
            Freestyle_irShape_ConvIR.SetImpulseResponse(RuntimeUtils.ImpulseResponseUtils.EstimateImpulseResponseSample(szFilePathName, out int nChannelCount), nChannelCount);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Surround3D_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_b3DSurroundEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_Surround3D_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_r3DSurroundStereo = FloatToSurround3D(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_SurroundImage_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_r3DSurroundImage = FloatToSurround3D(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_SurroundVHE_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bVHESurroundEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_buttonBox_SurroundVHERoomSize_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 4)
            {
                return;
            }

            m_paramFreestyle.m_nVHERoomSize = result;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Bass_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bViPERBassEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_BassSpkSize_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_nViPERBassSpkSize = FloatToBassSpeakerSize(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_BassGain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramFreestyle.m_rViPERBassFactor = FloatToBassGain(fPercent);
            Freestyle_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN + " : " + (20.0 * Math.Log10(FloatToBassGain(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_buttonBox_BassMode_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 1)
            {
                return;
            }

            m_paramFreestyle.m_nViPERBassMode = result;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Clarity_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bViPERClarityEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_buttonBox_ClarityMode_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 2)
            {
                return;
            }

            m_paramFreestyle.m_nViPERClarityMode = result;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_Clarity_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramFreestyle.m_rViPERClarityFactor = FloatToClarity(fPercent);
            Freestyle_label_Clarity.Text = GlobalMessages.CLARITY + " : " + (20.0 * Math.Log10(FloatToClarity(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Cure_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bCureEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_buttonBox_CureLevel_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            if (tag == 6226570U.ToString())
            {
                m_paramFreestyle.m_uiCureLevel = 6226570U;
                m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
                m_cpConfigProxy.SyncConfig();
            }
            else if (tag == 3932860U.ToString())
            {
                m_paramFreestyle.m_uiCureLevel = 3932860U;
                m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
                m_cpConfigProxy.SyncConfig();
            }
            else
            {
                if (!(tag == 2949820U.ToString()))
                {
                    return;
                }

                m_paramFreestyle.m_uiCureLevel = 2949820U;
                m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
                m_cpConfigProxy.SyncConfig();
            }
        }

        private void Freestyle_onOffSwitch_Tube_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bTubeEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_SmartVolume_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bSmartVolumeEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_SmartVolumeRatio_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rSVRatio = FloatToSVCS(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_SmartVolumeMaxLevel_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rSVMaxGain = FloatToSVMaxLevel(fPercent);
            Freestyle_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL + " : " + FloatToSVMaxLevel(fPercent).ToString("F02") + "x";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_SmartVolumeLevel_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rSVVolume = FloatToSVLevel(fPercent);
            Freestyle_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL + " : " + (20.0 * Math.Log10(FloatToSVLevel(fPercent))).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_onOffSwitch_Reverb_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramFreestyle.m_bReverbEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_singleButton_ReverbPreset_ButtonClickNotify(SingleButton objSender)
        {

            frmReverbPreset frmReverbPreset = new frmReverbPreset
            {
                ReverbSize = m_paramFreestyle.m_rReverbSize,
                ReverbDamping = m_paramFreestyle.m_rReverbDamping,
                ReverbDensity = m_paramFreestyle.m_rReverbDensity,
                ReverbBandwidth = m_paramFreestyle.m_rReverbBandwidth,
                ReverbDecay = m_paramFreestyle.m_rReverbDecay,
                ReverbPredelay = m_paramFreestyle.m_rReverbPredelay,
                ReverbEarlyMix = m_paramFreestyle.m_rReverbEarlyMix,
                ReverbMix = m_paramFreestyle.m_rReverbMix
            };
            if (frmReverbPreset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramFreestyle.m_rReverbSize = frmReverbPreset.ReverbSize;
            m_paramFreestyle.m_rReverbDamping = frmReverbPreset.ReverbDamping;
            m_paramFreestyle.m_rReverbDensity = frmReverbPreset.ReverbDensity;
            m_paramFreestyle.m_rReverbBandwidth = frmReverbPreset.ReverbBandwidth;
            m_paramFreestyle.m_rReverbDecay = frmReverbPreset.ReverbDecay;
            m_paramFreestyle.m_rReverbPredelay = frmReverbPreset.ReverbPredelay;
            m_paramFreestyle.m_rReverbEarlyMix = frmReverbPreset.ReverbEarlyMix;
            m_paramFreestyle.m_rReverbMix = frmReverbPreset.ReverbMix;
            Freestyle_hSlider_ReverbSize.PositionFloat = m_paramFreestyle.m_rReverbSize;
            Freestyle_hSlider_ReverbDamping.PositionFloat = m_paramFreestyle.m_rReverbDamping;
            Freestyle_hSlider_ReverbDensity.PositionFloat = m_paramFreestyle.m_rReverbDensity;
            Freestyle_hSlider_ReverbBandWidth.PositionFloat = m_paramFreestyle.m_rReverbBandwidth;
            Freestyle_hSlider_ReverbDecay.PositionFloat = m_paramFreestyle.m_rReverbDecay;
            Freestyle_hSlider_ReverbPreDelay.PositionFloat = m_paramFreestyle.m_rReverbPredelay;
            Freestyle_hSlider_ReverbEarlyMix.PositionFloat = m_paramFreestyle.m_rReverbEarlyMix;
            Freestyle_hSlider_ReverbMix.PositionFloat = m_paramFreestyle.m_rReverbMix;
        }

        private void Freestyle_hSlider_ReverbSize_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbSize = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbDamping_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbDamping = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbDensity_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbDensity = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbBandWidth_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbBandwidth = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbDecay_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbDecay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbPreDelay_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbPredelay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbEarlyMix_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramFreestyle.m_rReverbEarlyMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_hSlider_ReverbMix_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramFreestyle.m_rReverbMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void Freestyle_singleButton_Equalizer_ButtonClickNotify(SingleButton objSender)
        {

        }

        private void Freestyle_singleButton_Compressor_ButtonClickNotify(SingleButton objSender)
        {

        }

        private void Movie_hSlider_PreVolume_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rPreVolume = fPercent;
            //   Movie_label_PreVolume.Text = GlobalMessages.PRE_VOLUME + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_PostVolume_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rPostVolume = FloatToPostVolume(fPercent);
            //      Movie_label_PostVolume.Text = GlobalMessages.POST_VOLUME + " : " + (20.0 * Math.Log10(FloatToPostVolume(fPercent) + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_Convolver_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bConvolverEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ConvIRGain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rConvolverIRGain = fPercent;
            //     Movie_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_openFileBox_ConvIRS_FileChangeNotify(
          string szFilePathName,
          OpenFileBox objSender)
        {
            m_paramMovieMode.m_szConvolverIR = Parameters.WriteStringToArray260(szFilePathName);
            //    Movie_irShape_ConvIR.SetImpulseResponse(RuntimeUtils.ImpulseResponseUtils.EstimateImpulseResponseSample(szFilePathName, out int nChannelCount), nChannelCount);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_Surround_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bSurroundEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_Surround3D_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_r3DSurroundStereo = FloatToSurround3D(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_SurroundImage_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_r3DSurroundImage = FloatToSurround3D(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_Bass_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bViPERBassEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_BassSpkSize_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_nViPERBassSpkSize = FloatToBassSpeakerSize(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_BassGain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rViPERBassFactor = FloatToBassGain(fPercent);
            //     Movie_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN + " : " + (20.0 * Math.Log10(FloatToBassGain(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_Clarity_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bViPERClarityEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_Clarity_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rViPERClarityFactor = FloatToClarity(fPercent);
            //  Movie_label_Clarity.Text = GlobalMessages.CLARITY + " : " + (20.0 * Math.Log10(FloatToClarity(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_SmartVolume_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bSmartVolumeEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_SmartVolumeRatio_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rSVRatio = FloatToSVCS(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_SmartVolumeMaxLevel_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rSVMaxGain = FloatToSVMaxLevel(fPercent);
            //    Movie_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL + " : " + FloatToSVMaxLevel(fPercent).ToString("F02") + "x";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_SmartVolumeLevel_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rSVVolume = FloatToSVLevel(fPercent);
            //      Movie_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL + " : " + (20.0 * Math.Log10(FloatToSVLevel(fPercent))).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_onOffSwitch_Reverb_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMovieMode.m_bReverbEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_singleButton_ReverbPreset_ButtonClickNotify(SingleButton objSender)
        {
            frmReverbPreset frmReverbPreset = new frmReverbPreset
            {
                ReverbSize = m_paramMovieMode.m_rReverbSize,
                ReverbDamping = m_paramMovieMode.m_rReverbDamping,
                ReverbDensity = m_paramMovieMode.m_rReverbDensity,
                ReverbBandwidth = m_paramMovieMode.m_rReverbBandwidth,
                ReverbDecay = m_paramMovieMode.m_rReverbDecay,
                ReverbPredelay = m_paramMovieMode.m_rReverbPredelay,
                ReverbEarlyMix = m_paramMovieMode.m_rReverbEarlyMix,
                ReverbMix = m_paramMovieMode.m_rReverbMix
            };
            if (frmReverbPreset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramMovieMode.m_rReverbSize = frmReverbPreset.ReverbSize;
            m_paramMovieMode.m_rReverbDamping = frmReverbPreset.ReverbDamping;
            m_paramMovieMode.m_rReverbDensity = frmReverbPreset.ReverbDensity;
            m_paramMovieMode.m_rReverbBandwidth = frmReverbPreset.ReverbBandwidth;
            m_paramMovieMode.m_rReverbDecay = frmReverbPreset.ReverbDecay;
            m_paramMovieMode.m_rReverbPredelay = frmReverbPreset.ReverbPredelay;
            m_paramMovieMode.m_rReverbEarlyMix = frmReverbPreset.ReverbEarlyMix;
            m_paramMovieMode.m_rReverbMix = frmReverbPreset.ReverbMix;
            //Movie_hSlider_ReverbSize.PositionFloat = m_paramMovieMode.m_rReverbSize;
            //Movie_hSlider_ReverbDamping.PositionFloat = m_paramMovieMode.m_rReverbDamping;
            //Movie_hSlider_ReverbDensity.PositionFloat = m_paramMovieMode.m_rReverbDensity;
            //Movie_hSlider_ReverbBandWidth.PositionFloat = m_paramMovieMode.m_rReverbBandwidth;
            //Movie_hSlider_ReverbDecay.PositionFloat = m_paramMovieMode.m_rReverbDecay;
            //Movie_hSlider_ReverbPreDelay.PositionFloat = m_paramMovieMode.m_rReverbPredelay;
            //Movie_hSlider_ReverbEarlyMix.PositionFloat = m_paramMovieMode.m_rReverbEarlyMix;
            //Movie_hSlider_ReverbMix.PositionFloat = m_paramMovieMode.m_rReverbMix;
        }

        private void Movie_hSlider_ReverbSize_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rReverbSize = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbDamping_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rReverbDamping = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbDensity_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rReverbDensity = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbBandWidth_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rReverbBandwidth = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbDecay_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rReverbDecay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbPreDelay_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rReverbPredelay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbEarlyMix_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMovieMode.m_rReverbEarlyMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_hSlider_ReverbMix_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMovieMode.m_rReverbMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_singleButton_Equalizer_ButtonClickNotify(SingleButton objSender)
        {
            frmEqualizer frmEqualizer = new frmEqualizer();
            frmEqualizer.SetRealtimeParameters(m_paramBaseSystem, m_paramMusicMode, m_paramMovieMode, m_paramFreestyle, m_cpConfigProxy);
            if (m_paramMovieMode.m_bEqualizerEnabled == 0)
            {
                frmEqualizer.SetParameters(m_paramMovieMode.m_rpEqualizerBands, false);
            }
            else
            {
                frmEqualizer.SetParameters(m_paramMovieMode.m_rpEqualizerBands, true);
            }

            int num = (int)frmEqualizer.ShowDialog();
            m_paramMovieMode.m_bEqualizerEnabled = !frmEqualizer.GetEQEnabled() ? 0 : 1;
            if (frmEqualizer.GetParameter() != null)
            {
                m_paramMovieMode.m_rpEqualizerBands = frmEqualizer.GetParameter();
            }

            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Movie_singleButton_Compressor_ButtonClickNotify(SingleButton objSender)
        {
            frmCompressorLite frmCompressorLite = new frmCompressorLite
            {
                CompressorEnabled = m_paramMovieMode.m_bCompressorEnabled != 0,
                AutoKnee = m_paramMovieMode.m_bCompAutoKnee != 0,
                AutoAttack = m_paramMovieMode.m_bCompAutoAttack != 0,
                AutoRelease = m_paramMovieMode.m_bCompAutoRelease != 0,
                AutoGain = m_paramMovieMode.m_bCompAutoGain != 0,
                Threshold = m_paramMovieMode.m_rCompThreshold,
                KneeWidth = m_paramMovieMode.m_rCompKneeWidth,
                Ratio = m_paramMovieMode.m_rCompRatio,
                AttackTime = m_paramMovieMode.m_rCompAttack,
                ReleaseTime = m_paramMovieMode.m_rCompRelease,
                MakeupGain = m_paramMovieMode.m_rCompGain
            };
            if (frmCompressorLite.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramMovieMode.m_bCompressorEnabled = !frmCompressorLite.CompressorEnabled ? 0 : 1;
            m_paramMovieMode.m_bCompAutoKnee = !frmCompressorLite.AutoKnee ? 0 : 1;
            m_paramMovieMode.m_bCompAutoAttack = !frmCompressorLite.AutoAttack ? 0 : 1;
            m_paramMovieMode.m_bCompAutoRelease = !frmCompressorLite.AutoRelease ? 0 : 1;
            m_paramMovieMode.m_bCompAutoGain = !frmCompressorLite.AutoGain ? 0 : 1;
            m_paramMovieMode.m_rCompThreshold = frmCompressorLite.Threshold;
            m_paramMovieMode.m_rCompKneeWidth = frmCompressorLite.KneeWidth;
            m_paramMovieMode.m_rCompRatio = frmCompressorLite.Ratio;
            m_paramMovieMode.m_rCompAttack = frmCompressorLite.AttackTime;
            m_paramMovieMode.m_rCompRelease = frmCompressorLite.ReleaseTime;
            m_paramMovieMode.m_rCompGain = frmCompressorLite.MakeupGain;
            m_cpConfigProxy.UpdateParameter(m_paramMovieMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_PreVolume_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rPreVolume = fPercent;
            //   Music_label_PreVolume.Text = GlobalMessages.PRE_VOLUME + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_PostVolume_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rPostVolume = FloatToPostVolume(fPercent);
            //     Music_label_PostVolume.Text = GlobalMessages.POST_VOLUME + " : " + (20.0 * Math.Log10(FloatToPostVolume(fPercent) + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Convolver_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bConvolverEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ConvIRGain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rConvolverIRGain = fPercent;
            //  Music_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN + " : " + (20.0 * Math.Log10(fPercent + 1E-06)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_openFileBox_ConvIRS_FileChangeNotify(
          string szFilePathName,
          OpenFileBox objSender)
        {
            m_paramMusicMode.m_szConvolverIR = Parameters.WriteStringToArray260(szFilePathName);
            //    Music_irShape_ConvIR.SetImpulseResponse(RuntimeUtils.ImpulseResponseUtils.EstimateImpulseResponseSample(szFilePathName, out int nChannelCount), nChannelCount);
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Surround_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bSurroundEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_buttonBox_SurroundRoomSize_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 4)
            {
                return;
            }

            m_paramMusicMode.m_nVHERoomSize = result;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Bass_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bViPERBassEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_BassSpkSize_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_nViPERBassSpkSize = FloatToBassSpeakerSize(fPercent);
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_BassGain_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rViPERBassFactor = FloatToBassGain(fPercent);
            //     Music_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN + " : " + (20.0 * Math.Log10(FloatToBassGain(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Clarity_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bViPERClarityEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_buttonBox_ClarityMode_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 2)
            {
                return;
            }

            m_paramMusicMode.m_nViPERClarityMode = result;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_Clarity_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rViPERClarityFactor = FloatToClarity(fPercent);
            //    Music_label_Clarity.Text = GlobalMessages.CLARITY + " : " + (20.0 * Math.Log10(FloatToClarity(fPercent) + 1.0)).ToString("F02") + "dB";
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Cure_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bCureEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_buttonBox_CureLevel_ItemSelectedNotify(
          ButtonBox.Item itPrevItem,
          ButtonBox.Item itCurrItem,
          ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            {
                return;
            }

            if (tag == 6226570U.ToString())
            {
                m_paramMusicMode.m_uiCureLevel = 6226570U;
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
            else if (tag == 3932860U.ToString())
            {
                m_paramMusicMode.m_uiCureLevel = 3932860U;
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
            else
            {
                if (!(tag == 2949820U.ToString()))
                {
                    return;
                }

                m_paramMusicMode.m_uiCureLevel = 2949820U;
                m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
                m_cpConfigProxy.SyncConfig();
            }
        }

        private void Music_onOffSwitch_Tube_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bTubeEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_onOffSwitch_Reverb_SwitchChangeNotify(
          bool bSwitchedOn,
          OnOffSwitch objSender)
        {
            m_paramMusicMode.m_bReverbEnabled = !bSwitchedOn ? 0 : 1;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbSize_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rReverbSize = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbDamping_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rReverbDamping = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbDensity_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rReverbDensity = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbBandWidth_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMusicMode.m_rReverbBandwidth = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbDecay_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rReverbDecay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbPreDelay_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMusicMode.m_rReverbPredelay = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbEarlyMix_PositionChangeNotify(
          float fPercent,
          HSlider objSender)
        {
            m_paramMusicMode.m_rReverbEarlyMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
        }

        private void Music_hSlider_ReverbMix_PositionChangeNotify(float fPercent, HSlider objSender)
        {
            m_paramMusicMode.m_rReverbMix = fPercent;
            m_cpConfigProxy.UpdateParameter(m_paramMusicMode);
            m_cpConfigProxy.SyncConfig();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label_MasterPower = new System.Windows.Forms.Label();
            this.toolStripMenuItem_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LatencySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ChannelPan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Virtualization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ResetEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AboutV4W = new System.Windows.Forms.ToolStripMenuItem();
            this.Freestyle_label_SmartVolume_Level = new System.Windows.Forms.Label();
            this.Freestyle_label_SmartVolume_MaxLevel = new System.Windows.Forms.Label();
            this.Freestyle_label_SmartVolume_ControlStrength = new System.Windows.Forms.Label();
            this.Freestyle_singleButton_ReverbPreset1 = new Telerik.WinControls.UI.RadButton();
            this.Freestyle_label_Reverb_Mix = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_EarlyMix = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_PreDelay = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_Decay = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_BandWidth = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_Density = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_Damping = new System.Windows.Forms.Label();
            this.Freestyle_label_Reverb_Size = new System.Windows.Forms.Label();
            this.Freestyle_label_Clarity = new System.Windows.Forms.Label();
            this.Freestyle_label_Tube = new System.Windows.Forms.Label();
            this.Freestyle_label_Bass_Gain = new System.Windows.Forms.Label();
            this.Freestyle_label_Bass_SpkSize = new System.Windows.Forms.Label();
            this.Freestyle_label_Surround_Image = new System.Windows.Forms.Label();
            this.Freestyle_label_Surround_3D = new System.Windows.Forms.Label();
            this.Freestyle_label_ConvolverIRGain = new System.Windows.Forms.Label();
            this.Freestyle_label_PostVolume = new System.Windows.Forms.Label();
            this.Freestyle_label_PreVolume = new System.Windows.Forms.Label();
            this.MENU_SETTING = new Telerik.WinControls.UI.RadMenuItem();
            this.LATENCY_SETTING = new Telerik.WinControls.UI.RadMenuItem();
            this.CHANNEL_PAN = new Telerik.WinControls.UI.RadMenuItem();
            this.RESETEFFECT = new Telerik.WinControls.UI.RadMenuItem();
            this.SETTINGS = new Telerik.WinControls.UI.RadMenuItem();
            this.VIRTUALIZATION = new Telerik.WinControls.UI.RadMenuItem();
            this.CHECKUPDATE = new Telerik.WinControls.UI.RadMenuItem();
            this.ABOUTV4W = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.button_Freestyle = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.onOffSwitch_Master = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_PreVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_PostVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Freestyle_buttonBox_BassMode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_BassGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_onOffSwitch_Bass = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_BassSpkSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Freestyle_buttonBox_CureLevel = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Cure = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_onOffSwitch_Tube = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_Clarity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_buttonBox_ClarityMode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Clarity = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Freestyle_hSlider_SmartVolumeMaxLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_SmartVolumeLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_SmartVolumeRatio = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_onOffSwitch_SmartVolume = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Freestyle_openFileBox_ConvIRS = new ViPER4WindowsBin.UIControls.OpenFileBox();
            this.Freestyle_irShape_ConvIR = new ViPER4WindowsBin.UIControls.IRShape();
            this.label5 = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ConvIRGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_onOffSwitch_Convolver = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_onOffSwitch_Reverb = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_ReverbSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbEarlyMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbPreDelay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbDamping = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbDecay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbDensity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_hSlider_ReverbBandWidth = new ViPER4WindowsBin.UIControls.HSlider();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Freestyle_onOffSwitch_SurroundVHE = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_SurroundImage = new ViPER4WindowsBin.UIControls.HSlider();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_Surround3D = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_buttonBox_SurroundVHERoomSize = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Freestyle_onOffSwitch_Surround3D = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.panelUpdateDownloading = new MetroFramework.Controls.MetroPanel();
            this.progressProg = new MetroFramework.Controls.MetroProgressBar();
            this.labelKB = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Freestyle_singleButton_ReverbPreset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Freestyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelUpdateDownloading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MasterPower
            // 
            this.label_MasterPower.AutoSize = true;
            this.label_MasterPower.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MasterPower.ForeColor = System.Drawing.Color.Snow;
            this.label_MasterPower.Location = new System.Drawing.Point(24, 95);
            this.label_MasterPower.Name = "label_MasterPower";
            this.label_MasterPower.Size = new System.Drawing.Size(75, 23);
            this.label_MasterPower.TabIndex = 1;
            this.label_MasterPower.Text = "POWER";
            // 
            // toolStripMenuItem_Language
            // 
            this.toolStripMenuItem_Language.Name = "toolStripMenuItem_Language";
            this.toolStripMenuItem_Language.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem_Language.Text = "$MENU_LANGUAGE";
            // 
            // toolStripMenuItem_Setting
            // 
            this.toolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LatencySetting,
            this.toolStripMenuItem_ChannelPan,
            this.toolStripMenuItem_Virtualization,
            this.toolStripMenuItem_ResetEffect,
            this.toolStripMenuItem_Settings});
            this.toolStripMenuItem_Setting.Name = "toolStripMenuItem_Setting";
            this.toolStripMenuItem_Setting.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem_Setting.Text = "$MENU_SETTING";
            // 
            // toolStripMenuItem_LatencySetting
            // 
            this.toolStripMenuItem_LatencySetting.Name = "toolStripMenuItem_LatencySetting";
            this.toolStripMenuItem_LatencySetting.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem_LatencySetting.Text = "$LATENCY_SETTING";
            this.toolStripMenuItem_LatencySetting.Click += new System.EventHandler(this.toolStripMenuItem_LatencySetting_Click);
            // 
            // toolStripMenuItem_ChannelPan
            // 
            this.toolStripMenuItem_ChannelPan.Name = "toolStripMenuItem_ChannelPan";
            this.toolStripMenuItem_ChannelPan.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem_ChannelPan.Text = "$CHANNEL_PAN";
            this.toolStripMenuItem_ChannelPan.Click += new System.EventHandler(this.toolStripMenuItem_ChannelPan_Click);
            // 
            // toolStripMenuItem_Virtualization
            // 
            this.toolStripMenuItem_Virtualization.Name = "toolStripMenuItem_Virtualization";
            this.toolStripMenuItem_Virtualization.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem_Virtualization.Text = "$VIRTUALIZATION";
            this.toolStripMenuItem_Virtualization.Click += new System.EventHandler(this.toolStripMenuItem_Virtualization_Click);
            // 
            // toolStripMenuItem_ResetEffect
            // 
            this.toolStripMenuItem_ResetEffect.Name = "toolStripMenuItem_ResetEffect";
            this.toolStripMenuItem_ResetEffect.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem_ResetEffect.Text = "$RESET_EFFECT";
            this.toolStripMenuItem_ResetEffect.Click += new System.EventHandler(this.toolStripMenuItem_ResetEffect_Click);
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem_Settings.Text = "$SETTINGS";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_CheckUpdate,
            this.toolStripMenuItem_AboutV4W});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem_Help.Text = "$MENU_HELP";
            // 
            // toolStripMenuItem_CheckUpdate
            // 
            this.toolStripMenuItem_CheckUpdate.Name = "toolStripMenuItem_CheckUpdate";
            this.toolStripMenuItem_CheckUpdate.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem_CheckUpdate.Text = "$CHECK_UPDATE";
            this.toolStripMenuItem_CheckUpdate.Click += new System.EventHandler(this.toolStripMenuItem_CheckUpdate_Click);
            // 
            // toolStripMenuItem_AboutV4W
            // 
            this.toolStripMenuItem_AboutV4W.Name = "toolStripMenuItem_AboutV4W";
            this.toolStripMenuItem_AboutV4W.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem_AboutV4W.Text = "$ABOUT";
            this.toolStripMenuItem_AboutV4W.Click += new System.EventHandler(this.toolStripMenuItem_AboutV4W_Click);
            // 
            // Freestyle_label_SmartVolume_Level
            // 
            this.Freestyle_label_SmartVolume_Level.AutoSize = true;
            this.Freestyle_label_SmartVolume_Level.Location = new System.Drawing.Point(10, 49);
            this.Freestyle_label_SmartVolume_Level.Name = "Freestyle_label_SmartVolume_Level";
            this.Freestyle_label_SmartVolume_Level.Size = new System.Drawing.Size(185, 15);
            this.Freestyle_label_SmartVolume_Level.TabIndex = 22;
            this.Freestyle_label_SmartVolume_Level.Text = "$SMART_VOLUME_LEVEL : 0dB";
            // 
            // Freestyle_label_SmartVolume_MaxLevel
            // 
            this.Freestyle_label_SmartVolume_MaxLevel.AutoSize = true;
            this.Freestyle_label_SmartVolume_MaxLevel.Location = new System.Drawing.Point(10, 193);
            this.Freestyle_label_SmartVolume_MaxLevel.Name = "Freestyle_label_SmartVolume_MaxLevel";
            this.Freestyle_label_SmartVolume_MaxLevel.Size = new System.Drawing.Size(203, 15);
            this.Freestyle_label_SmartVolume_MaxLevel.TabIndex = 20;
            this.Freestyle_label_SmartVolume_MaxLevel.Text = "$SMART_VOLUME_MAXLEVEL : 1x";
            // 
            // Freestyle_label_SmartVolume_ControlStrength
            // 
            this.Freestyle_label_SmartVolume_ControlStrength.AutoSize = true;
            this.Freestyle_label_SmartVolume_ControlStrength.Location = new System.Drawing.Point(10, 118);
            this.Freestyle_label_SmartVolume_ControlStrength.Name = "Freestyle_label_SmartVolume_ControlStrength";
            this.Freestyle_label_SmartVolume_ControlStrength.Size = new System.Drawing.Size(248, 15);
            this.Freestyle_label_SmartVolume_ControlStrength.TabIndex = 18;
            this.Freestyle_label_SmartVolume_ControlStrength.Text = "$SMART_VOLUME_CONTROL_STRENGTH";
            // 
            // Freestyle_singleButton_ReverbPreset1
            // 
            this.Freestyle_singleButton_ReverbPreset1.Location = new System.Drawing.Point(13, 13);
            this.Freestyle_singleButton_ReverbPreset1.Name = "Freestyle_singleButton_ReverbPreset1";
            this.Freestyle_singleButton_ReverbPreset1.Size = new System.Drawing.Size(130, 32);
            this.Freestyle_singleButton_ReverbPreset1.TabIndex = 24;
            this.Freestyle_singleButton_ReverbPreset1.Text = "$PRESET";
            this.Freestyle_singleButton_ReverbPreset1.ThemeName = "VisualStudio2012Dark";
            this.Freestyle_singleButton_ReverbPreset1.Click += new System.EventHandler(this.Freestyle_singleButton_ReverbPreset1_Click);
            // 
            // Freestyle_label_Reverb_Mix
            // 
            this.Freestyle_label_Reverb_Mix.AutoSize = true;
            this.Freestyle_label_Reverb_Mix.Location = new System.Drawing.Point(10, 315);
            this.Freestyle_label_Reverb_Mix.Name = "Freestyle_label_Reverb_Mix";
            this.Freestyle_label_Reverb_Mix.Size = new System.Drawing.Size(50, 14);
            this.Freestyle_label_Reverb_Mix.TabIndex = 34;
            this.Freestyle_label_Reverb_Mix.Text = "Wet Mix";
            // 
            // Freestyle_label_Reverb_EarlyMix
            // 
            this.Freestyle_label_Reverb_EarlyMix.AutoSize = true;
            this.Freestyle_label_Reverb_EarlyMix.Location = new System.Drawing.Point(10, 281);
            this.Freestyle_label_Reverb_EarlyMix.Name = "Freestyle_label_Reverb_EarlyMix";
            this.Freestyle_label_Reverb_EarlyMix.Size = new System.Drawing.Size(56, 14);
            this.Freestyle_label_Reverb_EarlyMix.TabIndex = 32;
            this.Freestyle_label_Reverb_EarlyMix.Text = "Early Mix";
            // 
            // Freestyle_label_Reverb_PreDelay
            // 
            this.Freestyle_label_Reverb_PreDelay.AutoSize = true;
            this.Freestyle_label_Reverb_PreDelay.Location = new System.Drawing.Point(10, 247);
            this.Freestyle_label_Reverb_PreDelay.Name = "Freestyle_label_Reverb_PreDelay";
            this.Freestyle_label_Reverb_PreDelay.Size = new System.Drawing.Size(57, 14);
            this.Freestyle_label_Reverb_PreDelay.TabIndex = 30;
            this.Freestyle_label_Reverb_PreDelay.Text = "Pre-delay";
            // 
            // Freestyle_label_Reverb_Decay
            // 
            this.Freestyle_label_Reverb_Decay.AutoSize = true;
            this.Freestyle_label_Reverb_Decay.Location = new System.Drawing.Point(10, 211);
            this.Freestyle_label_Reverb_Decay.Name = "Freestyle_label_Reverb_Decay";
            this.Freestyle_label_Reverb_Decay.Size = new System.Drawing.Size(40, 14);
            this.Freestyle_label_Reverb_Decay.TabIndex = 28;
            this.Freestyle_label_Reverb_Decay.Text = "Decay";
            // 
            // Freestyle_label_Reverb_BandWidth
            // 
            this.Freestyle_label_Reverb_BandWidth.AutoSize = true;
            this.Freestyle_label_Reverb_BandWidth.Location = new System.Drawing.Point(10, 176);
            this.Freestyle_label_Reverb_BandWidth.Name = "Freestyle_label_Reverb_BandWidth";
            this.Freestyle_label_Reverb_BandWidth.Size = new System.Drawing.Size(65, 14);
            this.Freestyle_label_Reverb_BandWidth.TabIndex = 26;
            this.Freestyle_label_Reverb_BandWidth.Text = "Bandwidth";
            // 
            // Freestyle_label_Reverb_Density
            // 
            this.Freestyle_label_Reverb_Density.AutoSize = true;
            this.Freestyle_label_Reverb_Density.Location = new System.Drawing.Point(10, 140);
            this.Freestyle_label_Reverb_Density.Name = "Freestyle_label_Reverb_Density";
            this.Freestyle_label_Reverb_Density.Size = new System.Drawing.Size(47, 14);
            this.Freestyle_label_Reverb_Density.TabIndex = 24;
            this.Freestyle_label_Reverb_Density.Text = "Density";
            // 
            // Freestyle_label_Reverb_Damping
            // 
            this.Freestyle_label_Reverb_Damping.AutoSize = true;
            this.Freestyle_label_Reverb_Damping.Location = new System.Drawing.Point(10, 106);
            this.Freestyle_label_Reverb_Damping.Name = "Freestyle_label_Reverb_Damping";
            this.Freestyle_label_Reverb_Damping.Size = new System.Drawing.Size(57, 14);
            this.Freestyle_label_Reverb_Damping.TabIndex = 22;
            this.Freestyle_label_Reverb_Damping.Text = "Damping";
            // 
            // Freestyle_label_Reverb_Size
            // 
            this.Freestyle_label_Reverb_Size.AutoSize = true;
            this.Freestyle_label_Reverb_Size.Location = new System.Drawing.Point(9, 75);
            this.Freestyle_label_Reverb_Size.Name = "Freestyle_label_Reverb_Size";
            this.Freestyle_label_Reverb_Size.Size = new System.Drawing.Size(63, 14);
            this.Freestyle_label_Reverb_Size.TabIndex = 20;
            this.Freestyle_label_Reverb_Size.Text = "Room size";
            // 
            // Freestyle_label_Clarity
            // 
            this.Freestyle_label_Clarity.AutoSize = true;
            this.Freestyle_label_Clarity.Location = new System.Drawing.Point(9, 32);
            this.Freestyle_label_Clarity.Name = "Freestyle_label_Clarity";
            this.Freestyle_label_Clarity.Size = new System.Drawing.Size(96, 15);
            this.Freestyle_label_Clarity.TabIndex = 20;
            this.Freestyle_label_Clarity.Text = "$CLARITY : 0dB";
            // 
            // Freestyle_label_Tube
            // 
            this.Freestyle_label_Tube.AutoSize = true;
            this.Freestyle_label_Tube.Location = new System.Drawing.Point(34, 46);
            this.Freestyle_label_Tube.Name = "Freestyle_label_Tube";
            this.Freestyle_label_Tube.Size = new System.Drawing.Size(45, 15);
            this.Freestyle_label_Tube.TabIndex = 14;
            this.Freestyle_label_Tube.Text = "$TUBE";
            // 
            // Freestyle_label_Bass_Gain
            // 
            this.Freestyle_label_Bass_Gain.AutoSize = true;
            this.Freestyle_label_Bass_Gain.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Freestyle_label_Bass_Gain.ForeColor = System.Drawing.Color.White;
            this.Freestyle_label_Bass_Gain.Location = new System.Drawing.Point(9, 82);
            this.Freestyle_label_Bass_Gain.Name = "Freestyle_label_Bass_Gain";
            this.Freestyle_label_Bass_Gain.Size = new System.Drawing.Size(113, 15);
            this.Freestyle_label_Bass_Gain.TabIndex = 20;
            this.Freestyle_label_Bass_Gain.Text = "$BASS_GAIN : 0dB";
            // 
            // Freestyle_label_Bass_SpkSize
            // 
            this.Freestyle_label_Bass_SpkSize.AutoSize = true;
            this.Freestyle_label_Bass_SpkSize.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Freestyle_label_Bass_SpkSize.ForeColor = System.Drawing.Color.White;
            this.Freestyle_label_Bass_SpkSize.Location = new System.Drawing.Point(9, 35);
            this.Freestyle_label_Bass_SpkSize.Name = "Freestyle_label_Bass_SpkSize";
            this.Freestyle_label_Bass_SpkSize.Size = new System.Drawing.Size(103, 15);
            this.Freestyle_label_Bass_SpkSize.TabIndex = 18;
            this.Freestyle_label_Bass_SpkSize.Text = "$BASS_SPKSIZE";
            // 
            // Freestyle_label_Surround_Image
            // 
            this.Freestyle_label_Surround_Image.AutoSize = true;
            this.Freestyle_label_Surround_Image.Location = new System.Drawing.Point(459, 48);
            this.Freestyle_label_Surround_Image.Name = "Freestyle_label_Surround_Image";
            this.Freestyle_label_Surround_Image.Size = new System.Drawing.Size(126, 15);
            this.Freestyle_label_Surround_Image.TabIndex = 24;
            this.Freestyle_label_Surround_Image.Text = "$SURROUND_IMAGE";
            // 
            // Freestyle_label_Surround_3D
            // 
            this.Freestyle_label_Surround_3D.AutoSize = true;
            this.Freestyle_label_Surround_3D.Location = new System.Drawing.Point(459, 6);
            this.Freestyle_label_Surround_3D.Name = "Freestyle_label_Surround_3D";
            this.Freestyle_label_Surround_3D.Size = new System.Drawing.Size(103, 15);
            this.Freestyle_label_Surround_3D.TabIndex = 22;
            this.Freestyle_label_Surround_3D.Text = "$SURROUND_3D";
            // 
            // Freestyle_label_ConvolverIRGain
            // 
            this.Freestyle_label_ConvolverIRGain.AutoSize = true;
            this.Freestyle_label_ConvolverIRGain.Location = new System.Drawing.Point(10, 33);
            this.Freestyle_label_ConvolverIRGain.Name = "Freestyle_label_ConvolverIRGain";
            this.Freestyle_label_ConvolverIRGain.Size = new System.Drawing.Size(133, 15);
            this.Freestyle_label_ConvolverIRGain.TabIndex = 6;
            this.Freestyle_label_ConvolverIRGain.Text = "$CONV_IR_GAIN : 0dB";
            // 
            // Freestyle_label_PostVolume
            // 
            this.Freestyle_label_PostVolume.AutoSize = true;
            this.Freestyle_label_PostVolume.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Freestyle_label_PostVolume.ForeColor = System.Drawing.Color.Snow;
            this.Freestyle_label_PostVolume.Location = new System.Drawing.Point(10, 225);
            this.Freestyle_label_PostVolume.Name = "Freestyle_label_PostVolume";
            this.Freestyle_label_PostVolume.Size = new System.Drawing.Size(119, 13);
            this.Freestyle_label_PostVolume.TabIndex = 2;
            this.Freestyle_label_PostVolume.Text = "$POST_VOLUME : 0dB";
            // 
            // Freestyle_label_PreVolume
            // 
            this.Freestyle_label_PreVolume.AutoSize = true;
            this.Freestyle_label_PreVolume.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Freestyle_label_PreVolume.ForeColor = System.Drawing.Color.Snow;
            this.Freestyle_label_PreVolume.Location = new System.Drawing.Point(10, 173);
            this.Freestyle_label_PreVolume.Name = "Freestyle_label_PreVolume";
            this.Freestyle_label_PreVolume.Size = new System.Drawing.Size(110, 13);
            this.Freestyle_label_PreVolume.TabIndex = 0;
            this.Freestyle_label_PreVolume.Text = "$PRE_VOLUME : 0dB";
            // 
            // MENU_SETTING
            // 
            this.MENU_SETTING.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LATENCY_SETTING,
            this.CHANNEL_PAN,
            this.RESETEFFECT,
            this.SETTINGS,
            this.VIRTUALIZATION});
            this.MENU_SETTING.Name = "MENU_SETTING";
            this.MENU_SETTING.Text = "$MENU_SETTING";
            // 
            // LATENCY_SETTING
            // 
            this.LATENCY_SETTING.Name = "LATENCY_SETTING";
            this.LATENCY_SETTING.Text = "$LATENCY_SETTING";
            this.LATENCY_SETTING.Click += new System.EventHandler(this.toolStripMenuItem_LatencySetting_Click);
            // 
            // CHANNEL_PAN
            // 
            this.CHANNEL_PAN.Name = "CHANNEL_PAN";
            this.CHANNEL_PAN.Text = "$CHANNEL_PAN";
            this.CHANNEL_PAN.Click += new System.EventHandler(this.toolStripMenuItem_ChannelPan_Click);
            // 
            // RESETEFFECT
            // 
            this.RESETEFFECT.Name = "RESETEFFECT";
            this.RESETEFFECT.Text = "$RESETEFFECT";
            this.RESETEFFECT.Click += new System.EventHandler(this.toolStripMenuItem_ResetEffect_Click);
            // 
            // SETTINGS
            // 
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Text = "$SETTINGS";
            this.SETTINGS.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // VIRTUALIZATION
            // 
            this.VIRTUALIZATION.Name = "VIRTUALIZATION";
            this.VIRTUALIZATION.Text = "$VIRTUALIZATION";
            this.VIRTUALIZATION.Click += new System.EventHandler(this.toolStripMenuItem_Virtualization_Click);
            // 
            // CHECKUPDATE
            // 
            this.CHECKUPDATE.Name = "CHECKUPDATE";
            this.CHECKUPDATE.Text = "$CHECKUPDATE";
            this.CHECKUPDATE.Click += new System.EventHandler(this.toolStripMenuItem_CheckUpdate_Click);
            // 
            // ABOUTV4W
            // 
            this.ABOUTV4W.Name = "ABOUTV4W";
            this.ABOUTV4W.Text = "$ABOUTV4W";
            this.ABOUTV4W.Click += new System.EventHandler(this.toolStripMenuItem_AboutV4W_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.EnableHighlight = false;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // button_Freestyle
            // 
            this.button_Freestyle.Location = new System.Drawing.Point(13, 137);
            this.button_Freestyle.Name = "button_Freestyle";
            this.button_Freestyle.Size = new System.Drawing.Size(190, 24);
            this.button_Freestyle.TabIndex = 15;
            this.button_Freestyle.Text = "Freestyle";
            this.button_Freestyle.ThemeName = "VisualStudio2012Dark";
            this.button_Freestyle.Click += new System.EventHandler(this.button_Freestyle_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Language";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click_1);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Русский язык";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "English ";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click_1);
            // 
            // radMenu1
            // 
            this.radMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radMenu1.Dock = System.Windows.Forms.DockStyle.None;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MENU_SETTING,
            this.CHECKUPDATE,
            this.ABOUTV4W,
            this.radMenuItem1,
            this.radMenuItem5,
            this.radMenuItem8,
            this.radMenuItem9});
            this.radMenu1.Location = new System.Drawing.Point(1, -5);
            this.radMenu1.Name = "radMenu1";
            // 
            // 
            // 
            this.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.radMenu1.Size = new System.Drawing.Size(722, 20);
            this.radMenu1.TabIndex = 9;
            this.radMenu1.ThemeName = "VisualStudio2012Dark";
            this.radMenu1.Click += new System.EventHandler(this.radMenu1_Click_1);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem10,
            this.radMenuItem11});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Preset";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Load preset";
            this.radMenuItem6.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Save preset";
            this.radMenuItem7.Click += new System.EventHandler(this.radButton2_Click_1);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.CheckOnClick = true;
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Auto Load Preset at Start";
            this.radMenuItem10.Click += new System.EventHandler(this.radMenuItem10_Click);
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.CheckOnClick = true;
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Auto Save Current Settings in Current Preset Before Exit";
            this.radMenuItem11.Click += new System.EventHandler(this.radMenuItem11_Click);
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Equalizer";
            this.radMenuItem8.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Compressor";
            this.radMenuItem9.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(866, 124);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(92, 26);
            this.radButton1.TabIndex = 25;
            this.radButton1.Text = "$LOAD_PRESET";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            this.radButton1.Visible = false;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(968, 124);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(88, 26);
            this.radButton2.TabIndex = 26;
            this.radButton2.Text = "$SAVE_PRESET";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            this.radButton2.Visible = false;
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click_1);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(866, 156);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(190, 26);
            this.radButton3.TabIndex = 27;
            this.radButton3.Text = "$EQUALIZER_ADJUST";
            this.radButton3.ThemeName = "VisualStudio2012Dark";
            this.radButton3.Visible = false;
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(866, 190);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(190, 26);
            this.radButton4.TabIndex = 28;
            this.radButton4.Text = "$COMPRESSOR_ADJUST";
            this.radButton4.ThemeName = "VisualStudio2012Dark";
            this.radButton4.Visible = false;
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.onOffSwitch_Master);
            this.panel2.Controls.Add(this.label_MasterPower);
            this.panel2.Controls.Add(this.button_Freestyle);
            this.panel2.Controls.Add(this.Freestyle_label_PreVolume);
            this.panel2.Controls.Add(this.Freestyle_hSlider_PreVolume);
            this.panel2.Controls.Add(this.Freestyle_hSlider_PostVolume);
            this.panel2.Controls.Add(this.Freestyle_label_PostVolume);
            this.panel2.Location = new System.Drawing.Point(4, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 277);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.radButton3_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // onOffSwitch_Master
            // 
            this.onOffSwitch_Master.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_Master.Location = new System.Drawing.Point(117, 92);
            this.onOffSwitch_Master.Name = "onOffSwitch_Master";
            this.onOffSwitch_Master.Size = new System.Drawing.Size(81, 30);
            this.onOffSwitch_Master.SwitchedOn = false;
            this.onOffSwitch_Master.TabIndex = 2;
            this.onOffSwitch_Master.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_Master_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_PreVolume
            // 
            this.Freestyle_hSlider_PreVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_PreVolume.Location = new System.Drawing.Point(3, 186);
            this.Freestyle_hSlider_PreVolume.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_PreVolume.Name = "Freestyle_hSlider_PreVolume";
            this.Freestyle_hSlider_PreVolume.Position = ((uint)(0u));
            this.Freestyle_hSlider_PreVolume.PositionFloat = 0F;
            this.Freestyle_hSlider_PreVolume.Size = new System.Drawing.Size(213, 35);
            this.Freestyle_hSlider_PreVolume.TabIndex = 1;
            this.Freestyle_hSlider_PreVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_PreVolume_PositionChangeNotify);
            // 
            // Freestyle_hSlider_PostVolume
            // 
            this.Freestyle_hSlider_PostVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_PostVolume.Location = new System.Drawing.Point(3, 238);
            this.Freestyle_hSlider_PostVolume.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_PostVolume.Name = "Freestyle_hSlider_PostVolume";
            this.Freestyle_hSlider_PostVolume.Position = ((uint)(0u));
            this.Freestyle_hSlider_PostVolume.PositionFloat = 0F;
            this.Freestyle_hSlider_PostVolume.Size = new System.Drawing.Size(213, 36);
            this.Freestyle_hSlider_PostVolume.TabIndex = 3;
            this.Freestyle_hSlider_PostVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_PostVolume_PositionChangeNotify);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Freestyle_buttonBox_BassMode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Freestyle_hSlider_BassGain);
            this.panel3.Controls.Add(this.Freestyle_onOffSwitch_Bass);
            this.panel3.Controls.Add(this.Freestyle_hSlider_BassSpkSize);
            this.panel3.Controls.Add(this.Freestyle_label_Bass_Gain);
            this.panel3.Controls.Add(this.Freestyle_label_Bass_SpkSize);
            this.panel3.Location = new System.Drawing.Point(229, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 215);
            this.panel3.TabIndex = 31;
            // 
            // Freestyle_buttonBox_BassMode
            // 
            this.Freestyle_buttonBox_BassMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_buttonBox_BassMode.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Freestyle_buttonBox_BassMode.ForeColor = System.Drawing.Color.White;
            this.Freestyle_buttonBox_BassMode.Location = new System.Drawing.Point(-1, 137);
            this.Freestyle_buttonBox_BassMode.Name = "Freestyle_buttonBox_BassMode";
            this.Freestyle_buttonBox_BassMode.Size = new System.Drawing.Size(211, 76);
            this.Freestyle_buttonBox_BassMode.TabIndex = 22;
            this.Freestyle_buttonBox_BassMode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_BassMode_ItemSelectedNotify);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Viper XBass";
            // 
            // Freestyle_hSlider_BassGain
            // 
            this.Freestyle_hSlider_BassGain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_BassGain.Location = new System.Drawing.Point(2, 105);
            this.Freestyle_hSlider_BassGain.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_BassGain.Name = "Freestyle_hSlider_BassGain";
            this.Freestyle_hSlider_BassGain.Position = ((uint)(0u));
            this.Freestyle_hSlider_BassGain.PositionFloat = 0F;
            this.Freestyle_hSlider_BassGain.Size = new System.Drawing.Size(204, 26);
            this.Freestyle_hSlider_BassGain.TabIndex = 21;
            this.Freestyle_hSlider_BassGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_BassGain_PositionChangeNotify);
            // 
            // Freestyle_onOffSwitch_Bass
            // 
            this.Freestyle_onOffSwitch_Bass.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Bass.Location = new System.Drawing.Point(144, 10);
            this.Freestyle_onOffSwitch_Bass.Name = "Freestyle_onOffSwitch_Bass";
            this.Freestyle_onOffSwitch_Bass.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Bass.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Bass.TabIndex = 17;
            this.Freestyle_onOffSwitch_Bass.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Bass_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_BassSpkSize
            // 
            this.Freestyle_hSlider_BassSpkSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_BassSpkSize.Location = new System.Drawing.Point(2, 53);
            this.Freestyle_hSlider_BassSpkSize.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_BassSpkSize.Name = "Freestyle_hSlider_BassSpkSize";
            this.Freestyle_hSlider_BassSpkSize.Position = ((uint)(0u));
            this.Freestyle_hSlider_BassSpkSize.PositionFloat = 0F;
            this.Freestyle_hSlider_BassSpkSize.Size = new System.Drawing.Size(204, 26);
            this.Freestyle_hSlider_BassSpkSize.TabIndex = 19;
            this.Freestyle_hSlider_BassSpkSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_BassSpkSize_PositionChangeNotify);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.Freestyle_label_Clarity);
            this.panel4.Controls.Add(this.Freestyle_hSlider_Clarity);
            this.panel4.Controls.Add(this.Freestyle_buttonBox_ClarityMode);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Freestyle_onOffSwitch_Clarity);
            this.panel4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(229, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 337);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Freestyle_buttonBox_CureLevel);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.Freestyle_label_Tube);
            this.panel5.Controls.Add(this.Freestyle_onOffSwitch_Cure);
            this.panel5.Controls.Add(this.Freestyle_onOffSwitch_Tube);
            this.panel5.Location = new System.Drawing.Point(-1, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 160);
            this.panel5.TabIndex = 22;
            // 
            // Freestyle_buttonBox_CureLevel
            // 
            this.Freestyle_buttonBox_CureLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_buttonBox_CureLevel.Location = new System.Drawing.Point(-1, 72);
            this.Freestyle_buttonBox_CureLevel.Name = "Freestyle_buttonBox_CureLevel";
            this.Freestyle_buttonBox_CureLevel.Size = new System.Drawing.Size(211, 88);
            this.Freestyle_buttonBox_CureLevel.TabIndex = 18;
            this.Freestyle_buttonBox_CureLevel.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_CureLevel_ItemSelectedNotify);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cure Tech +";
            // 
            // Freestyle_onOffSwitch_Cure
            // 
            this.Freestyle_onOffSwitch_Cure.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Cure.Location = new System.Drawing.Point(144, 10);
            this.Freestyle_onOffSwitch_Cure.Name = "Freestyle_onOffSwitch_Cure";
            this.Freestyle_onOffSwitch_Cure.Size = new System.Drawing.Size(49, 25);
            this.Freestyle_onOffSwitch_Cure.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Cure.TabIndex = 17;
            this.Freestyle_onOffSwitch_Cure.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Cure_SwitchChangeNotify);
            // 
            // Freestyle_onOffSwitch_Tube
            // 
            this.Freestyle_onOffSwitch_Tube.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Tube.Location = new System.Drawing.Point(144, 41);
            this.Freestyle_onOffSwitch_Tube.Name = "Freestyle_onOffSwitch_Tube";
            this.Freestyle_onOffSwitch_Tube.Size = new System.Drawing.Size(49, 25);
            this.Freestyle_onOffSwitch_Tube.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Tube.TabIndex = 15;
            this.Freestyle_onOffSwitch_Tube.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Tube_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_Clarity
            // 
            this.Freestyle_hSlider_Clarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_Clarity.Location = new System.Drawing.Point(-1, 47);
            this.Freestyle_hSlider_Clarity.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_Clarity.Name = "Freestyle_hSlider_Clarity";
            this.Freestyle_hSlider_Clarity.Position = ((uint)(0u));
            this.Freestyle_hSlider_Clarity.PositionFloat = 0F;
            this.Freestyle_hSlider_Clarity.Size = new System.Drawing.Size(207, 30);
            this.Freestyle_hSlider_Clarity.TabIndex = 21;
            this.Freestyle_hSlider_Clarity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_Clarity_PositionChangeNotify);
            // 
            // Freestyle_buttonBox_ClarityMode
            // 
            this.Freestyle_buttonBox_ClarityMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_buttonBox_ClarityMode.Location = new System.Drawing.Point(-1, 77);
            this.Freestyle_buttonBox_ClarityMode.Name = "Freestyle_buttonBox_ClarityMode";
            this.Freestyle_buttonBox_ClarityMode.Size = new System.Drawing.Size(211, 88);
            this.Freestyle_buttonBox_ClarityMode.TabIndex = 18;
            this.Freestyle_buttonBox_ClarityMode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_ClarityMode_ItemSelectedNotify);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Viper XClarity";
            // 
            // Freestyle_onOffSwitch_Clarity
            // 
            this.Freestyle_onOffSwitch_Clarity.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Clarity.Location = new System.Drawing.Point(144, 10);
            this.Freestyle_onOffSwitch_Clarity.Name = "Freestyle_onOffSwitch_Clarity";
            this.Freestyle_onOffSwitch_Clarity.Size = new System.Drawing.Size(49, 25);
            this.Freestyle_onOffSwitch_Clarity.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Clarity.TabIndex = 17;
            this.Freestyle_onOffSwitch_Clarity.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Clarity_SwitchChangeNotify);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Freestyle_hSlider_SmartVolumeMaxLevel);
            this.panel1.Controls.Add(this.Freestyle_hSlider_SmartVolumeLevel);
            this.panel1.Controls.Add(this.Freestyle_label_SmartVolume_MaxLevel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Freestyle_hSlider_SmartVolumeRatio);
            this.panel1.Controls.Add(this.Freestyle_label_SmartVolume_Level);
            this.panel1.Controls.Add(this.Freestyle_label_SmartVolume_ControlStrength);
            this.panel1.Controls.Add(this.Freestyle_onOffSwitch_SmartVolume);
            this.panel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 269);
            this.panel1.TabIndex = 33;
            // 
            // Freestyle_hSlider_SmartVolumeMaxLevel
            // 
            this.Freestyle_hSlider_SmartVolumeMaxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Location = new System.Drawing.Point(-1, 211);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Name = "Freestyle_hSlider_SmartVolumeMaxLevel";
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Size = new System.Drawing.Size(219, 38);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.TabIndex = 21;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeMaxLevel_PositionChangeNotify);
            // 
            // Freestyle_hSlider_SmartVolumeLevel
            // 
            this.Freestyle_hSlider_SmartVolumeLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_SmartVolumeLevel.Location = new System.Drawing.Point(-1, 71);
            this.Freestyle_hSlider_SmartVolumeLevel.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeLevel.Name = "Freestyle_hSlider_SmartVolumeLevel";
            this.Freestyle_hSlider_SmartVolumeLevel.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeLevel.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeLevel.Size = new System.Drawing.Size(219, 38);
            this.Freestyle_hSlider_SmartVolumeLevel.TabIndex = 23;
            this.Freestyle_hSlider_SmartVolumeLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeLevel_PositionChangeNotify);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Viper Smart Volume";
            // 
            // Freestyle_hSlider_SmartVolumeRatio
            // 
            this.Freestyle_hSlider_SmartVolumeRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_SmartVolumeRatio.Location = new System.Drawing.Point(-1, 139);
            this.Freestyle_hSlider_SmartVolumeRatio.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeRatio.Name = "Freestyle_hSlider_SmartVolumeRatio";
            this.Freestyle_hSlider_SmartVolumeRatio.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeRatio.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeRatio.Size = new System.Drawing.Size(219, 38);
            this.Freestyle_hSlider_SmartVolumeRatio.TabIndex = 19;
            this.Freestyle_hSlider_SmartVolumeRatio.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeRatio_PositionChangeNotify);
            // 
            // Freestyle_onOffSwitch_SmartVolume
            // 
            this.Freestyle_onOffSwitch_SmartVolume.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_SmartVolume.Location = new System.Drawing.Point(159, 11);
            this.Freestyle_onOffSwitch_SmartVolume.Name = "Freestyle_onOffSwitch_SmartVolume";
            this.Freestyle_onOffSwitch_SmartVolume.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_SmartVolume.SwitchedOn = false;
            this.Freestyle_onOffSwitch_SmartVolume.TabIndex = 17;
            this.Freestyle_onOffSwitch_SmartVolume.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_SmartVolume_SwitchChangeNotify);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Freestyle_openFileBox_ConvIRS);
            this.panel6.Controls.Add(this.Freestyle_irShape_ConvIR);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.Freestyle_hSlider_ConvIRGain);
            this.panel6.Controls.Add(this.Freestyle_label_ConvolverIRGain);
            this.panel6.Controls.Add(this.Freestyle_onOffSwitch_Convolver);
            this.panel6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(446, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 205);
            this.panel6.TabIndex = 34;
            // 
            // Freestyle_openFileBox_ConvIRS
            // 
            this.Freestyle_openFileBox_ConvIRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_openFileBox_ConvIRS.FilePathName = "";
            this.Freestyle_openFileBox_ConvIRS.Location = new System.Drawing.Point(5, 164);
            this.Freestyle_openFileBox_ConvIRS.Name = "Freestyle_openFileBox_ConvIRS";
            this.Freestyle_openFileBox_ConvIRS.Size = new System.Drawing.Size(274, 36);
            this.Freestyle_openFileBox_ConvIRS.TabIndex = 9;
            this.Freestyle_openFileBox_ConvIRS.FileChangeNotify += new ViPER4WindowsBin.UIControls.OpenFileBox.FileChangeEventDelegate(this.Freestyle_openFileBox_ConvIRS_FileChangeNotify);
            // 
            // Freestyle_irShape_ConvIR
            // 
            this.Freestyle_irShape_ConvIR.Location = new System.Drawing.Point(5, 80);
            this.Freestyle_irShape_ConvIR.Name = "Freestyle_irShape_ConvIR";
            this.Freestyle_irShape_ConvIR.ShapeBackColor = System.Drawing.Color.White;
            this.Freestyle_irShape_ConvIR.ShapeForeColor = System.Drawing.Color.Black;
            this.Freestyle_irShape_ConvIR.Size = new System.Drawing.Size(274, 78);
            this.Freestyle_irShape_ConvIR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(131, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Convolver";
            // 
            // Freestyle_hSlider_ConvIRGain
            // 
            this.Freestyle_hSlider_ConvIRGain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ConvIRGain.Location = new System.Drawing.Point(6, 49);
            this.Freestyle_hSlider_ConvIRGain.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ConvIRGain.Name = "Freestyle_hSlider_ConvIRGain";
            this.Freestyle_hSlider_ConvIRGain.Position = ((uint)(0u));
            this.Freestyle_hSlider_ConvIRGain.PositionFloat = 0F;
            this.Freestyle_hSlider_ConvIRGain.Size = new System.Drawing.Size(267, 30);
            this.Freestyle_hSlider_ConvIRGain.TabIndex = 7;
            this.Freestyle_hSlider_ConvIRGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ConvIRGain_PositionChangeNotify);
            // 
            // Freestyle_onOffSwitch_Convolver
            // 
            this.Freestyle_onOffSwitch_Convolver.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Convolver.Location = new System.Drawing.Point(216, 9);
            this.Freestyle_onOffSwitch_Convolver.Name = "Freestyle_onOffSwitch_Convolver";
            this.Freestyle_onOffSwitch_Convolver.Size = new System.Drawing.Size(57, 25);
            this.Freestyle_onOffSwitch_Convolver.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Convolver.TabIndex = 5;
            this.Freestyle_onOffSwitch_Convolver.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Convolver_SwitchChangeNotify);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Freestyle_singleButton_ReverbPreset1);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbMix);
            this.panel7.Controls.Add(this.Freestyle_onOffSwitch_Reverb);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_Mix);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbSize);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbEarlyMix);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_Size);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_EarlyMix);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_Damping);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbPreDelay);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbDamping);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_PreDelay);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_Density);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbDecay);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbDensity);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_Decay);
            this.panel7.Controls.Add(this.Freestyle_label_Reverb_BandWidth);
            this.panel7.Controls.Add(this.Freestyle_hSlider_ReverbBandWidth);
            this.panel7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(446, 229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 347);
            this.panel7.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(167, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Reverberation";
            // 
            // Freestyle_hSlider_ReverbMix
            // 
            this.Freestyle_hSlider_ReverbMix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbMix.Location = new System.Drawing.Point(78, 308);
            this.Freestyle_hSlider_ReverbMix.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbMix.Name = "Freestyle_hSlider_ReverbMix";
            this.Freestyle_hSlider_ReverbMix.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbMix.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbMix.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbMix.TabIndex = 35;
            this.Freestyle_hSlider_ReverbMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbMix_PositionChangeNotify);
            // 
            // Freestyle_onOffSwitch_Reverb
            // 
            this.Freestyle_onOffSwitch_Reverb.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Reverb.Location = new System.Drawing.Point(195, 32);
            this.Freestyle_onOffSwitch_Reverb.Name = "Freestyle_onOffSwitch_Reverb";
            this.Freestyle_onOffSwitch_Reverb.Size = new System.Drawing.Size(57, 25);
            this.Freestyle_onOffSwitch_Reverb.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Reverb.TabIndex = 7;
            this.Freestyle_onOffSwitch_Reverb.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Reverb_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_ReverbSize
            // 
            this.Freestyle_hSlider_ReverbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbSize.Location = new System.Drawing.Point(78, 70);
            this.Freestyle_hSlider_ReverbSize.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbSize.Name = "Freestyle_hSlider_ReverbSize";
            this.Freestyle_hSlider_ReverbSize.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbSize.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbSize.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbSize.TabIndex = 21;
            this.Freestyle_hSlider_ReverbSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbSize_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbEarlyMix
            // 
            this.Freestyle_hSlider_ReverbEarlyMix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbEarlyMix.Location = new System.Drawing.Point(78, 274);
            this.Freestyle_hSlider_ReverbEarlyMix.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbEarlyMix.Name = "Freestyle_hSlider_ReverbEarlyMix";
            this.Freestyle_hSlider_ReverbEarlyMix.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbEarlyMix.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbEarlyMix.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbEarlyMix.TabIndex = 33;
            this.Freestyle_hSlider_ReverbEarlyMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbEarlyMix_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbPreDelay
            // 
            this.Freestyle_hSlider_ReverbPreDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbPreDelay.Location = new System.Drawing.Point(78, 240);
            this.Freestyle_hSlider_ReverbPreDelay.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbPreDelay.Name = "Freestyle_hSlider_ReverbPreDelay";
            this.Freestyle_hSlider_ReverbPreDelay.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbPreDelay.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbPreDelay.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbPreDelay.TabIndex = 31;
            this.Freestyle_hSlider_ReverbPreDelay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbPreDelay_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbDamping
            // 
            this.Freestyle_hSlider_ReverbDamping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbDamping.Location = new System.Drawing.Point(78, 100);
            this.Freestyle_hSlider_ReverbDamping.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDamping.Name = "Freestyle_hSlider_ReverbDamping";
            this.Freestyle_hSlider_ReverbDamping.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDamping.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDamping.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbDamping.TabIndex = 23;
            this.Freestyle_hSlider_ReverbDamping.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDamping_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbDecay
            // 
            this.Freestyle_hSlider_ReverbDecay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbDecay.Location = new System.Drawing.Point(78, 206);
            this.Freestyle_hSlider_ReverbDecay.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDecay.Name = "Freestyle_hSlider_ReverbDecay";
            this.Freestyle_hSlider_ReverbDecay.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDecay.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDecay.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbDecay.TabIndex = 29;
            this.Freestyle_hSlider_ReverbDecay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDecay_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbDensity
            // 
            this.Freestyle_hSlider_ReverbDensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbDensity.Location = new System.Drawing.Point(78, 134);
            this.Freestyle_hSlider_ReverbDensity.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDensity.Name = "Freestyle_hSlider_ReverbDensity";
            this.Freestyle_hSlider_ReverbDensity.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDensity.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDensity.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbDensity.TabIndex = 25;
            this.Freestyle_hSlider_ReverbDensity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDensity_PositionChangeNotify);
            // 
            // Freestyle_hSlider_ReverbBandWidth
            // 
            this.Freestyle_hSlider_ReverbBandWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_ReverbBandWidth.Location = new System.Drawing.Point(78, 170);
            this.Freestyle_hSlider_ReverbBandWidth.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbBandWidth.Name = "Freestyle_hSlider_ReverbBandWidth";
            this.Freestyle_hSlider_ReverbBandWidth.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbBandWidth.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbBandWidth.Size = new System.Drawing.Size(202, 28);
            this.Freestyle_hSlider_ReverbBandWidth.TabIndex = 27;
            this.Freestyle_hSlider_ReverbBandWidth.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbBandWidth_PositionChangeNotify);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.Freestyle_onOffSwitch_SurroundVHE);
            this.panel8.Controls.Add(this.Freestyle_hSlider_SurroundImage);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.Freestyle_label_Surround_Image);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.Freestyle_hSlider_Surround3D);
            this.panel8.Controls.Add(this.Freestyle_label_Surround_3D);
            this.panel8.Controls.Add(this.Freestyle_buttonBox_SurroundVHERoomSize);
            this.panel8.Controls.Add(this.Freestyle_onOffSwitch_Surround3D);
            this.panel8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(4, 582);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(727, 110);
            this.panel8.TabIndex = 36;
            // 
            // Freestyle_onOffSwitch_SurroundVHE
            // 
            this.Freestyle_onOffSwitch_SurroundVHE.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_SurroundVHE.Location = new System.Drawing.Point(69, 48);
            this.Freestyle_onOffSwitch_SurroundVHE.Name = "Freestyle_onOffSwitch_SurroundVHE";
            this.Freestyle_onOffSwitch_SurroundVHE.Size = new System.Drawing.Size(60, 28);
            this.Freestyle_onOffSwitch_SurroundVHE.SwitchedOn = false;
            this.Freestyle_onOffSwitch_SurroundVHE.TabIndex = 6;
            this.Freestyle_onOffSwitch_SurroundVHE.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_SurroundVHE_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_SurroundImage
            // 
            this.Freestyle_hSlider_SurroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_SurroundImage.Location = new System.Drawing.Point(456, 61);
            this.Freestyle_hSlider_SurroundImage.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SurroundImage.Name = "Freestyle_hSlider_SurroundImage";
            this.Freestyle_hSlider_SurroundImage.Position = ((uint)(0u));
            this.Freestyle_hSlider_SurroundImage.PositionFloat = 0F;
            this.Freestyle_hSlider_SurroundImage.Size = new System.Drawing.Size(260, 30);
            this.Freestyle_hSlider_SurroundImage.TabIndex = 25;
            this.Freestyle_hSlider_SurroundImage.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SurroundImage_PositionChangeNotify);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(333, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "3D Surround";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 38);
            this.label7.TabIndex = 20;
            this.label7.Text = "ViPER Headphone\r\nEngine";
            // 
            // Freestyle_hSlider_Surround3D
            // 
            this.Freestyle_hSlider_Surround3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_hSlider_Surround3D.Location = new System.Drawing.Point(456, 20);
            this.Freestyle_hSlider_Surround3D.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_Surround3D.Name = "Freestyle_hSlider_Surround3D";
            this.Freestyle_hSlider_Surround3D.Position = ((uint)(0u));
            this.Freestyle_hSlider_Surround3D.PositionFloat = 0F;
            this.Freestyle_hSlider_Surround3D.Size = new System.Drawing.Size(260, 30);
            this.Freestyle_hSlider_Surround3D.TabIndex = 23;
            this.Freestyle_hSlider_Surround3D.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_Surround3D_PositionChangeNotify);
            // 
            // Freestyle_buttonBox_SurroundVHERoomSize
            // 
            this.Freestyle_buttonBox_SurroundVHERoomSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Freestyle_buttonBox_SurroundVHERoomSize.Location = new System.Drawing.Point(146, -1);
            this.Freestyle_buttonBox_SurroundVHERoomSize.Name = "Freestyle_buttonBox_SurroundVHERoomSize";
            this.Freestyle_buttonBox_SurroundVHERoomSize.Size = new System.Drawing.Size(171, 110);
            this.Freestyle_buttonBox_SurroundVHERoomSize.TabIndex = 7;
            this.Freestyle_buttonBox_SurroundVHERoomSize.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_SurroundVHERoomSize_ItemSelectedNotify);
            // 
            // Freestyle_onOffSwitch_Surround3D
            // 
            this.Freestyle_onOffSwitch_Surround3D.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Surround3D.Location = new System.Drawing.Point(369, 48);
            this.Freestyle_onOffSwitch_Surround3D.Name = "Freestyle_onOffSwitch_Surround3D";
            this.Freestyle_onOffSwitch_Surround3D.Size = new System.Drawing.Size(60, 28);
            this.Freestyle_onOffSwitch_Surround3D.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Surround3D.TabIndex = 6;
            this.Freestyle_onOffSwitch_Surround3D.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Surround3D_SwitchChangeNotify);
            // 
            // panelUpdateDownloading
            // 
            this.panelUpdateDownloading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateDownloading.Controls.Add(this.progressProg);
            this.panelUpdateDownloading.Controls.Add(this.labelKB);
            this.panelUpdateDownloading.Controls.Add(this.metroButton1);
            this.panelUpdateDownloading.Controls.Add(this.label9);
            this.panelUpdateDownloading.HorizontalScrollbarBarColor = true;
            this.panelUpdateDownloading.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUpdateDownloading.HorizontalScrollbarSize = 10;
            this.panelUpdateDownloading.Location = new System.Drawing.Point(1, 299);
            this.panelUpdateDownloading.Name = "panelUpdateDownloading";
            this.panelUpdateDownloading.Size = new System.Drawing.Size(730, 76);
            this.panelUpdateDownloading.TabIndex = 37;
            this.panelUpdateDownloading.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelUpdateDownloading.VerticalScrollbarBarColor = true;
            this.panelUpdateDownloading.VerticalScrollbarHighlightOnWheel = false;
            this.panelUpdateDownloading.VerticalScrollbarSize = 10;
            this.panelUpdateDownloading.Visible = false;
            // 
            // progressProg
            // 
            this.progressProg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressProg.Location = new System.Drawing.Point(7, 44);
            this.progressProg.Name = "progressProg";
            this.progressProg.Size = new System.Drawing.Size(718, 23);
            this.progressProg.TabIndex = 5;
            this.progressProg.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelKB
            // 
            this.labelKB.AutoSize = true;
            this.labelKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.labelKB.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.labelKB.ForeColor = System.Drawing.Color.White;
            this.labelKB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelKB.Location = new System.Drawing.Point(224, 24);
            this.labelKB.Name = "labelKB";
            this.labelKB.Size = new System.Drawing.Size(28, 17);
            this.labelKB.TabIndex = 4;
            this.labelKB.Text = ".....";
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(621, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.label9.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(26, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 33);
            this.label9.TabIndex = 2;
            this.label9.Text = "Downloading";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ViPER4Windows";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.toolStripMenuItem_CheckUpdate_Click);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 697);
            this.Controls.Add(this.panelUpdateDownloading);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViPER by IronShell";
            this.ThemeName = "VisualStudio2012Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Freestyle_singleButton_ReverbPreset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Freestyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelUpdateDownloading.ResumeLayout(false);
            this.panelUpdateDownloading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void radMenu1_Click(object sender, EventArgs e)
        {
            frmChannelPan frmChannelPan = new frmChannelPan
            {
                ChannelPan = m_paramBaseSystem.m_rChannelPan
            };
            int num = (int)frmChannelPan.ShowDialog();
            m_paramBaseSystem.m_rChannelPan = frmChannelPan.ChannelPan;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void toolStripMenuItem_Setting_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (itCurrItem == null || itCurrItem.Tag == null || !(itCurrItem.Tag is string tag))
            //{
            //    return;
            //}

            //if (tag == 0.ToString())
            //{
            //    panel_MusicMode.Visible = true;
            //    panel_MovieMode.Visible = false;
            //    panel_Freestyle.Visible = false;
            //    m_paramBaseSystem.m_nEffectMode = 0U;
            //    m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            //    m_cpConfigProxy.SyncConfig();
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_MusicMode_Click(object sender, EventArgs e)
        {
            //panel_MusicMode.Visible = true;
            //panel_MovieMode.Visible = false;
            //panel_Freestyle.Visible = false;
            m_paramBaseSystem.m_nEffectMode = 0U;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void button_MovieMode_Click(object sender, EventArgs e)
        {
            //panel_MusicMode.Visible = false;
            //panel_MovieMode.Visible = true;
            //panel_Freestyle.Visible = false;
            m_paramBaseSystem.m_nEffectMode = 1U;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void button_Freestyle_Click(object sender, EventArgs e)
        {
            //panel_MusicMode.Visible = false;
            //panel_MovieMode.Visible = false;
            //panel_Freestyle.Visible = true;
            m_paramBaseSystem.m_nEffectMode = 2U;
            m_cpConfigProxy.UpdateParameter(m_paramBaseSystem);
            m_cpConfigProxy.SyncConfig();
        }

        private void panel_Freestyle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            new ConfigFile(AppDomain.CurrentDomain.BaseDirectory + "Config.ini").SetConfig("$LANGUAGE_NAME", "Русский");
            MessageBox.Show("Русский язык влючен, нужено перезапустить программу.");
            //   var d = @"C:\Program Files\ViPER4Windows\Config.ini";
            //       File.AppendAllText(d, "$LANGUAGE_NAME=Русский");
            //var env_ = Environment.CurrentDirectory+ "\\Language";
            //frmMain.SetLanguage(env_, "ru-RU.lan");
            //string str1 = new ConfigFile(env_ + "Config.ini").ReadConfig("$LANGUAGE_NAME");
            //if (str1 == "")
            //{
            //    str1 = "Russian";
            //}
            //GlobalMessages.LoadMessages("ru-RU.lan");
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            new ConfigFile(AppDomain.CurrentDomain.BaseDirectory + "Config.ini").SetConfig("$LANGUAGE_NAME", "English");
            MessageBox.Show("English is enabled. You need to restart the program.");
        }

        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.ShowInTaskbar = false;
            //    notifyIcon1.Visible = true;
            //}
        }

        private void notifyIcon_Main_Click(object sender, EventArgs e)
        {
            Activate();
        }

        private void notifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon_Main_DoubleClick(object sender, EventArgs e)
        {
            Show();

            WindowState = FormWindowState.Normal;

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (autoSavePreset)
            {
                SavePreset(prespath);
            }
            if (!ini.KeyExists("LastPresetPath", "Settings"))
            {
                if (prespath != "")
                    if (DialogResult.Yes == messageBoxCaller("Do you want to autoload this preset?", "Preset auto load", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        ini.Write("Settings", "LastPresetPath", prespath);
                    else if (DialogResult.Yes == messageBoxCaller("You don't save the preset! If you leave your settings won't save! Save your preset now?", "Preset", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        radButton2.PerformClick();
            }

            try
            {
                // MessageBox.Show();
                Process.Start("taskkill", "/IM " + Process.GetCurrentProcess().ProcessName + ".exe");
                //      Environment.Exit(1);
            }
            catch { }
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            new ConfigFile(AppDomain.CurrentDomain.BaseDirectory + "Config.ini").SetConfig("$LANGUAGE_NAME", "Русский");
            MessageBox.Show("Русский язык влючен, нужено перезапустить программу.");
            //   var d = @"C:\Program Files\ViPER4Windows\Config.ini";
            //       File.AppendAllText(d, "$LANGUAGE_NAME=Русский");
            //var env_ = Environment.CurrentDirectory+ "\\Language";
            //frmMain.SetLanguage(env_, "ru-RU.lan");
            //string str1 = new ConfigFile(env_ + "Config.ini").ReadConfig("$LANGUAGE_NAME");
            //if (str1 == "")
            //{
            //    str1 = "Russian";
            //}
            //GlobalMessages.LoadMessages("ru-RU.lan");
        }

        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            new ConfigFile(AppDomain.CurrentDomain.BaseDirectory + "Config.ini").SetConfig("$LANGUAGE_NAME", "English");
            MessageBox.Show("English is enabled. You need to restart the program.");
        }

        private void Freestyle_singleButton_ReverbPreset_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public bool autoSavePreset = false;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (ini.KeyExists("LastPresetAutoSave", "Settings"))
            {
                autoSavePreset = bool.Parse(ini.ReadINI("Settings", "LastPresetAutoSave"));
                radMenuItem11.IsChecked = true;
            }
            if (ini.KeyExists("LastPresetPath", "Settings"))
            {
                if (ini.KeyExists("LastPresetAutoLoad", "Settings") && bool.Parse(ini.ReadINI("Settings", "LastPresetAutoLoad"))==true)
                {
                    PresetLoader(ini.ReadINI("Settings", "LastPresetPath"));
                    radMenuItem10.IsChecked = true;
                }
                prespath = ini.ReadINI("Settings", "LastPresetPath");
            }
            var proc1 = new Thread(() =>
            {
                string Ver = CheckUpdate.MsgUpdateAvailable();
                if (Ver != null)
                    notifyIcon1.ShowBalloonTip(3000, "Update available " + Ver,
                        "Click on this notification to see more", ToolTipIcon.Info);
            })
            {
                IsBackground = true
            };
            proc1.Start();

        }

        private void Freestyle_singleButton_ReverbPreset1_Click(object sender, EventArgs e)
        {
            frmReverbPreset frmReverbPreset = new frmReverbPreset
            {
                ReverbSize = m_paramFreestyle.m_rReverbSize,
                ReverbDamping = m_paramFreestyle.m_rReverbDamping,
                ReverbDensity = m_paramFreestyle.m_rReverbDensity,
                ReverbBandwidth = m_paramFreestyle.m_rReverbBandwidth,
                ReverbDecay = m_paramFreestyle.m_rReverbDecay,
                ReverbPredelay = m_paramFreestyle.m_rReverbPredelay,
                ReverbEarlyMix = m_paramFreestyle.m_rReverbEarlyMix,
                ReverbMix = m_paramFreestyle.m_rReverbMix
            };
            if (frmReverbPreset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramFreestyle.m_rReverbSize = frmReverbPreset.ReverbSize;
            m_paramFreestyle.m_rReverbDamping = frmReverbPreset.ReverbDamping;
            m_paramFreestyle.m_rReverbDensity = frmReverbPreset.ReverbDensity;
            m_paramFreestyle.m_rReverbBandwidth = frmReverbPreset.ReverbBandwidth;
            m_paramFreestyle.m_rReverbDecay = frmReverbPreset.ReverbDecay;
            m_paramFreestyle.m_rReverbPredelay = frmReverbPreset.ReverbPredelay;
            m_paramFreestyle.m_rReverbEarlyMix = frmReverbPreset.ReverbEarlyMix;
            m_paramFreestyle.m_rReverbMix = frmReverbPreset.ReverbMix;
            Freestyle_hSlider_ReverbSize.PositionFloat = m_paramFreestyle.m_rReverbSize;
            Freestyle_hSlider_ReverbDamping.PositionFloat = m_paramFreestyle.m_rReverbDamping;
            Freestyle_hSlider_ReverbDensity.PositionFloat = m_paramFreestyle.m_rReverbDensity;
            Freestyle_hSlider_ReverbBandWidth.PositionFloat = m_paramFreestyle.m_rReverbBandwidth;
            Freestyle_hSlider_ReverbDecay.PositionFloat = m_paramFreestyle.m_rReverbDecay;
            Freestyle_hSlider_ReverbPreDelay.PositionFloat = m_paramFreestyle.m_rReverbPredelay;
            Freestyle_hSlider_ReverbEarlyMix.PositionFloat = m_paramFreestyle.m_rReverbEarlyMix;
            Freestyle_hSlider_ReverbMix.PositionFloat = m_paramFreestyle.m_rReverbMix;
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            string path = ofdVPF();
            if (path != null)
                if (PresetLoader(path))
                {
                    ini.Write("Settings", "LastPresetPath", path);
                    if (autoSavePreset==false)
                        if (DialogResult.Yes == messageBoxCaller("Do you want to autoload this preset?", "Preset auto load", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ini.Write("Settings", "LastPresetAutoLoad", "true");
                            radMenuItem10.IsChecked = true;
                        }
                    prespath = path;
                    messageBoxCaller("Preset loaded!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        string ofdVPF()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = GlobalMessages.LOAD_PRESET,
                Filter = "*.vpf|*.vpf",
                DefaultExt = "vpf",
                InitialDirectory = m_szPresetsPath

            };
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return openFileDialog.FileName;
        }
        string prespath = "";
        static string pathini()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\VIperbyIrshll\";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return dir;
        }
        IniFile ini = new IniFile(pathini() + "setting.ini");
        public bool PresetLoader(string filename)
        {
            RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramOfBaseSystem = new RuntimeUtils.ConfigProxy._ParamOfBaseSystem();
            RuntimeUtils.ConfigProxy._ParamOfMusicMode paramOfMusicMode = new RuntimeUtils.ConfigProxy._ParamOfMusicMode();
            RuntimeUtils.ConfigProxy._ParamOfMovieMode paramOfMovieMode = new RuntimeUtils.ConfigProxy._ParamOfMovieMode();
            RuntimeUtils.ConfigProxy._ParamOfFreestyle paramOfFreestyle = new RuntimeUtils.ConfigProxy._ParamOfFreestyle();
            Parameters.LoadDefaultParameter(ref paramOfBaseSystem);
            Parameters.LoadDefaultParameter(ref paramOfMusicMode);
            Parameters.LoadDefaultParameter(ref paramOfMovieMode);
            Parameters.LoadDefaultParameter(ref paramOfFreestyle);
            if (!Parameters.ReadPreset(filename, ref paramOfBaseSystem, ref paramOfMusicMode, ref paramOfMovieMode, ref paramOfFreestyle, out bool bPBaseSystem, out bool bPMusicMode, out bool bPMovieMode, out bool bPFreestyle))
            {
                int num = (int)MessageBox.Show(GlobalMessages.CANT_LOAD_PRESET, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else
            {
                if (!bPMusicMode && !bPMovieMode && !bPFreestyle)
                {
                    return false;
                }

                if (bPMusicMode)
                {
                    m_paramMusicMode = paramOfMusicMode;
                }

                if (bPMovieMode)
                {
                    m_paramMovieMode = paramOfMovieMode;
                }

                if (bPFreestyle)
                {
                    m_paramFreestyle = paramOfFreestyle;
                }
                
                UpdateAllControlsFromParameters();

            }
            return true;
        }
        private void SavePreset(string path)
        {
            switch (m_paramBaseSystem.m_nEffectMode)
            {
                case 0:
                    Parameters.SavePreset(path, m_paramMusicMode);
                    break;
                case 1:
                    Parameters.SavePreset(path, m_paramMovieMode);
                    break;
                case 2:
                    Parameters.SavePreset(path, m_paramFreestyle);
                    break;
                default:
                    int num = (int)MetroMessageBox.Show(this, GlobalMessages.CANT_SAVE_PRESET, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
            }
        }
        private void radButton2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = GlobalMessages.SAVE_PRESET,
                Filter = "*.vpf|*.vpf",
                DefaultExt = "vpf",
                InitialDirectory = m_szPresetsPath
            };
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            SavePreset(saveFileDialog.FileName);
            if (DialogResult.Yes == messageBoxCaller("Do you want to autoload this preset?", "Preset auto load", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ini.Write("Settings", "LastPresetPath", saveFileDialog.FileName);
                messageBoxCaller("Preset saved and autoload have enabled", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            frmEqualizer frmEqualizer = new frmEqualizer();
            frmEqualizer.SetRealtimeParameters(m_paramBaseSystem, m_paramMusicMode, m_paramMovieMode, m_paramFreestyle, m_cpConfigProxy);
            if (m_paramFreestyle.m_bEqualizerEnabled == 0)
            {
                frmEqualizer.SetParameters(m_paramFreestyle.m_rpEqualizerBands, false);
            }
            else
            {
                frmEqualizer.SetParameters(m_paramFreestyle.m_rpEqualizerBands, true);
            }

            int num = (int)frmEqualizer.ShowDialog();
            m_paramFreestyle.m_bEqualizerEnabled = !frmEqualizer.GetEQEnabled() ? 0 : 1;
            if (frmEqualizer.GetParameter() != null)
            {
                m_paramFreestyle.m_rpEqualizerBands = frmEqualizer.GetParameter();
            }

            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            frmCompressor frmCompressor = new frmCompressor
            {
                CompressorEnabled = m_paramFreestyle.m_bCompressorEnabled != 0,
                AutoKnee = m_paramFreestyle.m_bCompAutoKnee != 0,
                AutoAttack = m_paramFreestyle.m_bCompAutoAttack != 0,
                AutoRelease = m_paramFreestyle.m_bCompAutoRelease != 0,
                AutoGain = m_paramFreestyle.m_bCompAutoGain != 0,
                NoClip = m_paramFreestyle.m_bCompAutoMetaNoClipping != 0,
                Threshold = m_paramFreestyle.m_rCompThreshold,
                KneeWidth = m_paramFreestyle.m_rCompKneeWidth,
                Ratio = m_paramFreestyle.m_rCompRatio,
                AttackTime = m_paramFreestyle.m_rCompAttack,
                ReleaseTime = m_paramFreestyle.m_rCompRelease,
                KneeMult = m_paramFreestyle.m_rCompMetaKneeMult,
                CrestTime = m_paramFreestyle.m_rCompMetaCrest,
                AdaptTime = m_paramFreestyle.m_rCompMetaAdapt,
                MakeupGain = m_paramFreestyle.m_rCompGain
            };
            if (frmCompressor.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_paramFreestyle.m_bCompressorEnabled = !frmCompressor.CompressorEnabled ? 0 : 1;
            m_paramFreestyle.m_bCompAutoKnee = !frmCompressor.AutoKnee ? 0 : 1;
            m_paramFreestyle.m_bCompAutoAttack = !frmCompressor.AutoAttack ? 0 : 1;
            m_paramFreestyle.m_bCompAutoRelease = !frmCompressor.AutoRelease ? 0 : 1;
            m_paramFreestyle.m_bCompAutoGain = !frmCompressor.AutoGain ? 0 : 1;
            m_paramFreestyle.m_bCompAutoMetaNoClipping = !frmCompressor.NoClip ? 0 : 1;
            m_paramFreestyle.m_rCompThreshold = frmCompressor.Threshold;
            m_paramFreestyle.m_rCompKneeWidth = frmCompressor.KneeWidth;
            m_paramFreestyle.m_rCompRatio = frmCompressor.Ratio;
            m_paramFreestyle.m_rCompAttack = frmCompressor.AttackTime;
            m_paramFreestyle.m_rCompRelease = frmCompressor.ReleaseTime;
            m_paramFreestyle.m_rCompMetaKneeMult = frmCompressor.KneeMult;
            m_paramFreestyle.m_rCompMetaCrest = frmCompressor.CrestTime;
            m_paramFreestyle.m_rCompMetaAdapt = frmCompressor.AdaptTime;
            m_paramFreestyle.m_rCompGain = frmCompressor.MakeupGain;
            m_cpConfigProxy.UpdateParameter(m_paramFreestyle);
            m_cpConfigProxy.SyncConfig();
        }

        private void radMenu1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip itp = new ToolTip();
            itp.Show("Equalizer", pictureBox1);
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            if (radMenuItem10.IsChecked == false)
            {
                ini.Write("Settings", "LastPresetAutoLoad", "false");
                messageBoxCaller("Autoload is removed", "Preset auto load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!ini.KeyExists("LastPresetPath", "Settings") && radMenuItem10.IsChecked == true)
            {
                var PresetResult = messageBoxCaller("You don't have saved preset yet. Save now? \nPress \"NO\" to select saved preset \nor \"Cancel\" for cancel this", "Preset auto load", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (PresetResult==DialogResult.Yes)
                {
                    radMenuItem7.PerformClick();
                    radMenuItem10.IsChecked = false;
                }
                else if (PresetResult==DialogResult.No)
                {
                    radButton1.PerformClick();
                    radMenuItem10.IsChecked = false;
                }
            }
            else if (ini.KeyExists("LastPresetPath", "Settings") && radMenuItem10.IsChecked == true)
            {
                ini.Write("Settings", "LastPresetAutoLoad", "true");
                messageBoxCaller("Autoload is enabled", "Preset auto load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            if (radMenuItem11.IsChecked)
            {
                ini.Write("Settings", "LastPresetAutoSave", "true");
                autoSavePreset = true;
            }

            else
            {
                ini.Write("Settings", "LastPresetAutoSave", "false");
                autoSavePreset = false;
            }
        }
    }
}