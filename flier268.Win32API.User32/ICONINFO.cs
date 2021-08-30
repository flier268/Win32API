using System;

namespace flier268.Win32API
{
    public struct ICONINFO
    {
        public int fIcon;

        public int xHotspot;

        public int yHotspot;

        public IntPtr hbmMask;

        public IntPtr hbmColor;
    }
}