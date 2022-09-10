using System.ComponentModel.DataAnnotations;

namespace eCommerceProject.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int WebUserID { get; set; }
        public decimal CartPrice { get; set; }
        public int CartCount { get; set; }
        public string ProductName { get; set; }
        //NAV
        public WebUser WebUser { get; set; }
        public Product Product { get; set; }
    }
}
