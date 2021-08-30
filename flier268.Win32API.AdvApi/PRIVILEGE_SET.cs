using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct PRIVILEGE_SET
    {
        public int PrivilegeCount;

        public int Control;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public LUID_AND_ATTRIBUTES[] Privilege;
    }
}