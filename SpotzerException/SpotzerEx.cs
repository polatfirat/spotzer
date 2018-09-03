using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerException
{
    public class SpotzerEx : Exception
    {
        public SpotzerEx(string message,Exception exception):base(message,exception)
        {

        }
    }

    public class SpotzerOrderCheckError
    {
        public string CheckError { get; set; }
    }

    public class SpotzerOrderApplyError
    {
        public string ApplyError { get; set; }
    }

    public class SpotzerServiceError
    {
        public string ServiceError { get; set; }
    }
}
