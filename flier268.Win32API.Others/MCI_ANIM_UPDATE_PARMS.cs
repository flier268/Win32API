using System;

namespace flier268.Win32API
{
    public struct MCI_ANIM_UPDATE_PARMS
    {
        public int dwCallback;

        public RECT rc;

        public IntPtr hdc;
    }
}