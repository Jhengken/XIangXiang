using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;
using XiangXiang.VIewModels;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace XiangXiang.Controllers
{
    public class AdvertiseController : Controller
    {
        private readonly dbXContext db;

        public AdvertiseController(dbXContext dbXContext)
        {
            db = dbXContext;
        }
        //廣告清單
        public IActionResult List()
        {
            IEnumerable<TAdvertise> advertises = null;
            advertises = from t in db.TAdvertises
                         select new TAdvertise
                         {
                             AdvertiseId = t.AdvertiseId,
                             Name = t.Name,
                             DatePrice = t.DatePrice,
                             TAorders = t.TAorders
                         };
            return View(advertises);
        }
        //創建新廣告
        public IActionResult Create()
        {                   
            return View();
        }
        [HttpPost]
        public IActionResult Create(TAdvertise advertise)
        {
            db.TAdvertises.Add(advertise);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        //修改廣告
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {               
                TAdvertise ad = db.TAdvertises.FirstOrDefault(t => t.AdvertiseId == id);
                if (ad != null)
                    return View(ad);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(TAdvertiseViewModel ad)
        {
            TAdvertise Editad = db.TAdvertises.FirstOrDefault(t => t.AdvertiseId == ad.AdvertiseId );
            if (Editad != null)
            {
                Editad.Name = ad.Name;
                Editad.DatePrice = ad.DatePrice;
                db.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
        //刪除廣告類型
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                TAdvertise Delcoupon = db.TAdvertises.FirstOrDefault(t => t.AdvertiseId == id);
                if (Delcoupon != null)
                {
                    db.TAdvertises.Remove(Delcoupon);
                    db.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }
    }
}
