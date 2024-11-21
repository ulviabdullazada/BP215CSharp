using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TodoApp.Contexts;
using TodoApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (Bp215efContext context = new())
            {
                var query = context.Todos.OrderBy(x => x.IdDone).ThenByDescending(x => x.Deadline).AsQueryable();
                Console.WriteLine(query.ToQueryString());
                return View(await query.ToListAsync());
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Todo data)
        {
            using (Bp215efContext context = new())
            {
                await context.Todos.AddAsync(data);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            Todo? data;
            using (Bp215efContext context = new())
            {
                data = await context.Todos.FindAsync(id);
                if (data is null) return NotFound();
                context.Todos.Remove(data);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Update(int? id)
        {
            if (!id.HasValue) return BadRequest();
            using (Bp215efContext context = new())
            {
                var data = await context.Todos.FindAsync(id);
                if (data is null) return NotFound();
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Todo data)
        {
            if (!id.HasValue) return BadRequest();
            using (Bp215efContext context = new())
            {
                var entity = await context.Todos.FindAsync(id);
                if (entity is null) return NotFound();
                entity.Title = data.Title;
                entity.Description = data.Description;
                entity.Deadline = data.Deadline;
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CompleteTask(int? id)
        {
            if (!id.HasValue) return BadRequest();
            using (Bp215efContext context = new())
            {
                var entity = await context.Todos.FindAsync(id);
                if (entity is null) return NotFound();
                entity.IdDone = true;
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
