using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerModels
{
    public class PartnerOrderModel
    {
        [Required]
        [StringLength(1,ErrorMessage = "Partner input must be filled up to 1 character")]
        public string Partner { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "Order ID input must be filled up to 7 characters")]
        public string OrderID { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Type of order input must be filled up to 8 characters")]
        public string TypeOfOrder { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Submitted by input must be filled up to 11 characters")]
        public string SubmittedBy { get; set; }

        [Required]
        [StringLength(28, ErrorMessage = "Submitted by input must be filled up to 28 characters")]
        public string CompanyID { get; set; }

        [Required]
        [StringLength(29, ErrorMessage = "Submitted by input must be filled up to 29 characters")]
        public string CompanyName { get; set; }
        public LineItems LineItems { get; set; }
    }

    public class LineItems
    {
        public WebsiteModel WebsiteOrderModel { get; set; }
        public PaidSearchModel PaidSearchModel { get; set; }
    }

    

    

   
}