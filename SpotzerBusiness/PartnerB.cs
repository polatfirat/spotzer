using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotzerModel;
using SpotzerException;

namespace SpotzerBusiness
{
    class PartnerB : IApplyOrder
    {
        public object ApplyOrder(PartnerOrderModel partnerOrderModel)
        {
            //Some database / logical processes and goes into repository.
            return null;
        }

        public SpotzerOrderCheckError CheckOrder(PartnerOrderModel partnerOrderModel)
        {
            //There is no additional request.
            return null;

        }
    }
}
