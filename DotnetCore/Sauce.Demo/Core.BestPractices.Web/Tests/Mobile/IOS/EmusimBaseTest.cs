﻿namespace Core.BestPractices.Web.Tests.Mobile.IOS
{
    public class EmusimBaseTest : AllTestsBase
    {
        public string DeviceName;
        public string PlatformVersion;

        public EmusimBaseTest(string deviceName, string platformVersion)
        {
            DeviceName = deviceName;
            PlatformVersion = platformVersion;
        }
    }
}