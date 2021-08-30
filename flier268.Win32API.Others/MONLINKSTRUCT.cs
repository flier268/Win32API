using System;

namespace flier268.Win32API
{
    public struct MONLINKSTRUCT
    {
        public int cb;

        public int dwTime;

        public IntPtr htask;

        public int fEstablished;

        public int fNoData;

        public IntPtr hszSvc;

        public IntPtr hszTopic;

        public IntPtr hszItem;

        public int wFmt;

        public int fServer;

        public IntPtr hConvServer;

        public IntPtr hConvClient;
    }
}