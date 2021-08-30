using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct METARECORD
    {
        public int rdSize;

        public short rdFunction;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short rdParm;
    }
}