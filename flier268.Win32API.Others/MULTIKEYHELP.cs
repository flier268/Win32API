using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MULTIKEYHELP
    {
        public int mkSize;

        public byte mkKeylist;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 253)]
        public string szKeyphrase;
    }
}