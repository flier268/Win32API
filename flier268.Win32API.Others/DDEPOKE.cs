using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct DDEPOKE
    {
        public short unused;

        public short fRelease;

        public short fReserved;

        public short cfFormat;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte Value;
    }
}