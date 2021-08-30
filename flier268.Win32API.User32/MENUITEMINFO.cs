using System;

namespace flier268.Win32API
{
    public struct MENUITEMINFO
    {
        public int cbSize;

        public int fMask;

        public int fType;

        public int fState;

        public int wID;

        public IntPtr hSubMenu;

        public IntPtr hbmpChecked;

        public IntPtr hbmpUnchecked;

        public int dwItemData;

        public string dwTypeData;

        public int cch;
    }
}