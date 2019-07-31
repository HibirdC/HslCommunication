using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace HslCommunication.ModBus
{
    class ModbusLog
    {
        public static log4net.ILog logInfo = null;

        public static void WriteInfoLog(string info)
        {
            if(logInfo == null)
            {
                return;
            }

            if (logInfo.IsInfoEnabled)
            {
                logInfo.Info(info);
            }
        }
    }
}
