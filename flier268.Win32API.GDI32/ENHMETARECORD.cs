using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct ENHMETARECORD
    {
        public int iType;

        public int nSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public int dParm;
    }
}