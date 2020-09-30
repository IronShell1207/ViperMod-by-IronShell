using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
    public partial class metroFormVirt : MetroFramework.Forms.MetroForm
    {
        public metroFormVirt()
        {
            InitializeComponent();
            Parameters.LoadDefaultParameter(ref m_paramSystem);
            m_nCurrentAudioSystem = -1;
            Text = GlobalMessages.VIRTUALIZATION;
            this.Text = GlobalMessages.AUDIO_SYSTEM_CONFIG;
            singleButton_ResetConfig.Text = GlobalMessages.VIRT_RESET;
            metroLabel1.Text = GlobalMessages.VIRT_APPLIED;
            checkBox_MusicMode.Text = GlobalMessages.MUSIC_MODE;
            checkBox_MovieMode.Text = GlobalMessages.MOVIE_MODE;
            checkBox_Freestyle.Text = GlobalMessages.FREESTYLE_MODE;
            metroLabel2.Text = GlobalMessages.VIRT_ENVIRONMENT;
            label_PrePostProcess.Text = GlobalMessages.VIRT_PREPOST_PROCESS;
            singleButton_OK.Text = GlobalMessages.OK;
            singleButton_Cancel.Text = GlobalMessages.CANCEL;
            buttonBox_AudioSystemConfig.ClearItem();
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_MONO, "0"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_STEREO, "1"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_HEADSET, "2"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_REARSTEREO, "3"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_QUAD, "4"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X5P1, "5"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X6P1, "6"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X7P1, "7"));
            buttonBox_AudioSystemConfig.AddItem(new ButtonBox.Item(GlobalMessages.AUDIO_SYSTEM_X8P1, "8"));
            listView_Speaker.Columns[0].Text = GlobalMessages.VIRT_SPEAKER;
            listView_Speaker.Columns[1].Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
            listView_Speaker.Items.Clear();
            checkBox_MusicMode.Checked = false;
            checkBox_MovieMode.Checked = false;
            checkBox_Freestyle.Checked = false;
            onOffSwitch_EnvRealize.SwitchedOn = false;
            hSlider_EnvRealizeDrySignal.PositionFloat = 0.7f;
            twoSelector_PrePostProcess.Selector = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            comboBox_EnvRealizePreset.Items.Clear();
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_SMALLROOM, 2));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_BATHROOM, 3));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_LIVINGROOM, 4));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_STONEROOM, 5));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_AUDITORIUM, 6));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_CONCERTHALL, 7));
            comboBox_EnvRealizePreset.Items.Add(new metroFormVirt.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_HALLWAY, 12));
            //toolStripMenuItem_SpeakerAngle.Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
            //toolStripComboBox_SpeakerAngle.Items.Clear();
            //for (int index = -180; index <= 180; index += 10)
            //{
            //    toolStripComboBox_SpeakerAngle.Items.Add(new metroFormVirt.SpeakerAngle(index));
            //}
        }
        private int m_nCurrentAudioSystem = -1;
        private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramSystem = new RuntimeUtils.ConfigProxy._ParamOfBaseSystem();
        private void buttonBox_AudioSystemConfig_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
        {
            if (itCurrItem == null || itCurrItem.Tag == null || itCurrItem.Tag.GetType() != typeof(string))
            {
                return;
            }

            string tag = itCurrItem.Tag as string;
            if (string.IsNullOrEmpty(tag))
            {
                return;
            }

            int result = -1;
            if (!int.TryParse(tag, out result) || result < 0 || result > 8)
            {
                return;
            }

            m_nCurrentAudioSystem = result;
            RefreshSpeakerList();
        }
        public void SetBaseSystemParam(
  RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramSystem)
        {
            m_paramSystem = paramSystem;
            int num1 = m_paramSystem.m_bVirtApplied & 1;
            int num2 = m_paramSystem.m_bVirtApplied >> 1 & 1;
            int num3 = m_paramSystem.m_bVirtApplied >> 2 & 1;
            if (num1 == 1)
            {
                checkBox_MusicMode.Checked = true;
            }

            if (num2 == 1)
            {
                checkBox_MovieMode.Checked = true;
            }

            if (num3 == 1)
            {
                checkBox_Freestyle.Checked = true;
            }

            onOffSwitch_EnvRealize.SwitchedOn = m_paramSystem.m_bEnvRealizeEnabled == 1;
            hSlider_EnvRealizeDrySignal.PositionFloat = m_paramSystem.m_rEnvRealizeDrySignal;
            twoSelector_PrePostProcess.Selector = m_paramSystem.m_bEnvRealizePreprocess != 1 ? TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT : TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
            for (int index = 0; index < comboBox_EnvRealizePreset.Items.Count; ++index)
            {
                if ((comboBox_EnvRealizePreset.Items[index] as metroFormVirt.EnvRealizePreset).PresetID == m_paramSystem.m_nEnvRealizePreset)
                {
                    comboBox_EnvRealizePreset.SelectedIndex = index;
                    break;
                }
            }
        }

        public RuntimeUtils.ConfigProxy._ParamOfBaseSystem GetBaseSystemParam()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            if (checkBox_MusicMode.Checked)
            {
                num1 = 1;
            }

            if (checkBox_MovieMode.Checked)
            {
                num2 = 1;
            }

            if (checkBox_Freestyle.Checked)
            {
                num3 = 1;
            }

            m_paramSystem.m_bVirtApplied = num1 | num2 << 1 | num3 << 2;
            m_paramSystem.m_bEnvRealizeEnabled = !onOffSwitch_EnvRealize.SwitchedOn ? 0 : 1;
            m_paramSystem.m_bEnvRealizePreprocess = twoSelector_PrePostProcess.Selector != TwoSelector.SelectorPosition.SELECTOR_ON_LEFT ? 0 : 1;
            m_paramSystem.m_rEnvRealizeDrySignal = hSlider_EnvRealizeDrySignal.PositionFloat;
            if (comboBox_EnvRealizePreset.SelectedItem == null)
            {
                m_paramSystem.m_bEnvRealizeEnabled = 0;
            }
            else if (comboBox_EnvRealizePreset.SelectedItem.GetType() != typeof(metroFormVirt.EnvRealizePreset))
            {
                m_paramSystem.m_bEnvRealizeEnabled = 0;
            }
            else
            {
                m_paramSystem.m_nEnvRealizePreset = (comboBox_EnvRealizePreset.SelectedItem as metroFormVirt.EnvRealizePreset).PresetID;
            }

            return m_paramSystem;
        }
        private class EnvRealizePreset
        {
            private string m_szPresetName = "";
            private readonly int m_nPresetID = -1;

            public string PresetName => m_szPresetName;

            public string Text
            {
                get => m_szPresetName;
                set => m_szPresetName = value;
            }

            public int PresetID => m_nPresetID;

            public EnvRealizePreset(string szPresetName, int nPresetID)
            {
                m_szPresetName = szPresetName;
                m_nPresetID = nPresetID;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || obj.GetType() != typeof(metroFormVirt.EnvRealizePreset))
                {
                    return false;
                }

                metroFormVirt.EnvRealizePreset envRealizePreset = obj as metroFormVirt.EnvRealizePreset;
                return envRealizePreset.PresetName == m_szPresetName && envRealizePreset.PresetID == m_nPresetID;
            }

            public override int GetHashCode()
            {
                return m_nPresetID;
            }

            public override string ToString()
            {
                return m_szPresetName;
            }
        }
        private class SpeakerAngle
        {
            private float m_fAngle;

            public string AngleString => m_fAngle >= 0.0 ? "+" + m_fAngle.ToString("F01") : m_fAngle.ToString("F01");

            public float AngleFloat
            {
                get => m_fAngle;
                set => m_fAngle = value;
            }

            public SpeakerAngle(float fAngle)
            {
                m_fAngle = fAngle;
            }

            public override bool Equals(object obj)
            {
                return obj != null && obj.GetType() == typeof(metroFormVirt.SpeakerAngle) && (obj as SpeakerAngle).AngleFloat == (double)m_fAngle;
            }

            public override int GetHashCode()
            {
                return (int)Math.Round(m_fAngle);
            }

            public override string ToString()
            {
                return AngleString;
            }
        }
       

        private string FormatAngleString(float fAngle)
        {
            return fAngle >= 0.0 ? "+" + fAngle.ToString("F01") : fAngle.ToString("F01");
        }
        private void RefreshSpeakerList()
        {
            listView_Speaker.Items.Clear();
            switch (m_nCurrentAudioSystem)
            {
                case 0:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_00[0])
                    }));
                    break;
                case 1:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_01[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_01[1])
                    }));
                    break;
                case 2:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_02[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_02[1])
                    }));
                    break;
                case 3:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_03[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_03[1])
                    }));
                    break;
                case 4:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_04[3])
                    }));
                    break;
                case 5:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_05[5])
                    }));
                    break;
                case 6:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_06[6])
                    }));
                    break;
                case 7:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[7])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_07[7])
                    }));
                    break;
                case 8:
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[0])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[1])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[2])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_LFE,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[3])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKLEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[4])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[5])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_BACKCENTER,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[6])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDELEFT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[7])
                    }));
                    listView_Speaker.Items.Add(new ListViewItem(new string[2]
                    {
            GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
            FormatAngleString(m_paramSystem.m_rpChannelAngle_08[8])
                    }));
                    break;
            }
        }

        private void singleButton_ResetConfig_Click(object sender, EventArgs e)
        {
            m_paramSystem.m_rpChannelAngle_00 = new float[9];
            m_paramSystem.m_rpChannelAngle_01 = new float[9];
            m_paramSystem.m_rpChannelAngle_02 = new float[9];
            m_paramSystem.m_rpChannelAngle_03 = new float[9];
            m_paramSystem.m_rpChannelAngle_04 = new float[9];
            m_paramSystem.m_rpChannelAngle_05 = new float[9];
            m_paramSystem.m_rpChannelAngle_06 = new float[9];
            m_paramSystem.m_rpChannelAngle_07 = new float[9];
            m_paramSystem.m_rpChannelAngle_08 = new float[9];
            m_paramSystem.m_rpChannelAngle_00[0] = 0.0f;
            m_paramSystem.m_rpChannelAngle_01[0] = -30f;
            m_paramSystem.m_rpChannelAngle_01[1] = 30f;
            m_paramSystem.m_rpChannelAngle_02[0] = -90f;
            m_paramSystem.m_rpChannelAngle_02[1] = 90f;
            m_paramSystem.m_rpChannelAngle_03[0] = -150f;
            m_paramSystem.m_rpChannelAngle_03[1] = 150f;
            m_paramSystem.m_rpChannelAngle_04[0] = -45f;
            m_paramSystem.m_rpChannelAngle_04[1] = 45f;
            m_paramSystem.m_rpChannelAngle_04[2] = -135f;
            m_paramSystem.m_rpChannelAngle_04[3] = 135f;
            m_paramSystem.m_rpChannelAngle_05[0] = -30f;
            m_paramSystem.m_rpChannelAngle_05[1] = 30f;
            m_paramSystem.m_rpChannelAngle_05[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_05[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_05[4] = -110f;
            m_paramSystem.m_rpChannelAngle_05[5] = 110f;
            m_paramSystem.m_rpChannelAngle_06[0] = -30f;
            m_paramSystem.m_rpChannelAngle_06[1] = 30f;
            m_paramSystem.m_rpChannelAngle_06[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_06[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_06[4] = 180f;
            m_paramSystem.m_rpChannelAngle_06[5] = -90f;
            m_paramSystem.m_rpChannelAngle_06[6] = 90f;
            m_paramSystem.m_rpChannelAngle_07[0] = -30f;
            m_paramSystem.m_rpChannelAngle_07[1] = 30f;
            m_paramSystem.m_rpChannelAngle_07[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_07[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_07[4] = -150f;
            m_paramSystem.m_rpChannelAngle_07[5] = 150f;
            m_paramSystem.m_rpChannelAngle_07[6] = -90f;
            m_paramSystem.m_rpChannelAngle_07[7] = 90f;
            m_paramSystem.m_rpChannelAngle_08[0] = -30f;
            m_paramSystem.m_rpChannelAngle_08[1] = 30f;
            m_paramSystem.m_rpChannelAngle_08[2] = 0.0f;
            m_paramSystem.m_rpChannelAngle_08[3] = 0.0f;
            m_paramSystem.m_rpChannelAngle_08[4] = -150f;
            m_paramSystem.m_rpChannelAngle_08[5] = 150f;
            m_paramSystem.m_rpChannelAngle_08[6] = 180f;
            m_paramSystem.m_rpChannelAngle_08[7] = -90f;
            m_paramSystem.m_rpChannelAngle_08[8] = 90f;
            RefreshSpeakerList();
        }

        private void buttonBox_AudioSystemConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
