// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.Utils.FolderExplorer
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.Collections.Generic;
using System.IO;

namespace ViPER4WindowsBin.Utils
{
    internal class FolderExplorer
    {
        private void InternalListFiles(string szFolder, List<string> lsResult)
        {
            try
            {
                lsResult.AddRange(Directory.GetFiles(szFolder));
                foreach (string directory in Directory.GetDirectories(szFolder))
                {
                    InternalListFiles(directory, lsResult);
                }
            }
            catch
            {
            }
        }

        public string[] ListFiles(string szFolder)
        {
            if (szFolder == null)
            {
                return new string[0];
            }

            if (!Directory.Exists(szFolder))
            {
                return new string[0];
            }

            List<string> lsResult = new List<string>();
            InternalListFiles(szFolder, lsResult);
            return lsResult.ToArray();
        }
    }
}
