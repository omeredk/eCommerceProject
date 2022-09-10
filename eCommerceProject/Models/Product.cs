using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eCommerceProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Product Name"), StringLength(25, MinimumLength = 2, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Price"), DataType(DataType.Currency), Column(TypeName = "decimal(6, 2)")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Description"), StringLength(400, MinimumLength = 2, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage ="{0} can't be empty"), Display(Name = "Barcode"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string ProductBarcode { get; set; }

        //public string? Picture { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }

        //NAV
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
