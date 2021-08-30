using System;
using System.Runtime.InteropServices;

namespace flier268.Win32API
{
    public abstract class Version
    {
        [DllImport("version", CharSet = CharSet.Unicode)]
        public static extern int GetFileVersionInfo(string lptstrFilename, int dwHandle, int dwLen, IntPtr lpData);

        [DllImport("version", CharSet = CharSet.Unicode)]
        public static extern int GetFileVersionInfoSize(string lptstrFilename, ref int lpdwHandle);

        [DllImport("version", CharSet = CharSet.Unicode)]
        public static extern int VerFindFile(int uFlags, string szFileName, string szWinDir, string szAppDir, string szCurDir, ref int lpuCurDirLen, string szDestDir, ref int lpuDestDirLen);

        [DllImport("version", CharSet = CharSet.Unicode)]
        public static extern int VerInstallFile(int uFlags, string szSrcFileName, string szDestFileName, string szSrcDir, string szDestDir, string szCurDir, string szTmpFile, ref int lpuTmpFileLen);

        [DllImport("version", CharSet = CharSet.Unicode)]
        public static extern int VerQueryValue(IntPtr pBlock, string lpSubBlock, ref int lplpBuffer, ref int puLen);
    }
}