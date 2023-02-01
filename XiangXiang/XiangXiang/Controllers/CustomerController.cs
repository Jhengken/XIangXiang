using Microsoft.AspNetCore.Mvc;
using XiangXiang.Models;
using XiangXiang.VIewModels;

namespace XiangXiang.Controllers
{
    public class CustomerController : Controller
    {
        private readonly dbXContext _conetxt;
        public CustomerController(dbXContext conetxt)
        {
            _conetxt = conetxt;
        }
        public IActionResult List(KeywordViewModel vm)
        {
            IEnumerable<TCustomer> data = null;
            dbXContext db = new dbXContext();
            if (string.IsNullOrEmpty(vm.txtKeyword))
                data = from t in _conetxt.TCustomers
                       select t;
            else
                data = db.TCustomers.Where(t => t.Name.Contains(vm.txtKeyword) ||
                t.Phone.Contains(vm.txtKeyword) ||
                t.Email.Contains(vm.txtKeyword) ||
                t.Birth.ToString().Contains(vm.txtKeyword));
            return View(data);
        }
    }
}
