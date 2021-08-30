using System;

namespace flier268.Win32API
{
    public struct MOUSEHOOKSTRUCT
    {
        public POINT pt;

        public IntPtr hwnd;

        public int wHitTestCode;

        public int dwExtraInfo;
    }
}