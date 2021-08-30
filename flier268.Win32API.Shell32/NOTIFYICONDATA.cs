using System;
using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct NOTIFYICONDATA
    {
        public int cbSize;

        public IntPtr hwnd;

        public int uID;

        public int uFlags;

        public int uCallbackMessage;

        public IntPtr hIcon;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szTip;
    }
}