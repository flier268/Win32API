using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct TOKEN_GROUPS
    {
        public int GroupCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public SID_AND_ATTRIBUTES[] Groups;
    }
}