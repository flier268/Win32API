using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct WIN32_FIND_DATA
    {
        public int dwFileAttributes;

        public FILETIME ftCreationTime;

        public FILETIME ftLastAccessTime;

        public FILETIME ftLastWriteTime;

        public int nFileSizeHigh;

        public int nFileSizeLow;

        public int dwReserved0;

        public int dwReserved1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternate;
    }
}