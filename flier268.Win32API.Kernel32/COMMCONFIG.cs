namespace flier268.Win32API
{
    public struct COMMCONFIG
    {
        public int dwSize;

        public short wVersion;

        public short wReserved;

        public DCB dcbx;

        public int dwProviderSubType;

        public int dwProviderOffset;

        public int dwProviderSize;

        public byte wcProviderData;
    }
}