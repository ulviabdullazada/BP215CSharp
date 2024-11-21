using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Hi(string name, int age)
        {
            //JsonResult json = new JsonResult(new
            //{
            //    name = name,
            //    age = age
            //});
            //ContentResult content = new ContentResult();
            //content.Content = "<h1>Salam</h1>";
            //content.ContentType = "text/html";
            //ViewResult view = new ViewResult();
            List<string> names = ["Mirmezahir","Kanan","Xagan","Emin","Xalid","Xandam"];
            //ViewData["name"] = "Emin";
            //ViewData["surname"] = "Mustafayev";
            ViewData["Students"] = names;
            return View();
        }
        public int Vay(int id)
        {
            return id;
        }
    }
}
