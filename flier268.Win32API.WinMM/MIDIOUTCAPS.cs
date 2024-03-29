using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public struct MIDIOUTCAPS
    {
        public short wMid;

        public short wPid;

        public int vDriverVersion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        public short wTechnology;

        public short wVoices;

        public short wNotes;

        public short wChannelMask;

        public int dwSupport;
    }
}