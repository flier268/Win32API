using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct WAVEOUTCAPS
    {
        public short wMid;

        public short wPid;

        public int vDriverVersion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        public int dwFormats;

        public short wChannels;

        public int dwSupport;
    }
}