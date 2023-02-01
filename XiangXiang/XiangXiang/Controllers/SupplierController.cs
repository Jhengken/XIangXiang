using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class SupplierController : Controller
    {
        private readonly dbXContext _conetxt;
        public SupplierController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
