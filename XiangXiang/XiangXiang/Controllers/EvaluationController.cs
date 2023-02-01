using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class EvaluationController : Controller
    {
        private readonly dbXContext _conetxt;
        public EvaluationController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
