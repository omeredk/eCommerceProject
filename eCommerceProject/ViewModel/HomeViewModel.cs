using eCommerceProject.Models;

namespace eCommerceProject.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Product> ProductList { get; set; }
        public IEnumerable<Brand> BrandList { get; set; }
    }
}
