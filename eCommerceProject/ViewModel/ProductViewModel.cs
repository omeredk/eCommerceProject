using eCommerceProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eCommerceProject.ViewModel
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
