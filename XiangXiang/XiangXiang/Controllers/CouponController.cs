using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class CouponController : Controller
    {
        private readonly dbXContext _conetxt;
        public CouponController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
