using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MIDIEVENT
    {
        public int dwDeltaTime;

        public int dwStreamID;

        public int dwEvent;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public int dwParms;
    }
}