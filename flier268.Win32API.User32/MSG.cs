using System;

namespace flier268.Win32API
{
    public struct MSG
    {
        public IntPtr hwnd;

        public int message;

        public int wParam;

        public int lParam;

        public int time;

        public POINT pt;
    }
}