using eCommerceProject.Data;
using eCommerceProject.Models;
using eCommerceProject.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eCommerceProject.Controllers
{
    [Authorize(Roles = "Admin,ShopOwner")]
    public class HomeController : Controller
    {
        private readonly eCommerceProjectDbContext _context;

        public HomeController(eCommerceProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel x = new HomeViewModel();
            x.ProductList = await _context.Products.ToListAsync();
            x.CategoryList = await _context.Categories.ToListAsync();
            x.BrandList = await _context.Brands.ToListAsync();
            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}