namespace flier268.Win32API
{
    public struct MIXERLINECONTROLS
    {
        public int cbStruct;

        public int dwLineID;

        public int dwControl;

        public int cControls;

        public int cbmxctrl;

        public MIXERCONTROL pamxctrl;
    }
}