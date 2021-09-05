using System;
using System.Runtime.InteropServices;
using System.Text;

namespace flier268.Win32API
{
    public abstract class Mpr
    {
        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetAddConnection(string lpszNetPath, string lpszPassword, string lpszLocalName);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetAddConnection2(ref NETRESOURCE lpNetResource, string lpPassword, string lpUserName, int dwFlags);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetCancelConnection(string lpszName, int bForce);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetCancelConnection2(string lpName, int dwFlags, int fForce);

        [DllImport("mpr", CharSet = CharSet.Auto)]
        public static extern int WNetCloseEnum(IntPtr hEnum);

        [DllImport("mpr", CharSet = CharSet.Auto)]
        public static extern int WNetConnectionDialog(IntPtr hwnd, int dwType);

        [DllImport("mpr", CharSet = CharSet.Auto)]
        public static extern int WNetDisconnectDialog(IntPtr hwnd, int dwType);

        [DllImport("mpr", CharSet = CharSet.Auto)]
        public static extern int WNetEnumResource(IntPtr hEnum, ref int lpcCount, ref NETRESOURCE lpBuffer, ref int lpBufferSize);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetGetConnection(string lpszLocalName, string lpszRemoteName, int cbRemoteName);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetGetLastError(int lpError, StringBuilder lpErrorBuf, int nErrorBufSize, string lpNameBuf, int nNameBufSize);

        [DllImport("mpr", CharSet = CharSet.Unicode)]
        public static extern int WNetGetUser(string lpName, StringBuilder lpUserName, ref int lpnLength);

        [DllImport("mpr", CharSet = CharSet.Auto)]
        public static extern int WNetOpenEnum(int dwScope, int dwType, int dwUsage, ref NETRESOURCE lpNetResource, ref int lphEnum);
    }
}