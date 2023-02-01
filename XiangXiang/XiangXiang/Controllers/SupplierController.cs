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
        public IActionResult List()
        {
            IEnumerable<TSupplier> data=null;
            dbXContext db = new dbXContext();
            data = from t in _conetxt.TSuppliers
                   select t;
            return View(data);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(TSupplier p)
        {
            dbXContext db = new dbXContext();
            _conetxt.TSuppliers.Add(p);
            _conetxt.SaveChanges();
            return RedirectToAction("List");
        }


    }
}
