using Microsoft.AspNetCore.Mvc;

namespace XiangXiang.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
