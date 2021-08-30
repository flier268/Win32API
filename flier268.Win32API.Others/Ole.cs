using System;
using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public abstract class Ole
    {
        [DllImport("ole32")]
        public static extern int OleInitialize(IntPtr vbNullString);

        [DllImport("ole32")]
        public static extern void CoTaskMemFree(IntPtr hMem);

        [DllImport("ole32")]
        public static extern void OleUninitialize();
    }
}