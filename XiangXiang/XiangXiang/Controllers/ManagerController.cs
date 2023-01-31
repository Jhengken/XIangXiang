using Microsoft.AspNetCore.Mvc;

namespace XiangXiang.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
