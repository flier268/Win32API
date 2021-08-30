using System;

namespace flier268.Win32API
{
    public struct MONERRSTRUCT
    {
        public int cb;

        public int wLastError;

        public int dwTime;

        public IntPtr htask;
    }
}