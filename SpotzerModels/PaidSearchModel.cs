using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerModels
{
    public class PaidSearchModel
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public AdWordCampaign AdWordCampaign { get; set; }
    }

    public class AdWordCampaign
    {
        public string CampaignName { get; set; }
        public string CampaignAddressLine1 { get; set; }
        public string CampaignPostCode { get; set; }
        public string CampaignRadius { get; set; }
        public string LeadPhoneNumber { get; set; }
        public string SMSPhoneNumber { get; set; }
        public string UniqueSellingPoint1 { get; set; }
        public string UniqueSellingPoint2 { get; set; }
        public string UniqueSellingPoint3 { get; set; }
        public string Offer { get; set; }
        public string DestinationURL { get; set; }

    }
}
