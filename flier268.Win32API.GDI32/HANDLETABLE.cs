using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct HANDLETABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public int objectHandle;
    }
}