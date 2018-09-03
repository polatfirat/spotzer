using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace SpotzerLogging
{
    public class Logger : ILogger
    {
        public void ErrorLog(ILog log, string errorMessage, Exception exception)
        {
            log.Error(errorMessage, exception);
        }

        public void RequestLog(ILog log, string logMessage)
        {
            log.Info("RequestLog : " + logMessage);
        }

        public void ResponseLog(ILog log, string logMessage)
        {
            log.Info("ResponseLog : " + logMessage);
        }

        public void ValidationErrorLog(ILog log, string logMessage)
        {
            log.Info("ResponseLog : " + logMessage);
        }

        public ILog LoggerInitializer(Type declaringType)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            return log;
        }
    }
}
