using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class CustomerController : Controller
    {
        private readonly dbXContext _conetxt;
        public CustomerController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
