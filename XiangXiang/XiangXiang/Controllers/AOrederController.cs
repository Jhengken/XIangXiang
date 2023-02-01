using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;

namespace XiangXiang.Controllers
{
    public class AOrderController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TAorder> aorders = null;            
            dbXContext db = new dbXContext();
            aorders = from t in db.TAorders select new TAorder
                      {
                          AorderId = t.AorderId,
                          SupplierId = t.SupplierId,
                          AdvertiseId = t.AdvertiseId,
                          OrderDate = t.OrderDate,
                          EndDate = t.EndDate,
                          Clicks = t.Clicks,
                          Advertise = t.Advertise,
                          Supplier = t.Supplier,
                      };
            return View(aorders);
        }
    }
}
