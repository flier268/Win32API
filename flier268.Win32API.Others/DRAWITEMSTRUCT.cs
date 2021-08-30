using System;

namespace flier268.Win32API
{
    public struct DRAWITEMSTRUCT
    {
        public int CtlType;

        public int CtlID;

        public int itemID;

        public int itemAction;

        public int itemState;

        public IntPtr hwndItem;

        public IntPtr hdc;

        public RECT rcItem;

        public int itemData;
    }
}