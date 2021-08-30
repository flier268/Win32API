namespace flier268.Win32API
{
    public struct CRITICAL_SECTION
    {
        public int pDebugInfo;

        public int LockCount;

        public int RecursionCount;

        public int pOwningThread;

        public int pLockSemaphore;

        public int Reserved;
    }
}