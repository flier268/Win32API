namespace flier268.Win32API
{
    public struct MCI_WAVE_OPEN_PARMS
    {
        public int dwCallback;

        public int wDeviceID;

        public string lpstrDeviceType;

        public string lpstrElementName;

        public string lpstrAlias;

        public int dwBufferSeconds;
    }
}