using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct FONTSIGNATURE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int fsUsb;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int fsCsb;
    }
}