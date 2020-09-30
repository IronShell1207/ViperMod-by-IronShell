// Decompiled with JetBrains decompiler
// Type: ViPER4WindowsBin.Utils.Win32GDI.GDIMutex
// Assembly: ViPER4WindowsCtrlPanel, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 0F74DDF5-B87A-4143-887F-423FAC499650
// Assembly location: C:\Program Files\ViPER4Windows\ViPER4WindowsCtrlPanel.exe

using System.Threading;

namespace ViPER4WindowsBin.Utils.Win32GDI
{
    internal class GDIMutex
    {
        private readonly Mutex MutexLock = new Mutex();

        public GDIMutex(bool Locking)
        {
            if (!Locking)
            {
                return;
            }

            MutexLock.WaitOne();
        }

        public void WaitLock()
        {
            MutexLock.WaitOne();
        }

        public void Unlock()
        {
            MutexLock.ReleaseMutex();
        }
    }
}
