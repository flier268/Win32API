using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct EXTLOGPEN
    {
        public int elpPenStyle;

        public int elpWidth;

        public int elpBrushStyle;

        public int elpColor;

        public int elpHatch;

        public int elpNumEntries;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public int elpStyleEntry;
    }
}