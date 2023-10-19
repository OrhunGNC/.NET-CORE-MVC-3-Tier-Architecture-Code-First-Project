using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class KidController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public KidController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = dbcontext.Kids.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(Kid kid)
        {
            dbcontext.Add(kid);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Kids.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Kid kid)
        {
            dbcontext.Update(kid);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var result = await dbcontext.Kids.FindAsync(id);
            dbcontext.Remove(result);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
