using eCommerceProject.Models;

namespace eCommerceProject.ViewModel
{
    public class OrderViewModel
    {
        public OrderProduct OrderProduct { get; set; }
        public IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}
