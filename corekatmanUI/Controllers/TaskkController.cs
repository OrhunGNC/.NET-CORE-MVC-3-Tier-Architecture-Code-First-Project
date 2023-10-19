using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class TaskkController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public TaskkController(ApplicationDbContext dbcontext)
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
        public async Task<IActionResult> Create(Taskks taskk)
        {
            dbcontext.Add(taskk);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Taskkss.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Taskks taskk)
        {
            dbcontext.Update(taskk);
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
