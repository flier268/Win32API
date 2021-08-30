using System;

namespace flier268.Win32API
{
    public struct BROWSEINFO
    {
        public IntPtr hwndOwner;

        public int pIDLRoot;

        public int pszDisplayName;

        public int lpszTitle;

        public int ulFlags;

        public int lpfnCallback;

        public int lParam;

        public int iImage;
    }
}