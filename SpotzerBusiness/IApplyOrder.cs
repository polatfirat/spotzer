using SpotzerException;
using SpotzerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerBusiness
{
    public interface IApplyOrder
    {
        SpotzerOrderCheckError CheckOrder(PartnerOrderModel partnerOrderModel);
        object ApplyOrder(PartnerOrderModel partnerOrderModel);
    }
}
