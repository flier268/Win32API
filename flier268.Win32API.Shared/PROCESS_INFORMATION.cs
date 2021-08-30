using System;

namespace flier268.Win32API
{
    public struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;

        public IntPtr hThread;

        public int dwProcessId;

        public int dwThreadId;
    }
}