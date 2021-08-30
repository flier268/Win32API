using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct TOKEN_PRIVILEGES
    {
        public int PrivilegeCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public LUID_AND_ATTRIBUTES[] Privileges;
    }
}