using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct DDEUP
    {
        public short unused;

        public short fAck;

        public short fRelease;

        public short fReserved;

        public short fAckReq;

        public short cfFormat;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte rgb;
    }
}