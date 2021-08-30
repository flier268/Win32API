using System;

namespace flier268.Win32API
{
    public struct MONHSZSTRUCT
    {
        public int cb;

        public int fsAction;

        public int dwTime;

        public IntPtr hsz;

        public IntPtr htask;

        public byte str;
    }
}