using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceProject.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderDetailCount { get; set; }
        public double Price { get; set; }
        public int OrderProductID { get; set; }
        public int ProductID { get; set; }

        //NAV
        public OrderProduct OrderProduct { get; set; }
        public Product Product { get; set; }
    }
}
