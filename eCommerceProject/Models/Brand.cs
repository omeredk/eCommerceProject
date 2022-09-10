using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceProject.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Brand"), StringLength(25, MinimumLength = 2, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string BrandName { get; set; }

    }
}
