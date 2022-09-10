using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceProject.Models
{
    public class WebUser
    {
        [Key]
        public int WebUserID { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Fullname"), StringLength(40, MinimumLength = 6, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string WebUserFullName { get; set; }
        
        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "E-mail"), StringLength(52, MinimumLength = 9, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string WebUserEmail { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Password"), StringLength(20, MinimumLength = 8, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string WebUserPassword { get; set; }

        [Required(ErrorMessage = "{0} can't be empty"),NotMapped,Compare("WebUserPassword",ErrorMessage = "Password and Re-password did not match"), Display(Name = "Re-Password"), StringLength(20, MinimumLength = 8, ErrorMessage = "{0} should be in the range of {2}-{1} characters")]
        public string WebUserRePassword { get; set; }
        [Required(ErrorMessage = "{0} can't be empty"), Display(Name = "Role")]
        public byte UserRoleID { get; set; }
        //NAV
        public UserRole UserRole { get; set; }

    }
}
