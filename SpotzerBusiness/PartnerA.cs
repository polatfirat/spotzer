using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotzerModel;
using SpotzerException;

namespace SpotzerBusiness
{
    class PartnerA : IApplyOrder
    {
        public object ApplyOrder(PartnerOrderModel partnerOrderModel)
        {
            //Some database / logical processes and goes into repository.
            return null;
        }

        public SpotzerOrderCheckError CheckOrder(PartnerOrderModel partnerOrderModel)
        {
            if (String.IsNullOrEmpty(partnerOrderModel.ContactFirstName))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact first name must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.ContactLastName))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact last name must be filled." };
            }
            else if(String.IsNullOrEmpty(partnerOrderModel.ContactTitle))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact title must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.ContactPhone))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact phone must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.ContactMobile))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact mobile must be filled." };
            }
            else if (String.IsNullOrEmpty(partnerOrderModel.ContactEmail))
            {
                return new SpotzerException.SpotzerOrderCheckError { CheckError = "Contact email must be filled." };
            } 
            else
            {
                return null;
            }
        }
    }
}
