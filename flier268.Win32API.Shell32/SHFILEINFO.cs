using System;
using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct SHFILEINFO
    {
        public IntPtr hIcon;

        public int iIcon;

        public int dwAttributes;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public string szDisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }
}