using System;

namespace flier268.Win32API
{
    public struct CWPSTRUCT
    {
        public int lParam;

        public int wParam;

        public int message;

        public IntPtr hwnd;
    }
}