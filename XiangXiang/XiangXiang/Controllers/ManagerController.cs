using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class ManagerController : Controller
    {
        private readonly dbXContext _conetxt;
        public ManagerController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult List()
        {
            IEnumerable<TManager> data = null;
            data = from t in _conetxt.TManagers
                   select t;
            return View(data);
        }
    }
}
