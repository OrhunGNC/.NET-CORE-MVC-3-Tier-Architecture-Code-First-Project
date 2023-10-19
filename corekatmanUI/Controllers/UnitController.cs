using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class UnitController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public UnitController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = dbcontext.Unit.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Units unit)
        {
            dbcontext.Add(unit);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Unit.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Units unit)
        {
            dbcontext.Update(unit);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int id)
        {
            var result = await dbcontext.Unit.FindAsync(id);
            dbcontext.Remove(result);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
