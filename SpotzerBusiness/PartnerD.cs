using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotzerModel;
using SpotzerException;

namespace SpotzerBusiness
{
    class PartnerD : IApplyOrder
    {
        public object ApplyOrder(PartnerOrderModel partnerOrderModel)
        {
            //Some database / logical processes and goes into repository.
            return null;
        }

        public SpotzerOrderCheckError CheckOrder(PartnerOrderModel partnerOrderModel)
        {
            //This partner can only get paid search orders
            foreach (var item in partnerOrderModel.LineItems)
            {
                if (item.WebsiteDetails!=null)
                {
                    return new SpotzerException.SpotzerOrderCheckError { CheckError = "This partner can apply only paid search orders." };
                }
            }

            return null;
        }
    }
}
