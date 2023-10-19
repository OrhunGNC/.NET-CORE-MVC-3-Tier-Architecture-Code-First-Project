using coreData.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class TaskController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public TaskController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.Taskkss.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Task task)
        {
            dbcontext.Add(task);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Taskkss.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Task task)
        {
            dbcontext.Update(task);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await dbcontext.Taskkss.FindAsync(id);
            dbcontext.Remove(delete);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
