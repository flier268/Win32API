using System;

namespace flier268.Win32API
{
    public struct CREATE_THREAD_DEBUG_INFO
    {
        public IntPtr hThread;

        public int lpThreadLocalBase;

        public int lpStartAddress;
    }
}