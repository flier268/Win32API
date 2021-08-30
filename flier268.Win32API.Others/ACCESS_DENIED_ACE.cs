namespace flier268.Win32API
{
    public struct ACCESS_DENIED_ACE
    {
        public ACE_HEADER Header;

        public int Mask;

        public int SidStart;
    }
}