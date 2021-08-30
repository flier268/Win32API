namespace flier268.Win32API
{
    public struct QUERY_SERVICE_LOCK_STATUS
    {
        public int fIsLocked;

        public string lpLockOwner;

        public int dwLockDuration;
    }
}