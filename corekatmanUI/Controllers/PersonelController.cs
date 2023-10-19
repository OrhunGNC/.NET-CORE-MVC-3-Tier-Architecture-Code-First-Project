using coreData.Data;
using coreModel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace corekatmanUI.Controllers
{
    public class PersonelController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public PersonelController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var result = dbcontext.Personels.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Personel personel)
        {
            dbcontext.Add(personel);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var result = await dbcontext.Personels.FindAsync(id);
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Personel personel)
        {
            if (personel.PersonelId == 0)
            {
                return RedirectToAction("Index");
            }
            dbcontext.Update(personel);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
       
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await dbcontext.Personels.FindAsync(id);
            dbcontext.Remove(delete);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
