namespace flier268.Win32API
{
    public struct QUERY_SERVICE_CONFIG
    {
        public int dwServiceType;

        public int dwStartType;

        public int dwErrorControl;

        public string lpBinaryPathName;

        public string lpLoadOrderGroup;

        public int dwTagId;

        public string lpDependencies;

        public string lpServiceStartName;

        public string lpDisplayName;
    }
}