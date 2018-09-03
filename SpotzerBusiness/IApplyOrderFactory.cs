using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerBusiness
{
    interface IApplyOrderFactory
    {
        IApplyOrder ApplyOrder (string partnerType);
    }
}
