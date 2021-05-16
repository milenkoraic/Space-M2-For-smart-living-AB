using System;

namespace FactoryManager.AppService.SystemInspection
{
    public class OperatingSystemHelper : IOperatingSystemHelper
    {
        public bool IsWindows7
        {
            get
            {
                return (Environment.OSVersion.Version.Major == 6 &
                    Environment.OSVersion.Version.Minor == 1);
            }
        }
    }
}