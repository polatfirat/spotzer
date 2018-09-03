using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotzerModel
{
    public class WebsiteModel
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
    }

    public class WebsiteDetails
    {
        [Required]
        [StringLength(245, ErrorMessage = "TemplateId input must be filled up to 245 characters for website order")]
        public string TemplateId { get; set; }

        [Required]
        [StringLength(245, ErrorMessage = "WebsiteBusinessName input must be filled up to 245 characters for website order")]
        public string WebsiteBusinessName { get; set; }

        [Required]
        [StringLength(246, ErrorMessage = "WebsiteAddressLine1 input must be filled up to 246 characters for website order")]
        public string WebsiteAddressLine1 { get; set; }

        [Required]
        [StringLength(247, ErrorMessage = "WebsiteAddressLine2 input must be filled up to 247 characters for website order")]
        public string WebsiteAddressLine2 { get; set; }

        [Required]
        [StringLength(248, ErrorMessage = "WebsiteCity input must be filled up to 248 characters for website order")]
        public string WebsiteCity { get; set; }

        [Required]
        [StringLength(249, ErrorMessage = "WebsiteState input must be filled up to 249 characters for website order")]
        public string WebsiteState { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "WebsitePostCode input must be filled up to 250 characters for website order")]
        public string WebsitePostCode { get; set; }

        [Required]
        [StringLength(257, ErrorMessage = "WebsitePostCode input must be filled up to 257 characters for website order")]
        public string WebsitePhone { get; set; }

        [Required]
        [StringLength(258, ErrorMessage = "WebsiteEmail input must be filled up to 258 characters for website order")]
        public string WebsiteEmail { get; set; }

        [Required]
        [StringLength(259, ErrorMessage = "WebsiteMobile input must be filled up to 259 characters for website order")]
        public string WebsiteMobile { get; set; }
    }
}
