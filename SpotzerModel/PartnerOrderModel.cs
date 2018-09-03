using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerModel
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

        [StringLength(30, ErrorMessage = "Contact first name input must be filled up to 30 characters")]
        public string ContactFirstName { get; set; }

        [StringLength(30, ErrorMessage = "Contact last name input must be filled up to 30 characters")]
        public string ContactLastName { get; set; }

        [StringLength(30, ErrorMessage = "Contact title input must be filled up to 30 characters")]
        public string ContactTitle { get; set; }

        [StringLength(30, ErrorMessage = "Contact phone input must be filled up to 30 characters")]
        public string ContactPhone { get; set; }

        [StringLength(30, ErrorMessage = "Contact mobile input must be filled up to 30 characters")]
        public string ContactMobile { get; set; }

        [StringLength(30, ErrorMessage = "Contact email input must be filled up to 30 characters")]
        public string ContactEmail { get; set; }

        public int ExposureID { get; set; }

        [StringLength(30, ErrorMessage = "UDAC input must be filled up to 30 characters")]
        public string UDAC { get; set; }

        [StringLength(30, ErrorMessage = "RelatedOrder input must be filled up to 30 characters")]
        public string RelatedOrder { get; set; }

        public List<LineItem> LineItems { get; set; }
    }

    public class LineItem
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(17, ErrorMessage = "Product ID input must be filled up to 17 characters for website order")]
        public string ProductID { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "Product ID input must be filled up to 18 characters for website order")]
        public string ProductType { get; set; }

        [Required]
        [StringLength(53, ErrorMessage = "Notes input must be filled up to 53 characters for website order")]
        public string Notes { get; set; }

        [Required]
        [StringLength(245, ErrorMessage = "Category input must be filled up to 245 characters for website order")]
        public string Category { get; set; }

        public WebsiteDetails WebsiteDetails { get; set; }

        public AdWordCampaign AdWordCampaign { get; set; }
    }
}