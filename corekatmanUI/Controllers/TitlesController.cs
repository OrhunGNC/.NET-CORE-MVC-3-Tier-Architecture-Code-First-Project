using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class TitlesController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public TitlesController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = dbcontext.Title.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Titles titles)
        {
            dbcontext.Add(titles);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Title.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Titles title)
        {
            dbcontext.Update(title);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await dbcontext.Title.FindAsync(id);
            dbcontext.Remove(delete);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
