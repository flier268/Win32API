using System;

namespace flier268.Win32API
{
    public struct MCI_OVLY_WINDOW_PARMS
    {
        public int dwCallback;

        public IntPtr hwnd;

        public int nCmdShow;

        public string lpstrText;
    }
}