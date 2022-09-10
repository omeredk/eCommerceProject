using eCommerceProject.Data;
using eCommerceProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceProject.Controllers
{
	public class CategoryDetailViewModelController : Controller
	{
		private readonly eCommerceProjectDbContext _context;
        public CategoryDetailViewModelController(eCommerceProjectDbContext context)
		{
            _context = context;
        }

        //GET:Category
		public async Task<IActionResult> Index(int cp=1)
		{
            CategoryDetailViewModel x = new CategoryDetailViewModel();
            x.RecordsPerPage = 6;
            x.CategoryList = await _context.Categories.ToListAsync();
            x.CategoryBrandList = await _context.Brands.ToListAsync();
            x.CategoryProductList = await _context.Products.OrderByDescending(a=>a.ProductID).Skip((cp - 1) * x.RecordsPerPage).Take(x.RecordsPerPage)
                .ToListAsync();

            x.CurrentPage = cp;
            x.TotalProductNumber = await _context.Products.CountAsync();
            x.LastPageNumber = ((x.TotalProductNumber - 1) / x.RecordsPerPage) + 1;

            return View(x);
		}

        public async Task<IActionResult> Details(int? id)
        {
            CategoryDetailViewModel x = new CategoryDetailViewModel();
            x.CategoryList = await _context.Categories.ToListAsync();
            x.CategoryBrandList = await _context.Brands.ToListAsync();
            x.CategoryProductList = await _context.Products.ToListAsync();

            var categoryProducts = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Where(p => p.Category.CategoryID == id)
                .ToListAsync();

            return View(categoryProducts);
        }
    }
}
