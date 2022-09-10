using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceProject.Models
{
    public class UserRole
    {
        [Key]
        public byte UserRoleID { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Role"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string UserRoleName { get; set; }
    }
}
