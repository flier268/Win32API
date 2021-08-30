using System;

namespace flier268.Win32API
{
    public struct EVENTMSG
    {
        public int message;

        public int paramL;

        public int paramH;

        public int time;

        public IntPtr hwnd;
    }
}