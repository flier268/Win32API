using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        public short dmSpecVersion;

        public short dmDriverVersion;

        public short dmSize;

        public short dmDriverExtra;

        public int dmFields;

        public short dmOrientation;

        public short dmPaperSize;

        public short dmPaperLength;

        public short dmPaperWidth;

        public short dmScale;

        public short dmCopies;

        public short dmDefaultSource;

        public short dmPrintQuality;

        public short dmColor;

        public short dmDuplex;

        public short dmYResolution;

        public short dmTTOption;

        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        public short dmUnusedPadding;

        public int dmBitsPerPel;

        public int dmPelsWidth;

        public int dmPelsHeight;

        public int dmDisplayFlags;

        public int dmDisplayFrequency;
    }
}