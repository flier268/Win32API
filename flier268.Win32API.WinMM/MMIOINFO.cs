using System;
using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MMIOINFO
    {
        public int dwFlags;

        public int fccIOProc;

        public int pIOProc;

        public int wErrorRet;

        public IntPtr htask;

        public int cchBuffer;

        public string pchBuffer;

        public string pchNext;

        public string pchEndRead;

        public string pchEndWrite;

        public int lBufOffset;

        public int lDiskOffset;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int adwInfo;

        public int dwReserved1;

        public int dwReserved2;

        public IntPtr hmmio;
    }
}