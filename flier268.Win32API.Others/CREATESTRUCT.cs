using System;

namespace flier268.Win32API
{
    public struct CREATESTRUCT
    {
        public int lpCreateParams;

        public IntPtr hInstance;

        public IntPtr hMenu;

        public IntPtr hwndParent;

        public int cy;

        public int cx;

        public int y;

        public int x;

        public int style;

        public string lpszName;

        public string lpszClass;

        public int ExStyle;
    }
}