// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.Utils.Parameters
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ViPER4WindowsBin.Utils
{
    internal class Parameters
    {
        public const int EFFECT_MODE_MUSIC = 0;
        public const int EFFECT_MODE_MOVIE = 1;
        public const int EFFECT_MODE_FREESTYLE = 2;
        public const uint CF_DEFAULT_CLEVEL = 2949820;
        public const uint CF_CMOY_CLEVEL = 3932860;
        public const uint CF_JMEIER_CLEVEL = 6226570;
        public const float MINKNEEMULT = 0.0f;
        public const float MAXKNEEMULT = 4f;
        public const float MINATTACKTIME = 0.0001f;
        public const float MAXATTACKTIME = 0.2f;
        public const float MINRELEASETIME = 0.005f;
        public const float MAXRELEASETIME = 2f;
        public const float MAXGAINDB = 60f;
        public const float MINADAPTTIME = 1f;
        public const float MAXADAPTTIME = 4f;
        public const float MINCRESTTIME = 0.005f;
        public const float MAXCRESTTIME = 2f;

        public static char[] WriteStringToArray260(string szContext)
        {
            if (szContext.Length >= 260)
            {
                return new char[260];
            }

            char[] charArray = szContext.ToCharArray();
            char[] chArray = new char[260];
            for (int index = 0; index < chArray.Length; ++index)
            {
                chArray[index] = Convert.ToChar(0);
            }

            Array.Copy(charArray, chArray, charArray.Length);
            return chArray;
        }

        public static byte[] ParameterSerialize(object sParameter)
        {
            int length = Marshal.SizeOf(sParameter);
            IntPtr num = Marshal.AllocHGlobal(length);
            Marshal.StructureToPtr(sParameter, num, false);
            byte[] destination = new byte[length];
            Marshal.Copy(num, destination, 0, length);
            Marshal.FreeHGlobal(num);
            return destination;
        }

        public static RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1 DeserializeParamOfBaseSystem_1_0_1(
          byte[] baRawData)
        {
            System.Type type = typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1);
            int num1 = Marshal.SizeOf(type);
            if (num1 != baRawData.Length)
            {
                return new RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1()
                {
                    m_bEffectEnabled = 0,
                    m_nEffectMode = 0,
                    m_nFilterShortLen = 4096,
                    m_nFilterMediumLen = 0,
                    m_nFilterLongLen = 0,
                    m_rChannelPan = 0.0f
                };
            }

            IntPtr num2 = Marshal.AllocHGlobal(num1);
            Marshal.Copy(baRawData, 0, num2, num1);
            object structure = Marshal.PtrToStructure(num2, type);
            Marshal.FreeHGlobal(num2);
            return (RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1)structure;
        }

        public static RuntimeUtils.ConfigProxy._ParamOfBaseSystem DeserializeParamOfBaseSystem(
          byte[] baRawData)
        {
            System.Type type = typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);
            int num1 = Marshal.SizeOf(type);
            if (num1 != baRawData.Length)
            {
                RuntimeUtils.ConfigProxy._ParamOfBaseSystem sParameter = new RuntimeUtils.ConfigProxy._ParamOfBaseSystem();
                Parameters.LoadDefaultParameter(ref sParameter);
                return sParameter;
            }
            IntPtr num2 = Marshal.AllocHGlobal(num1);
            Marshal.Copy(baRawData, 0, num2, num1);
            object structure = Marshal.PtrToStructure(num2, type);
            Marshal.FreeHGlobal(num2);
            return (RuntimeUtils.ConfigProxy._ParamOfBaseSystem)structure;
        }

        public static RuntimeUtils.ConfigProxy._ParamOfMusicMode DeserializeParamOfMusicMode(
          byte[] baRawData)
        {
            System.Type type = typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode);
            int num1 = Marshal.SizeOf(type);
            if (num1 != baRawData.Length)
            {
                RuntimeUtils.ConfigProxy._ParamOfMusicMode sParameter = new RuntimeUtils.ConfigProxy._ParamOfMusicMode();
                Parameters.LoadDefaultParameter(ref sParameter);
                return sParameter;
            }
            IntPtr num2 = Marshal.AllocHGlobal(num1);
            Marshal.Copy(baRawData, 0, num2, num1);
            object structure = Marshal.PtrToStructure(num2, type);
            Marshal.FreeHGlobal(num2);
            return (RuntimeUtils.ConfigProxy._ParamOfMusicMode)structure;
        }

        public static RuntimeUtils.ConfigProxy._ParamOfMovieMode DeserializeParamOfMovieMode(
          byte[] baRawData)
        {
            System.Type type = typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode);
            int num1 = Marshal.SizeOf(type);
            if (num1 != baRawData.Length)
            {
                RuntimeUtils.ConfigProxy._ParamOfMovieMode sParameter = new RuntimeUtils.ConfigProxy._ParamOfMovieMode();
                Parameters.LoadDefaultParameter(ref sParameter);
                return sParameter;
            }
            IntPtr num2 = Marshal.AllocHGlobal(num1);
            Marshal.Copy(baRawData, 0, num2, num1);
            object structure = Marshal.PtrToStructure(num2, type);
            Marshal.FreeHGlobal(num2);
            return (RuntimeUtils.ConfigProxy._ParamOfMovieMode)structure;
        }

        public static RuntimeUtils.ConfigProxy._ParamOfFreestyle DeserializeParamOfFreestyle(
          byte[] baRawData)
        {
            System.Type type = typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle);
            int num1 = Marshal.SizeOf(type);
            if (num1 != baRawData.Length)
            {
                RuntimeUtils.ConfigProxy._ParamOfFreestyle sParameter = new RuntimeUtils.ConfigProxy._ParamOfFreestyle();
                Parameters.LoadDefaultParameter(ref sParameter);
                return sParameter;
            }
            IntPtr num2 = Marshal.AllocHGlobal(num1);
            Marshal.Copy(baRawData, 0, num2, num1);
            object structure = Marshal.PtrToStructure(num2, type);
            Marshal.FreeHGlobal(num2);
            return (RuntimeUtils.ConfigProxy._ParamOfFreestyle)structure;
        }

        public static void SaveLocalPreset(
          string szFilePathName,
          RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem,
          RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode,
          RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode,
          RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle)
        {
            byte[] buffer1 = Parameters.ParameterSerialize(paramBaseSystem);
            byte[] buffer2 = Parameters.ParameterSerialize(paramMusicMode);
            byte[] buffer3 = Parameters.ParameterSerialize(paramMovieMode);
            byte[] buffer4 = Parameters.ParameterSerialize(paramFreestyle);
            if (buffer1 == null || buffer2 == null || buffer3 == null)
            {
                return;
            }

            if (buffer4 == null)
            {
                return;
            }

            try
            {
                FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
                byte[] buffer5 = new byte[14]
                {
           86,
           105,
           80,
           69,
           82,
           52,
           87,
           105,
           110,
           100,
           111,
           119,
           115,
           88
                };
                fileStream.Write(buffer5, 0, buffer5.Length);
                fileStream.WriteByte(1);
                fileStream.WriteByte(1);
                fileStream.WriteByte(1);
                fileStream.WriteByte(1);
                fileStream.Write(buffer1, 0, buffer1.Length);
                fileStream.Write(buffer2, 0, buffer2.Length);
                fileStream.Write(buffer3, 0, buffer3.Length);
                fileStream.Write(buffer4, 0, buffer4.Length);
                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(ERROR);
                stringBuilder.AppendLine(TECHNICAL_INFO);
                stringBuilder.AppendLine(ex.Message);
                int num = (int)MessageBox.Show(stringBuilder.ToString(), ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public static string LANGUAGE_VERSION_STR = "";
        public static string LANGUAGE_TRANSLATOR_STR = "";
        public static string OK = "OKay";
        public static string CANCEL = "Cancel";
        public static string ENABLE = "Enable";
        public static string LANGUAGE_CHANGE_NOTICE = "The UI language changed, you need to restart the program.";
        public static string MENU_LANGUAGE = "Language";
        public static string MENU_SETTING = "Setting";
        public static string MENU_HELP = "Help";
        public static string LATENCY_SETTING = "Latency Setting";
        public static string CURRENT_LATENCY = "Current Latency";
        public static string DESIRED_LATENCY = "Desired Latency";
        public static string LOW_LATENCY_NOTE = "Lower latency will increase CPU load.";
        public static string CHANNEL_PAN = "Channel Pan";
        public static string LEFT = "Left";
        public static string RIGHT = "Right";
        public static string BALANCE = "Balance";
        public static string VIRTUALIZATION = "Virtualization";
        public static string AUDIO_SYSTEM_CONFIG = "Audio system config";
        public static string AUDIO_SYSTEM_MONO = "Mono";
        public static string AUDIO_SYSTEM_STEREO = "2.0 System";
        public static string AUDIO_SYSTEM_HEADSET = "Headset";
        public static string AUDIO_SYSTEM_REARSTEREO = "Rear 2.0";
        public static string AUDIO_SYSTEM_QUAD = "4.0 System";
        public static string AUDIO_SYSTEM_X5P1 = "5.1 System";
        public static string AUDIO_SYSTEM_X6P1 = "6.1 System";
        public static string AUDIO_SYSTEM_X7P1 = "7.1 System";
        public static string AUDIO_SYSTEM_X8P1 = "8.1 System";
        public static string VIRT_APPLIED = "Apply virtualization";
        public static string VIRT_PREPOST_PROCESS = "Pre/Post Process";
        public static string VIRT_RESET = "Reset config";
        public static string VIRT_SPEAKER = "Speaker";
        public static string VIRT_SPEAKER_ANGLE = "Angle";
        public static string VIRT_SPEAKER_FRONTLEFT = "Front Left";
        public static string VIRT_SPEAKER_FRONTRIGHT = "Front Right";
        public static string VIRT_SPEAKER_FRONTCENTER = "Front Center";
        public static string VIRT_SPEAKER_LFE = "LFE (Subwoofer)";
        public static string VIRT_SPEAKER_BACKLEFT = "Back Left";
        public static string VIRT_SPEAKER_BACKRIGHT = "Back Right";
        public static string VIRT_SPEAKER_BACKCENTER = "Back Center";
        public static string VIRT_SPEAKER_SIDELEFT = "Side Left";
        public static string VIRT_SPEAKER_SIDERIGHT = "Side Right";
        public static string VIRT_ENVIRONMENT = "Virtual Environment";
        public static string VIRT_ENVIR_SMALLROOM = "Small Room";
        public static string VIRT_ENVIR_BATHROOM = "Bath Room";
        public static string VIRT_ENVIR_LIVINGROOM = "Living Room";
        public static string VIRT_ENVIR_STONEROOM = "Stone Room";
        public static string VIRT_ENVIR_AUDITORIUM = "Auditorium";
        public static string VIRT_ENVIR_CONCERTHALL = "Concert Hall";
        public static string VIRT_ENVIR_HALLWAY = "Hallway";
        public static string RESET_EFFECT = "Reset Effects";
        public static string SETTINGS = "Settings";
        public static string CLOSE_TO_TRAY = "Minimize app to tray when close";
        public static string TRAY_MENU_SETTING = "Tray menu setting";
        public static string TRAY_MENU_PRESETNAME = "Name";
        public static string TRAY_MENU_PRESETMODE = "Mode";
        public static string TRAY_MENU_PRESETFILE = "Preset";
        public static string ADD_NEW_ITEM = "Add new item";
        public static string REMOVE_ITEM = "Remove item";
        public static string REMOVE_ITEM_QUESTION = "Do you really want to remove this item ?";
        public static string MENU_TIPS_NAME = "Name:";
        public static string MENU_TIPS_MODE = "Mode:";
        public static string SELECT_PRESET_FILE = "Select preset file";
        public static string UNNAMED = "Unnamed";
        public static string SWITCH_OFF_EFFECT = "Switch off effect";
        public static string SWITCH_ON_EFFECT = "Switch on effect";
        public static string EXIT_APPLICTION = "Exit";
        public static string ENABLE_APO_COEXIST = "Enable APO coexists";
        public static string ENABLE_APO_COEXIST_WRN_LINE1 = "When APO coexists enabled, you can use all audio effects at the same time.";
        public static string ENABLE_APO_COEXIST_WRN_LINE2 = "But maybe this is unstable, please turn off this function if you got any audio problem.";
        public static string ENABLE_APO_COEXIST_RESTART = "You must restart your computer before the new setting will take effect.";
        public static string CHECK_UPDATE = "Check for update";
        public static string CHECK = "Check";
        public static string VERSION_FROM_INTERNET = "Version from internet";
        public static string COPY_DOWNLOAD_LINK = "Copy download link";
        public static string ABOUT = "About";
        public static string CONTROL_PANEL_VERSION = "Control Panel Version";
        public static string DRIVER_VERSION = "V4W Driver Version";
        public static string CODE_NAME = "V4W Codename";
        public static string LANGUAGE_VERSION = "Language Translate Version";
        public static string LANGUAGE_TRANSLATOR = "Language Translator";
        public static string COPYRIGHT = "Copyright (C) 2013, vipercn.com. All rights reserved.";
        public static string SUPPORT_FORUM = "Forum http://forum.vipersaudio.com";
        public static string MASTER_POWER = "Power";
        public static string MUSIC_MODE = "Music Mode";
        public static string MOVIE_MODE = "Movie Mode";
        public static string FREESTYLE_MODE = "Freestyle";
        public static string PRESET = "Preset";
        public static string LOAD_PRESET = "Load preset";
        public static string SAVE_PRESET = "Save preset";
        public static string ERROR = "Error";
        public static string INFORMATION = "Information";
        public static string CANT_LOAD_IRS = "Can't load impulse response, maybe selected wrong file.";
        public static string DRIVER_NOT_CONFIG = "The driver not configured, please run \"Configure\" first.";
        public static string CANT_SAVE_PRESET = "Can't save effect preset.";
        public static string CANT_LOAD_PRESET = "Can't load effect preset.";
        public static string TECHNICAL_INFO = "Technical info:";
        public static string PRE_VOLUME = "Pre-Volume";
        public static string POST_VOLUME = "Post-Volume";
        public static string CONVOLVER = "Convolver";
        public static string CONV_IR_GAIN = "IRS Power";
        public static string OPEN_CONV_IRS = "Open Impulse Response Sample";
        public static string SURROUND = "Surround";
        public static string THREE_D_SURROUND = "3D Surround";
        public static string SURROUND_3D = "Space Size";
        public static string SURROUND_IMAGE = "Image Size";
        public static string VHE_SURROUND = "ViPER Headphone Engine";
        public static string VHE_SMALLEST_ROOM = "Smallest Room";
        public static string VHE_SMALL_ROOM = "Small Room";
        public static string VHE_MID_ROOM = "Mid Size Room";
        public static string VHE_LARGE_ROOM = "Large Room";
        public static string VHE_LARGEST_ROOM = "Largest Room";
        public static string BASS = "ViPER XBass";
        public static string BASS_SPKSIZE = "Speaker Size";
        public static string BASS_GAIN = "Bass Level";
        public static string NATURAL_BASS = "Natural Bass";
        public static string PURE_BASS = "Pure Bass";
        public static string CLARITY = "ViPER XClarity";
        public static string NATURAL_CLARITY = "Natural";
        public static string OZONE_CLARITY = "OZone+";
        public static string XHIFI_CLARITY = "X-HiFi";
        public static string CURE = "Cure Tech +";
        public static string SLIGHT_CURE = "Slight";
        public static string MODERATE_CURE = "Moderate";
        public static string EXTREME_CURE = "Extreme";
        public static string TUBE = "Tube Simulator";
        public static string SMART_VOLUME = "ViPER Smart Volume";
        public static string SMART_VOLUME_CONTROL_STRENGTH = "Control Strength";
        public static string SMART_VOLUME_MAXLEVEL = "Max Gain";
        public static string SMART_VOLUME_LEVEL = "Desired Volume";
        public static string EQUALIZER_ADJUST = "Equalizer";
        public static string COMPRESSOR_ADJUST = "Compressor";
        public static string REVERB = "Reverberation";
        public static string REVERB_PRESET = "Reverberation Preset";
        public static string REVERB_PRESET_LIVINGROOM = "Living Room";
        public static string REVERB_PRESET_BATHROOM = "Bath Room";
        public static string REVERB_PRESET_BATHROOM_BATHING = "Bath Room (Bathing)";
        public static string REVERB_PRESET_BEDROOM = "Bed Room";
        public static string REVERB_PRESET_THEATER = "Theater";
        public static string REVERB_PRESET_AUDITORIUM = "Auditorium";
        public static string REVERB_PRESET_UNDERGROUND_PLAZA = "Underground Plaza";
        public static string REVERB_PRESET_UNDERGROUND_PARKING = "Underground Parking";
        public static string REVERB_PRESET_SCENE_SHOW = "Scene Show";
        public static string REVERB_SIZE = "Room Size";
        public static string REVERB_DAMPING = "Damping";
        public static string REVERB_DENSITY = "Density";
        public static string REVERB_BANDWIDTH = "Bandwidth";
        public static string REVERB_DECAY = "Decay";
        public static string REVERB_PREDELAY = "Pre-delay";
        public static string REVERB_EARLYMIX = "Early Mix";
        public static string REVERB_MIX = "Wet Mix";
        public static string EQUALIZER = "Equalizer";
        public static string EQUALIZER_REALTIME_ADJUST = "Realtime adjusting (more CPU usage)";
        public static string EQUALIZER_PRESET = "Equalizer Preset";
        public static string EQUALIZER_PRESET_FLAT = "Flat (Reset)";
        public static string EQUALIZER_PRESET_SUPERBASS = "Super Bass";
        public static string EQUALIZER_PRESET_SOFTBASS = "Soft Bass";
        public static string EQUALIZER_PRESET_ROCK = "Rock Music";
        public static string EQUALIZER_PRESET_RANDB = "R&B Music";
        public static string EQUALIZER_PRESET_CLASSIC = "Classic Music";
        public static string EQUALIZER_PRESET_POP = "POP Music";
        public static string EQUALIZER_PRESET_JAZZ = "Jazz Music";
        public static string EQUALIZER_PRESET_BLUES = "Blues Style";
        public static string EQUALIZER_PRESET_ELECTRONIC = "Electronic";
        public static string EQUALIZER_PRESET_VOCAL = "Vocal Enhance";
        public static string COMPRESSOR = "Compressor";
        public static string COMPRESSOR_THRESHOLD = "Threshold";
        public static string COMPRESSOR_KNEEWIDTH = "Knee Width";
        public static string COMPRESSOR_AUTOKNEE = "Auto Knee Control";
        public static string COMPRESSOR_RATIO = "Ratio";
        public static string COMPRESSOR_ATTACK = "Attack Time";
        public static string COMPRESSOR_AUTOATTACK = "Auto Attack Control";
        public static string COMPRESSOR_RELEASE = "Release Time";
        public static string COMPRESSOR_AUTORELEASE = "Auto Release Control";
        public static string COMPRESSOR_MAKEUPGAIN = "Make-Up Gain";
        public static string COMPRESSOR_AUTOGAIN = "Auto Gain Control";
        public static string COMPRESSOR_MISC = "Misc";
        public static string COMPRESSOR_NOCLIP = "Prevent Clipping";
        public static string COMPRESSOR_KNEEMULT = "Knee Mult";
        public static string COMPRESSOR_MAXATTACK = "Max Attack Time";
        public static string COMPRESSOR_MAXRELEASE = "Max Release Time";
        public static string COMPRESSOR_CRESTTIME = "Crest Time";
        public static string COMPRESSOR_ADAPTTIME = "Adapt Time";
        public static bool SavePreset(
          string szFilePathName,
          RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode)
        {
            byte[] buffer1 = Parameters.ParameterSerialize(paramMusicMode);
            if (buffer1 == null)
            {
                return false;
            }

            try
            {
                FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
                byte[] buffer2 = new byte[14]
                {
           86,
           105,
           80,
           69,
           82,
           52,
           87,
           105,
           110,
           100,
           111,
           119,
           115,
           88
                };
                fileStream.Write(buffer2, 0, buffer2.Length);
                fileStream.WriteByte(0);
                fileStream.WriteByte(1);
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                fileStream.Write(buffer1, 0, buffer1.Length);
                fileStream.Flush();
                fileStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SavePreset(
          string szFilePathName,
          RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode)
        {
            byte[] buffer1 = Parameters.ParameterSerialize(paramMovieMode);
            if (buffer1 == null)
            {
                return false;
            }

            try
            {
                FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
                byte[] buffer2 = new byte[14]
                {
           86,
           105,
           80,
           69,
           82,
           52,
           87,
           105,
           110,
           100,
           111,
           119,
           115,
           88
                };
                fileStream.Write(buffer2, 0, buffer2.Length);
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                fileStream.WriteByte(1);
                fileStream.WriteByte(0);
                fileStream.Write(buffer1, 0, buffer1.Length);
                fileStream.Flush();
                fileStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SavePreset(
          string szFilePathName,
          RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle)
        {
            byte[] buffer1 = Parameters.ParameterSerialize(paramFreestyle);
            if (buffer1 == null)
            {
                return false;
            }

            try
            {
                FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
                byte[] buffer2 = new byte[14]
                {
           86,
           105,
           80,
           69,
           82,
           52,
           87,
           105,
           110,
           100,
           111,
           119,
           115,
           88
                };
                fileStream.Write(buffer2, 0, buffer2.Length);
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                fileStream.WriteByte(1);
                fileStream.Write(buffer1, 0, buffer1.Length);
                fileStream.Flush();
                fileStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ReadPreset(
          string szFilePathName,
          ref RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem,
          ref RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode,
          ref RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode,
          ref RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle,
          out bool bPBaseSystem,
          out bool bPMusicMode,
          out bool bPMovieMode,
          out bool bPFreestyle)
        {
            if (szFilePathName == null)
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
            if (szFilePathName.Length <= 0)
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
            if (!File.Exists(szFilePathName))
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
            long length;
            try
            {
                length = new FileInfo(szFilePathName).Length;
            }
            catch
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
            if (length <= 0L)
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
            try
            {
                FileStream fileStream = new FileStream(szFilePathName, FileMode.Open);
                byte[] numArray1 = new byte[14]
                {
           86,
           105,
           80,
           69,
           82,
           52,
           87,
           105,
           110,
           100,
           111,
           119,
           115,
           88
                };
                byte[] buffer = new byte[14];
                if (fileStream.Read(buffer, 0, buffer.Length) != buffer.Length)
                {
                    fileStream.Close();
                    bPBaseSystem = false;
                    bPMusicMode = false;
                    bPMovieMode = false;
                    bPFreestyle = false;
                    return false;
                }
                for (int index = 0; index < numArray1.Length; ++index)
                {
                    if (buffer[index] != numArray1[index])
                    {
                        fileStream.Close();
                        bPBaseSystem = false;
                        bPMusicMode = false;
                        bPMovieMode = false;
                        bPFreestyle = false;
                        return false;
                    }
                }
                int num1 = fileStream.ReadByte();
                int num2 = fileStream.ReadByte();
                int num3 = fileStream.ReadByte();
                int num4 = fileStream.ReadByte();
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                long num5 = 18;
                if (num1 == 1)
                {
                    num5 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem));
                }

                if (num2 == 1)
                {
                    num5 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode));
                }

                if (num3 == 1)
                {
                    num5 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode));
                }

                if (num4 == 1)
                {
                    num5 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle));
                }

                if (num5 != length)
                {
                    long num6 = 18;
                    if (num1 == 1)
                    {
                        num6 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1));
                    }

                    if (num2 == 1)
                    {
                        num6 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode));
                    }

                    if (num3 == 1)
                    {
                        num6 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode));
                    }

                    if (num4 == 1)
                    {
                        num6 += Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle));
                    }

                    if (num6 == length)
                    {
                        if (num1 == 1)
                        {
                            byte[] numArray2 = new byte[Marshal.SizeOf((object)new RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1())];
                            if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                            {
                                fileStream.Close();
                                bPBaseSystem = false;
                                bPMusicMode = false;
                                bPMovieMode = false;
                                bPFreestyle = false;
                                return false;
                            }
                            RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1 paramOfBaseSystem101 = Parameters.DeserializeParamOfBaseSystem_1_0_1(numArray2);
                            Parameters.LoadDefaultParameter(ref paramBaseSystem);
                            paramBaseSystem.m_bEffectEnabled = paramOfBaseSystem101.m_bEffectEnabled;
                            paramBaseSystem.m_nEffectMode = paramOfBaseSystem101.m_nEffectMode;
                            paramBaseSystem.m_nFilterShortLen = paramOfBaseSystem101.m_nFilterShortLen;
                            paramBaseSystem.m_nFilterMediumLen = paramOfBaseSystem101.m_nFilterMediumLen;
                            paramBaseSystem.m_nFilterLongLen = paramOfBaseSystem101.m_nFilterLongLen;
                            paramBaseSystem.m_rChannelPan = paramOfBaseSystem101.m_rChannelPan;
                            bPBaseSystem = true;
                        }
                        if (num2 == 1)
                        {
                            byte[] numArray2 = new byte[Marshal.SizeOf((object)paramMusicMode)];
                            if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                            {
                                fileStream.Close();
                                bPBaseSystem = false;
                                bPMusicMode = false;
                                bPMovieMode = false;
                                bPFreestyle = false;
                                return false;
                            }
                            paramMusicMode = Parameters.DeserializeParamOfMusicMode(numArray2);
                            bPMusicMode = true;
                        }
                        if (num3 == 1)
                        {
                            byte[] numArray2 = new byte[Marshal.SizeOf((object)paramMovieMode)];
                            if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                            {
                                fileStream.Close();
                                bPBaseSystem = false;
                                bPMusicMode = false;
                                bPMovieMode = false;
                                bPFreestyle = false;
                                return false;
                            }
                            paramMovieMode = Parameters.DeserializeParamOfMovieMode(numArray2);
                            bPMovieMode = true;
                        }
                        if (num4 == 1)
                        {
                            byte[] numArray2 = new byte[Marshal.SizeOf((object)paramFreestyle)];
                            if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                            {
                                fileStream.Close();
                                bPBaseSystem = false;
                                bPMusicMode = false;
                                bPMovieMode = false;
                                bPFreestyle = false;
                                return false;
                            }
                            paramFreestyle = Parameters.DeserializeParamOfFreestyle(numArray2);
                            bPFreestyle = true;
                        }
                        fileStream.Close();
                        if (bPBaseSystem && bPMusicMode && (bPMovieMode && bPFreestyle))
                        {
                            Parameters.SaveLocalPreset(szFilePathName, paramBaseSystem, paramMusicMode, paramMovieMode, paramFreestyle);
                        }

                        return true;
                    }
                    fileStream.Close();
                    bPBaseSystem = false;
                    bPMusicMode = false;
                    bPMovieMode = false;
                    bPFreestyle = false;
                    return false;
                }
                if (num1 == 1)
                {
                    byte[] numArray2 = new byte[Marshal.SizeOf((object)paramBaseSystem)];
                    if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                    {
                        fileStream.Close();
                        bPBaseSystem = false;
                        bPMusicMode = false;
                        bPMovieMode = false;
                        bPFreestyle = false;
                        return false;
                    }
                    paramBaseSystem = Parameters.DeserializeParamOfBaseSystem(numArray2);
                    bPBaseSystem = true;
                }
                if (num2 == 1)
                {
                    byte[] numArray2 = new byte[Marshal.SizeOf((object)paramMusicMode)];
                    if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                    {
                        fileStream.Close();
                        bPBaseSystem = false;
                        bPMusicMode = false;
                        bPMovieMode = false;
                        bPFreestyle = false;
                        return false;
                    }
                    paramMusicMode = Parameters.DeserializeParamOfMusicMode(numArray2);
                    bPMusicMode = true;
                }
                if (num3 == 1)
                {
                    byte[] numArray2 = new byte[Marshal.SizeOf((object)paramMovieMode)];
                    if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                    {
                        fileStream.Close();
                        bPBaseSystem = false;
                        bPMusicMode = false;
                        bPMovieMode = false;
                        bPFreestyle = false;
                        return false;
                    }
                    paramMovieMode = Parameters.DeserializeParamOfMovieMode(numArray2);
                    bPMovieMode = true;
                }
                if (num4 == 1)
                {
                    byte[] numArray2 = new byte[Marshal.SizeOf((object)paramFreestyle)];
                    if (fileStream.Read(numArray2, 0, numArray2.Length) != numArray2.Length)
                    {
                        fileStream.Close();
                        bPBaseSystem = false;
                        bPMusicMode = false;
                        bPMovieMode = false;
                        bPFreestyle = false;
                        return false;
                    }
                    paramFreestyle = Parameters.DeserializeParamOfFreestyle(numArray2);
                    bPFreestyle = true;
                }
                fileStream.Close();
                return true;
            }
            catch
            {
                bPBaseSystem = false;
                bPMusicMode = false;
                bPMovieMode = false;
                bPFreestyle = false;
                return false;
            }
        }

        public static float LOG2PARAM(float x, float mn, float mx)
        {
            return (float)((Math.Log(x) - Math.Log(mn)) / (Math.Log(mx) - Math.Log(mn)));
        }

        public static float LIN2PARAM(float x, float mn, float mx)
        {
            return (float)((x - (double)mn) / (mx - (double)mn));
        }

        public static float PARAM2LOG(float x, float mn, float mx)
        {
            return (float)Math.Exp(Math.Log(mn) + x * (Math.Log(mx) - Math.Log(mn)));
        }

        public static float PARAM2LIN(float x, float mn, float mx)
        {
            return mn + x * (mx - mn);
        }

        public static void LoadDefaultParameter(
          ref RuntimeUtils.ConfigProxy._ParamOfBaseSystem sParameter)
        {
            sParameter.m_bEffectEnabled = 0;
            sParameter.m_nEffectMode = 0U;
            sParameter.m_nFilterShortLen = 4096;
            sParameter.m_nFilterMediumLen = 0;
            sParameter.m_nFilterLongLen = 0;
            sParameter.m_rChannelPan = 0.0f;
            sParameter.m_bVirtApplied = 0;
            sParameter.m_rpChannelAngle_00 = new float[9];
            sParameter.m_rpChannelAngle_01 = new float[9];
            sParameter.m_rpChannelAngle_02 = new float[9];
            sParameter.m_rpChannelAngle_03 = new float[9];
            sParameter.m_rpChannelAngle_04 = new float[9];
            sParameter.m_rpChannelAngle_05 = new float[9];
            sParameter.m_rpChannelAngle_06 = new float[9];
            sParameter.m_rpChannelAngle_07 = new float[9];
            sParameter.m_rpChannelAngle_08 = new float[9];
            sParameter.m_rpChannelAngle_00[0] = 0.0f;
            sParameter.m_rpChannelAngle_01[0] = -30f;
            sParameter.m_rpChannelAngle_01[1] = 30f;
            sParameter.m_rpChannelAngle_02[0] = -90f;
            sParameter.m_rpChannelAngle_02[1] = 90f;
            sParameter.m_rpChannelAngle_03[0] = -150f;
            sParameter.m_rpChannelAngle_03[1] = 150f;
            sParameter.m_rpChannelAngle_04[0] = -45f;
            sParameter.m_rpChannelAngle_04[1] = 45f;
            sParameter.m_rpChannelAngle_04[2] = -135f;
            sParameter.m_rpChannelAngle_04[3] = 135f;
            sParameter.m_rpChannelAngle_05[0] = -30f;
            sParameter.m_rpChannelAngle_05[1] = 30f;
            sParameter.m_rpChannelAngle_05[2] = 0.0f;
            sParameter.m_rpChannelAngle_05[3] = 0.0f;
            sParameter.m_rpChannelAngle_05[4] = -110f;
            sParameter.m_rpChannelAngle_05[5] = 110f;
            sParameter.m_rpChannelAngle_06[0] = -30f;
            sParameter.m_rpChannelAngle_06[1] = 30f;
            sParameter.m_rpChannelAngle_06[2] = 0.0f;
            sParameter.m_rpChannelAngle_06[3] = 0.0f;
            sParameter.m_rpChannelAngle_06[4] = 180f;
            sParameter.m_rpChannelAngle_06[5] = -90f;
            sParameter.m_rpChannelAngle_06[6] = 90f;
            sParameter.m_rpChannelAngle_07[0] = -30f;
            sParameter.m_rpChannelAngle_07[1] = 30f;
            sParameter.m_rpChannelAngle_07[2] = 0.0f;
            sParameter.m_rpChannelAngle_07[3] = 0.0f;
            sParameter.m_rpChannelAngle_07[4] = -150f;
            sParameter.m_rpChannelAngle_07[5] = 150f;
            sParameter.m_rpChannelAngle_07[6] = -90f;
            sParameter.m_rpChannelAngle_07[7] = 90f;
            sParameter.m_rpChannelAngle_08[0] = -30f;
            sParameter.m_rpChannelAngle_08[1] = 30f;
            sParameter.m_rpChannelAngle_08[2] = 0.0f;
            sParameter.m_rpChannelAngle_08[3] = 0.0f;
            sParameter.m_rpChannelAngle_08[4] = -150f;
            sParameter.m_rpChannelAngle_08[5] = 150f;
            sParameter.m_rpChannelAngle_08[6] = 180f;
            sParameter.m_rpChannelAngle_08[7] = -90f;
            sParameter.m_rpChannelAngle_08[8] = 90f;
            sParameter.m_bEnvRealizeEnabled = 0;
            sParameter.m_bEnvRealizePreprocess = 1;
            sParameter.m_nEnvRealizePreset = 2;
            sParameter.m_rEnvRealizeDrySignal = 1f;
        }

        public static void LoadDefaultParameter(
          ref RuntimeUtils.ConfigProxy._ParamOfMusicMode sParameter)
        {
            sParameter.m_rPreVolume = 1f;
            sParameter.m_bConvolverEnabled = 0;
            sParameter.m_szConvolverIR = new char[260];
            for (int index = 0; index < 256; ++index)
            {
                sParameter.m_szConvolverIR[index] = char.MinValue;
            }

            sParameter.m_rConvolverIRGain = 1f;
            sParameter.m_bViPERBassEnabled = 0;
            sParameter.m_nViPERBassSpkSize = 60;
            sParameter.m_rViPERBassFactor = 0.0f;
            sParameter.m_bViPERClarityEnabled = 0;
            sParameter.m_nViPERClarityMode = 0;
            sParameter.m_rViPERClarityFactor = 0.0f;
            sParameter.m_bSurroundEnabled = 0;
            sParameter.m_nVHERoomSize = 0;
            sParameter.m_bReverbEnabled = 0;
            sParameter.m_rReverbSize = 0.0f;
            sParameter.m_rReverbPredelay = 0.0f;
            sParameter.m_rReverbDamping = 0.0f;
            sParameter.m_rReverbDensity = 0.0f;
            sParameter.m_rReverbBandwidth = 1f;
            sParameter.m_rReverbDecay = 0.0f;
            sParameter.m_rReverbEarlyMix = 0.0f;
            sParameter.m_rReverbMix = 0.0f;
            sParameter.m_rReverbGain = 1f;
            sParameter.m_bEqualizerEnabled = 0;
            sParameter.m_rpEqualizerBands = new float[18];
            for (int index = 0; index < 18; ++index)
            {
                sParameter.m_rpEqualizerBands[index] = 1f;
            }

            sParameter.m_bCompressorEnabled = 0;
            sParameter.m_bCompAutoKnee = 1;
            sParameter.m_bCompAutoGain = 1;
            sParameter.m_bCompAutoAttack = 1;
            sParameter.m_bCompAutoRelease = 1;
            sParameter.m_rCompThreshold = 0.0f;
            sParameter.m_rCompRatio = 0.0f;
            sParameter.m_rCompKneeWidth = 0.0f;
            sParameter.m_rCompGain = 0.0f;
            sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
            sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
            sParameter.m_bCureEnabled = 0;
            sParameter.m_uiCureLevel = 6226570U;
            sParameter.m_bTubeEnabled = 0;
            sParameter.m_rPostVolume = 1f;
        }

        public static void LoadDefaultParameter(
          ref RuntimeUtils.ConfigProxy._ParamOfMovieMode sParameter)
        {
            sParameter.m_rPreVolume = 1f;
            sParameter.m_bConvolverEnabled = 0;
            sParameter.m_szConvolverIR = new char[260];
            for (int index = 0; index < 256; ++index)
            {
                sParameter.m_szConvolverIR[index] = char.MinValue;
            }

            sParameter.m_rConvolverIRGain = 1f;
            sParameter.m_bViPERBassEnabled = 0;
            sParameter.m_nViPERBassSpkSize = 60;
            sParameter.m_rViPERBassFactor = 0.0f;
            sParameter.m_bViPERClarityEnabled = 0;
            sParameter.m_rViPERClarityFactor = 0.0f;
            sParameter.m_bSurroundEnabled = 0;
            sParameter.m_r3DSurroundStereo = 1f;
            sParameter.m_r3DSurroundImage = 1f;
            sParameter.m_bReverbEnabled = 0;
            sParameter.m_rReverbSize = 0.0f;
            sParameter.m_rReverbPredelay = 0.0f;
            sParameter.m_rReverbDamping = 0.0f;
            sParameter.m_rReverbDensity = 0.0f;
            sParameter.m_rReverbBandwidth = 1f;
            sParameter.m_rReverbDecay = 0.0f;
            sParameter.m_rReverbEarlyMix = 0.0f;
            sParameter.m_rReverbMix = 0.0f;
            sParameter.m_rReverbGain = 1f;
            sParameter.m_bEqualizerEnabled = 0;
            sParameter.m_rpEqualizerBands = new float[18];
            for (int index = 0; index < 18; ++index)
            {
                sParameter.m_rpEqualizerBands[index] = 1f;
            }

            sParameter.m_bCompressorEnabled = 0;
            sParameter.m_bCompAutoKnee = 1;
            sParameter.m_bCompAutoGain = 1;
            sParameter.m_bCompAutoAttack = 1;
            sParameter.m_bCompAutoRelease = 1;
            sParameter.m_rCompThreshold = 0.0f;
            sParameter.m_rCompRatio = 0.0f;
            sParameter.m_rCompKneeWidth = 0.0f;
            sParameter.m_rCompGain = 0.0f;
            sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
            sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
            sParameter.m_bSmartVolumeEnabled = 0;
            sParameter.m_rSVRatio = 0.5f;
            sParameter.m_rSVVolume = 1f;
            sParameter.m_rSVMaxGain = 4f;
            sParameter.m_rPostVolume = 1f;
        }

        public static void LoadDefaultParameter(
          ref RuntimeUtils.ConfigProxy._ParamOfFreestyle sParameter)
        {
            sParameter.m_rPreVolume = 1f;
            sParameter.m_bConvolverEnabled = 0;
            sParameter.m_szConvolverIR = new char[260];
            for (int index = 0; index < 256; ++index)
            {
                sParameter.m_szConvolverIR[index] = char.MinValue;
            }

            sParameter.m_rConvolverIRGain = 1f;
            sParameter.m_bViPERBassEnabled = 0;
            sParameter.m_nViPERBassMode = 0;
            sParameter.m_nViPERBassSpkSize = 60;
            sParameter.m_rViPERBassFactor = 0.0f;
            sParameter.m_bViPERClarityEnabled = 0;
            sParameter.m_nViPERClarityMode = 0;
            sParameter.m_rViPERClarityFactor = 0.0f;
            sParameter.m_b3DSurroundEnabled = 0;
            sParameter.m_r3DSurroundStereo = 1f;
            sParameter.m_r3DSurroundImage = 1f;
            sParameter.m_bVHESurroundEnabled = 0;
            sParameter.m_nVHERoomSize = 0;
            sParameter.m_bReverbEnabled = 0;
            sParameter.m_rReverbSize = 0.0f;
            sParameter.m_rReverbPredelay = 0.0f;
            sParameter.m_rReverbDamping = 0.0f;
            sParameter.m_rReverbDensity = 0.0f;
            sParameter.m_rReverbBandwidth = 1f;
            sParameter.m_rReverbDecay = 0.0f;
            sParameter.m_rReverbEarlyMix = 0.0f;
            sParameter.m_rReverbMix = 0.0f;
            sParameter.m_rReverbGain = 1f;
            sParameter.m_bEqualizerEnabled = 0;
            sParameter.m_rpEqualizerBands = new float[18];
            for (int index = 0; index < 18; ++index)
            {
                sParameter.m_rpEqualizerBands[index] = 1f;
            }

            sParameter.m_bCompressorEnabled = 0;
            sParameter.m_bCompAutoKnee = 1;
            sParameter.m_bCompAutoGain = 1;
            sParameter.m_bCompAutoAttack = 1;
            sParameter.m_bCompAutoRelease = 1;
            sParameter.m_bCompAutoMetaNoClipping = 1;
            sParameter.m_rCompThreshold = 0.0f;
            sParameter.m_rCompRatio = 0.0f;
            sParameter.m_rCompKneeWidth = 0.0f;
            sParameter.m_rCompGain = 0.0f;
            sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
            sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
            sParameter.m_rCompMetaKneeMult = Parameters.LIN2PARAM(2f, 0.0f, 4f);
            sParameter.m_rCompMetaMaxAttack = Parameters.LOG2PARAM(0.08f, 0.0001f, 0.2f);
            sParameter.m_rCompMetaMaxRelease = Parameters.LOG2PARAM(1f, 0.005f, 2f);
            sParameter.m_rCompMetaCrest = Parameters.LOG2PARAM(0.2f, 0.005f, 2f);
            sParameter.m_rCompMetaAdapt = Parameters.LOG2PARAM(2.5f, 1f, 4f);
            sParameter.m_bSmartVolumeEnabled = 0;
            sParameter.m_rSVRatio = 0.5f;
            sParameter.m_rSVVolume = 1f;
            sParameter.m_rSVMaxGain = 4f;
            sParameter.m_bCureEnabled = 0;
            sParameter.m_uiCureLevel = 6226570U;
            sParameter.m_bTubeEnabled = 0;
            sParameter.m_rPostVolume = 1f;
        }
    }
}
