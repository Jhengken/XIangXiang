using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbXContext _conetxt;
        IWebHostEnvironment _environment;
        public ProductController(dbXContext conetxt, IWebHostEnvironment environment)
        {
            _conetxt = conetxt;
            _environment = environment;
        }
        public IActionResult ProductList()
        {
            IEnumerable<TProduct> data = null;
            //data = from t in _conetxt.TProducts      //只select想要的
            //       select new TProduct 
            //       { 
            //           ProductId=t.ProductId,
            //           Name=t.Name,
            //           SupplierId = t.SupplierId
            //       };
            data = _conetxt.TProducts.Select(x => new TProduct      //Lambda只select想要的
            {
                ProductId = x.ProductId,
                Name = x.Name,
                SupplierId = x.SupplierId
            });

            return View(data);
        }
        public IActionResult ProductCreate()
        {
            IEnumerable<string> dl = from t in _conetxt.TSuppliers
                                    select t.Name;
            ViewBag.datalist = dl;
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(TProduct tp)
        {
            TSupplier supplier = _conetxt.TSuppliers.FirstOrDefault(t => t.Name.Equals(tp.SupplierName));
            if (supplier != null)
            {
                tp.SupplierId = supplier.SupplierId;
                _conetxt.TProducts.Add(tp);
                _conetxt.SaveChangesAsync();
                return RedirectToAction("ProductList");
            }
            return RedirectToAction("ProductCreate");
        }
        public IActionResult ProductEdit(int? id)
        {
            if (id != null)
            {
                TProduct x = _conetxt.TProducts.FirstOrDefault(t => t.ProductId == id);
                if (x != null)
                return View(x);
            }
            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public IActionResult ProductEdit(TProduct tp)
        {
            TProduct x = _conetxt.TProducts.FirstOrDefault(t => t.ProductId == tp.ProductId);
            if (x != null)
            {
                x.Name = tp.Name;
                _conetxt.SaveChangesAsync();
            }
            return RedirectToAction("ProductList");
        }
        public IActionResult ProductDelete(int? id)
        {
            if (id != null)
            {
                TProduct del = _conetxt.TProducts.FirstOrDefault(t => t.ProductId == id);
                if (del != null)
                {
                    _conetxt.TProducts.Remove(del);
                    _conetxt.SaveChangesAsync();
                }
            }
            return RedirectToAction("ProductList");
        }


        //PSite
        public IActionResult PSiteList()
        {
            IEnumerable<TPsite> data = null;
            data = from t in _conetxt.TPsites
                   select t;
            return View(data);
        }
        public IActionResult PSiteCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PSiteCreate(TPsite tp)
        {
            if (tp.photo != null)
            {
                string photoName = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".jpg";
                string path = Path.Combine(_environment.WebRootPath, "images", "PSite", photoName); //_environment.WebRootPath + "/images/" + photoName;
                tp.Image = photoName;
                tp.photo.CopyToAsync(new FileStream(path, FileMode.Create));
            }
            _conetxt.TPsites.Add(tp);
            _conetxt.SaveChanges();
            return RedirectToAction("PSiteList");
        }
        //public IActionResult PSiteEdit()
        //{
        //    if (id != null)
        //    {
        //        dbXContext db = new dbXContext();
        //        Product x = db.Products.FirstOrDefault(t => t.ProductId.Equals(id));
        //        if (x != null)
        //        {
        //            return View(x);
        //        }
        //    }
        //    return View("PSiteList");
        //}
        //[HttpPost]
        //public IActionResult PSiteEdit(TPsite tp)
        //{
        //    dbXContext db = new dbXContext();
        //    Product x = db.Products.FirstOrDefault(t => t.ProductId == vm.ProductId);
        //    if (x != null)
        //    {
        //        if (vm.photo != null)
        //        {
        //            string photoName = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + ".jpg";
        //            string path = _environment.WebRootPath + "/images/" + photoName;  //Path.Combine(_environment.WebRootPath, "/images/", photoName); 嘗試用combine看起來乾淨
        //            if (x.Image != null)                        //刪除原有的檔案
        //            {
        //                GC.Collect();
        //                GC.WaitForPendingFinalizers();
        //                string del = _environment.WebRootPath + "/images/" + x.Image.ToString();
        //                //ContorllerBase也有定義File所以要加System.IO.來準確使用
        //                System.IO.File.Delete(del);            //靜態，所以沒有dispose
        //            }
        //            x.Image = photoName;
        //            vm.photo.CopyTo(new FileStream(path, FileMode.Create));
        //        }
        //        x.Name = vm.Name;
        //        x.UnitPrice = vm.UnitPrice;
        //        db.SaveChangesAsync();
        //    }
        //    return RedirectToAction("PSiteList");
        //}
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
