namespace flier268.Win32API
{
    public struct MONITORINFO
    {
        public uint cbSize;

        public RECT rcMonitor;

        public RECT rcWork;

        public uint dwFlags;
    }
}