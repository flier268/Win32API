using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct DDEDATA
    {
        public short unused;

        public short fresponse;

        public short fRelease;

        public short Reserved;

        public short fAckReq;

        public short cfFormat;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte Value;
    }
}