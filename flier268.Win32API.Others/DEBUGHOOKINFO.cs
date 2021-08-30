using System;

namespace flier268.Win32API
{
    public struct DEBUGHOOKINFO
    {
        public IntPtr hModuleHook;

        public int Reserved;

        public int lParam;

        public int wParam;

        public int code;
    }
}