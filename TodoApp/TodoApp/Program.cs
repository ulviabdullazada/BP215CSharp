namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
       {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/bdu", () => new
            //{
            //    name = "BP215",
            //    lesson = "MVC"
            //});
            app.MapControllerRoute("default", "{controller=Todo}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
