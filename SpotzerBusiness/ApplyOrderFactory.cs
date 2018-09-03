using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerBusiness
{
    public class ApplyOrderFactory : IApplyOrderFactory
    {
        public IApplyOrder ApplyOrder(string partnerType)
        {
            switch (partnerType)
            {
                case "A":
                    return new PartnerA();
                case "B":
                    return new PartnerB();
                case "C":
                    return new PartnerC();
                case "D":
                    return new PartnerD();
                default:
                    throw new SpotzerException.SpotzerEx("Please check partner", new Exception("Undefined partner"));
            }
        }
    }
}
