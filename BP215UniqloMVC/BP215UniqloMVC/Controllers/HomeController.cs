using BP215UniqloMVC.DataAccess;
using BP215UniqloMVC.Models;
using BP215UniqloMVC.ViewModels.Common;
using BP215UniqloMVC.ViewModels.Product;
using BP215UniqloMVC.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BP215UniqloMVC.Controllers
{
    public class HomeController(UniqloDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            HomeVM vm = new();
            vm.Sliders = await _context.Sliders
                .Where(x => !x.IsDeleted)
                .Select(x => new SliderItemVM
                {
                    ImageUrl = x.ImageUrl,
                    Link = x.Link,
                    Subtitle = x.Subtitle,
                    Title = x.Title
                }).ToListAsync();
            vm.Products = await _context.Products
                .Where(x => !x.IsDeleted)
                .Select(x => new ProductItemVM
                {
                    Discount = x.Discount,
                    Id = x.Id,
                    ImageUrl = x.CoverImage,
                    IsInStock = x.Quantity > 0,
                    Name = x.Name,
                    Price = x.SellPrice
                }).ToListAsync();
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
