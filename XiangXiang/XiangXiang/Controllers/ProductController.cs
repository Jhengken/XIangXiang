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
        public IActionResult ProductList()
        {
            IEnumerable<TProduct> data = null;
            data = from t in _conetxt.TProducts
                   select t;
            return View(data);
        }
        public IActionResult ProductCreate()
        {
 
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(TProduct tp)
        {
            return View();
        }
        public async Task<IActionResult> ProductEdit()
        {
                TProduct data = null;
            data = _conetxt.TProducts.FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return View(data);
            }
            return View(data);
        }
        [HttpPost]
        public IActionResult ProductEdit(TProduct tp)
        {
            return RedirectToAction("ProductList");
        }
        public IActionResult ProductDelete()
        {
            return View();
        }


        //PSite
        public IActionResult PSiteList()
        {
            return View();
        }
        public IActionResult PSiteCreate()
        {
            return View();
        }
        public IActionResult PSiteEdit()
        {
            return View();
        }
        public IActionResult PSiteDelete()
        {
            return View();
        }




        //PSiteRoom
        public IActionResult PSiteRoomList()
        {
            return View();
        }
        public IActionResult PSiteRoomCreate()
        {
            return View();
        }
        public IActionResult PSiteRoomEdit()
        {
            return View();
        }
        public IActionResult PSiteRoomDelete()
        {
            return View();
        }
    }
}
