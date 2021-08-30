using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct SID_IDENTIFIER_AUTHORITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Value;
    }
}