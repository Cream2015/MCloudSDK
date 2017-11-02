using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCloudSDK.QCloud.Cos.SDK.Common
{
    public static class Extension
    {
        public static long ToUnixTime(this DateTime nowTime)
        {
            //DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            return (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero);
        }
    }
}
