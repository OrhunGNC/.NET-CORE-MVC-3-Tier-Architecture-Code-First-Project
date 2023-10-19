using coreData.Data;
using Microsoft.AspNetCore.Mvc;
using coreModel.Model;
using System.Data.SqlTypes;
using System.Linq;
using coreModel.Model.ViewModel;

namespace corekatmanUI.Controllers
{
    public class ReportsController : Controller
    {
        public readonly ApplicationDbContext dbcontext;
        public ReportsController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            var result = (from k in dbcontext.Kids
                          join p in dbcontext.Personels on k.PersonelId equals p.PersonelId
                          select new kidperlistview
                          {
                              KidId = k.KidId,
                              NameSurname = k.NameSurname,
                              Gender = k.Gender,
                              BirthDate=k.BirthDate,
                              Name=p.NameSurname,
                              Genders=p.Gender,
                              BirthDates=p.BirthDate,
                              ShiftStatus=p.ShiftStatus
                          }).ToList();
            return View(result);
        }
        public IActionResult ProTaskReport()
        {
            var result = (from p in dbcontext.Projects
                          join t in dbcontext.Taskkss on p.TaskksId equals t.TaskksId
                          select new projecttasklistivew
                          {
                              ProjectId = p.ProjectId,
                              ProjectName = p.ProjectName,
                              StartDate = p.StartDate,
                              EndDate = p.EndDate,
                              TaskkDescription=t.TaskkDescription,
                              TaskkName=t.TaskkName,
                              TaskkPoint=t.TaskkPoint
                          }).ToList();
            return View(result);
        }
        public IActionResult UnitTaskReport()
        {
            var result = (from u in dbcontext.Unit
                          join t in dbcontext.Taskkss
                          on u.TaskksId equals t.TaskksId
                          select new unittasklistview
                          {
                              UnitId=u.UnitId,
                              UnitName=u.UnitName,
                              NumbofEmployee=u.NumbofEmployee,
                              TaskkDescription=t.TaskkDescription,
                              TaskkName=t.TaskkName,
                              TaskkPoint=t.TaskkPoint
                          }).ToList();
            return View(result);
        }
    }
}
