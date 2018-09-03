using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerLogging
{
    public interface ILogger
    {
        void RequestLog(ILog log, string logMessage);
        void ResponseLog(ILog log, string logMessage);
        void ErrorLog(ILog log, string errorMessage,Exception exception);
        void ValidationErrorLog(ILog log, string errorMessage);
    }
}
