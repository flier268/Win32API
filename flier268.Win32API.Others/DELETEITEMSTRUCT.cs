using System;

namespace flier268.Win32API
{
    public struct DELETEITEMSTRUCT
    {
        public int CtlType;

        public int CtlID;

        public int itemID;

        public IntPtr hwndItem;

        public int itemData;
    }
}