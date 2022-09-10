using eCommerceProject.Models;

namespace eCommerceProject.ViewModel
{
    public class CategoryDetailViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Product> CategoryProductList { get; set; }
        public IEnumerable<Brand> CategoryBrandList { get; set; }
        public int CurrentPage { get; set; }
        public int TotalProductNumber { get; set; }
        public int LastPageNumber { get; set; }
        public int RecordsPerPage { get; set; }
    }
}
