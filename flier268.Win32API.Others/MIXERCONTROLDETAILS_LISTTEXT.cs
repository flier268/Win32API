using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MIXERCONTROLDETAILS_LISTTEXT
    {
        public int dwParam1;

        public int dwParam2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;
    }
}