using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct EXCEPTION_RECORD
    {
        public int ExceptionCode;

        public int ExceptionFlags;

        public int pExceptionRecord;

        public int ExceptionAddress;

        public int NumberParameters;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public int[] ExceptionInformation;
    }
}