using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct SMPTE
    {
        public byte hour;

        public byte min;

        public byte sec;

        public byte frame;

        public byte fps;

        public byte dummy;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte pad;
    }
}