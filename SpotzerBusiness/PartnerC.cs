using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotzerModel;
using SpotzerException;

namespace SpotzerBusiness
{
    class PartnerC : IApplyOrder
    {
        public object ApplyOrder(PartnerOrderModel partnerOrderModel)
        {
            //Some database / logical processes and goes into repository.
            return null;
        }

        public SpotzerOrderCheckError CheckOrder(PartnerOrderModel partnerOrderModel)
        {
            if (partnerOrderModel.ExposureID==0)
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Exposure id must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.UDAC))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "UDAC must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.RelatedOrder))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Related order must be filled." };
            }
            else
            {
                return null;
            }
        }
    }
}
