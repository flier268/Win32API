namespace flier268.Win32API
{
    public struct KEY_EVENT_RECORD
    {
        public int bKeyDown;

        public short wRepeatCount;

        public short wVirtualKeyCode;

        public short wVirtualScanCode;

        public byte uChar;

        public int dwControlKeyState;
    }
}