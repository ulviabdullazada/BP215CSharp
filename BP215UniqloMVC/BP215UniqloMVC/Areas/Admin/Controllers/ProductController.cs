using BP215UniqloMVC.DataAccess;
using BP215UniqloMVC.Extensions;
using BP215UniqloMVC.Models;
using BP215UniqloMVC.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace BP215UniqloMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IWebHostEnvironment _env, UniqloDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {

            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateVM vm)
        {
            if (vm.CoverFile != null)
            {
                if (!vm.CoverFile.IsValidType("image"))
                    ModelState.AddModelError("CoverFile","File type must be an image");
                if (!vm.CoverFile.IsValidSize(300))
                    ModelState.AddModelError("CoverFile","File type must be less than 300kb");
            }
            if (!ModelState.IsValid) return View();

            Product product = new Product
            {
                CategoryId = vm.CategoryId,
                CostPrice = vm.CostPrice,
                Description = vm.Description,
                Discount = vm.Discount,
                Name = vm.Name,
                Quantity = vm.Quantity,
                SellPrice = vm.SellPrice,
                CoverImage = await vm.CoverFile!.UploadAsync(_env.WebRootPath, "imgs", "products")
            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
