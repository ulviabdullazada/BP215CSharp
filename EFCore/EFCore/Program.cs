using EFCore.Contexts;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = [];
            //using (AppDbContext sql = new AppDbContext())
            //{
            //    var query = sql.Todos.Where(x=> x.Deadline.Day == DateTime.Now.Day).AsQueryable();
            //    Console.WriteLine(query.ToQueryString());
            //    todos = query.ToList();
            //    //Console.WriteLine(todos.Any(x=> x.Id == 1));
            //}
            //Console.WriteLine("--------------------------------------");
            //if (todos.Any())
            //{
            //    todos.ForEach(x => Console.WriteLine(x.Title));
            //}
            //else
            //{
            //    Console.WriteLine("Bu gun tasking yoxdur. Get yat");
            //}

            //using (AppDbContext context = new())
            //{
            //    var data = context.Todos.FirstOrDefault(x => x.Title.StartsWith("Title"));
            //    //var data = context.Todos.Find(1);
            //    if (data is not null)
            //    {
            //        context.Todos.Remove(data);
            //        context.SaveChanges();
            //    }
            //    context.SaveChanges();
            //}

            using (AppDbContext context = new())
            {
                var data = context.Todos.FirstOrDefault(x => x.Title == "Title 8");
                if (data != null) 
                {
                    data.Description = "BDU";
                    context.SaveChanges();
                }
            }
            //for (int i = 1; i < 20; i++)
            //{
            //    todos.Add(new Todo 
            //    {
            //        Description = "Desc " + i,
            //        Title = "Title " + i,
            //        Deadline = DateTime.Now.AddHours(i),
            //    });
            //}
            //using (AppDbContext sql = new AppDbContext())
            //{
            //    sql.Todos.AddRange(todos);
            //    //sql.Todos.Add(new Todo
            //    //{
            //    //    Title = "Task 2",
            //    //    Deadline = DateTime.Now.AddHours(4),
            //    //});
            //    sql.SaveChanges();
            //    Console.WriteLine("Successfully created!");
            //}
        }
    }
}
