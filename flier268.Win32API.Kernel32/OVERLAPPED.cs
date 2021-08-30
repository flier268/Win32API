using System;

namespace flier268.Win32API
{
    public struct OVERLAPPED
    {
        public int Internal;

        public int InternalHigh;

        public int offset;

        public int OffsetHigh;

        public IntPtr hEvent;
    }
}