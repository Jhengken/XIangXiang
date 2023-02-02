using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class AOrderController : Controller
    {
        private readonly dbXContext db;
        public AOrderController(dbXContext dbXContext) 
        {
            db = dbXContext;
        }
        public IActionResult List()
        {
            IEnumerable<TAorder> aorders = null;            
            aorders = from t in db.TAorders select new TAorder
                      {
                          AorderId = t.AorderId,
                          SupplierId = t.SupplierId,
                          AdvertiseId = t.AdvertiseId,
                          OrderDate = t.OrderDate,
                          EndDate = t.EndDate,
                          Clicks = t.Clicks,
                          Price= t.Price,
                          Advertise = t.Advertise,
                          Supplier = t.Supplier,
                      };
            return View(aorders);
        }

        //創建廣告訂單
        public IActionResult Create()
        {                       
            return View();
        }
        [HttpPost]
        public IActionResult Create(TAorder aorder)
        {           
            db.TAorders.Add(aorder);
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}
