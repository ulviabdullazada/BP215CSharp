using BP215UniqloMVC.DataAccess;
using BP215UniqloMVC.Models;
using BP215UniqloMVC.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BP215UniqloMVC.Controllers
{
    public class HomeController(UniqloDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var datas = await _context.Sliders
                .Where(x=> !x.IsDeleted)
                .Select(x => new SliderItemVM
                {
                    ImageUrl = x.ImageUrl,
                    Link = x.Link,
                    Subtitle = x.Subtitle,
                    Title = x.Title
                }).ToListAsync();
            return View(datas);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
