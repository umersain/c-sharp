﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PubnubApi
{
    internal class PNPlatform
    {
        public static void Print(PNConfiguration config, IPubnubLog log)
        {
#if NETSTANDARD10
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD10", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETSTANDARD11
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD11", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETSTANDARD12
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD12", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETSTANDARD13
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD13", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETSTANDARD14
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD14", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETSTANDARD20
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETSTANDARD20", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif UAP
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = UAP", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NETFX_CORE
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NETFX_CORE", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif WINDOWS_UWP
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = WINDOWS_UWP", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NET35
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NET35", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NET40
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NET40", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NET45
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NET45", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#elif NET461
            LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = NET461", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#else
                        LoggingMethod.WriteToLog(log, string.Format("DateTime {0} PLATFORM = UNKNOWN", DateTime.Now.ToString(CultureInfo.InvariantCulture)), config.LogVerbosity);
#endif
        }

        public static string Get()
        {
            string result = "";
#if NETSTANDARD10
                        result = "NETSTD10";
#elif NETSTANDARD11
                        result = "NETSTD11";
#elif NETSTANDARD12
                        result = "NETSTD12";
#elif NETSTANDARD13
                        result = "NETSTD13";
#elif NETSTANDARD14
                        result = "NETSTD14";
#elif NETSTANDARD20
                        result = "NETSTD20";
#elif UAP
                        result = "UAP";
#elif NETFX_CORE
                        result = "NETFX_CORE";
#elif WINDOWS_UWP
                        result = "WINDOWS_UWP";
#elif NET35
                        result = "NET35";
#elif NET40
                        result = "NET40";
#elif NET45
                        result = "NET45";
#elif NET461
                        result = "NET461";
#else
                        result = "UNKNOWN";
#endif
            return result;
        }
    }
}
