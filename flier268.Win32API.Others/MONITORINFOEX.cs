using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MONITORINFOEX
    {
        public uint cbSize;

        public RECT rcMonitor;

        public RECT rcWork;

        public uint dwFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDevice;
    }
}