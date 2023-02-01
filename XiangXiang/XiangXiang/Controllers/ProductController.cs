using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbXContext _conetxt;
        public ProductController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult List()
        {
            IEnumerable<TProduct> data = null;
            dbXContext db = new dbXContext();
            data = from t in _conetxt.TProducts
                   select t;
            return View(data);
        }
    }
}
