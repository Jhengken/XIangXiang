using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TProduct> data = null;
            dbXContext db = new dbXContext();
            data = from t in db.TProducts
                   select t;
            return View(data);
        }
    }
}
