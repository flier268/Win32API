namespace flier268.Win32API
{
    public struct BY_HANDLE_FILE_INFORMATION
    {
        public int dwFileAttributes;

        public FILETIME ftCreationTime;

        public FILETIME ftLastAccessTime;

        public FILETIME ftLastWriteTime;

        public int dwVolumeSerialNumber;

        public int nFileSizeHigh;

        public int nFileSizeLow;

        public int nNumberOfLinks;

        public int nFileIndexHigh;

        public int nFileIndexLow;
    }
}