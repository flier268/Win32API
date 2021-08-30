using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct CPINFO
    {
        public int MaxCharSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] DefaultChar;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] LeadByte;
    }
}