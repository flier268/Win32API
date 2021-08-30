using System;

namespace flier268.Win32API
{
    public struct LOAD_DLL_DEBUG_INFO
    {
        public IntPtr hFile;

        public int lpBaseOfDll;

        public int dwDebugInfoFileOffset;

        public int nDebugInfoSize;

        public int lpImageName;

        public short fUnicode;
    }
}