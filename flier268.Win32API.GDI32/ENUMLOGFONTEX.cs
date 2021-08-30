using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct ENUMLOGFONTEX
    {
        public LOGFONT elfLogFont;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] elfFullName;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] elfStyle;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] elfScript;
    }
}