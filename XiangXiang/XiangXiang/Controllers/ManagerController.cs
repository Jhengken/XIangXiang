using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TManager> data = null;
            dbXContext db = new dbXContext();
            data = from t in db.TManagers
                   select t;
            return View(data);
        }
    }
}
