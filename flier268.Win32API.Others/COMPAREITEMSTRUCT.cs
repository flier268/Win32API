using System;

namespace flier268.Win32API
{
    public struct COMPAREITEMSTRUCT
    {
        public int CtlType;

        public int CtlID;

        public IntPtr hwndItem;

        public int itemID1;

        public int itemData1;

        public int itemID2;

        public int itemData2;
    }
}