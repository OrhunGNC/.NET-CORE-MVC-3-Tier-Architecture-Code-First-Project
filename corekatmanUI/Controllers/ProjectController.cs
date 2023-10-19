using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class ProjectController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public ProjectController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = dbcontext.Projects.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            dbcontext.Add(project);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Projects.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Project project)
        {
            dbcontext.Update(project);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var result = await dbcontext.Projects.FindAsync(id);
            dbcontext.Remove(result);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
