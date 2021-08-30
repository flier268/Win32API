namespace flier268.Win32API
{
    public struct MOUSE_EVENT_RECORD
    {
        public COORD dwMousePosition;

        public int dwButtonState;

        public int dwControlKeyState;

        public int dwEventFlags;
    }
}