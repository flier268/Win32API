using System;

namespace flier268.Win32API
{
    public struct MCI_BREAK_PARMS
    {
        public int dwCallback;

        public int nVirtKey;

        public IntPtr hwndBreak;
    }
}