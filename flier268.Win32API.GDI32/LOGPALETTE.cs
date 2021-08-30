using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct LOGPALETTE
    {
        public short palVersion;

        public short palNumEntries;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public PALETTEENTRY palPalEntry;
    }
}