using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult ProductEdit()
        {
            TProduct data = null;
            //data = _conetxt.TProducts.FirstOrDefault();

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









        public enum eMovieCategories { Action, Drama, Comedy, Science_Fiction };

        private void SetViewBagMovieType(eMovieCategories selectedMovie)
        {

            IEnumerable<eMovieCategories> values =

                              Enum.GetValues(typeof(eMovieCategories))

                              .Cast<eMovieCategories>();

            IEnumerable<SelectListItem> items =

                from value in values

                select new SelectListItem

                {

                    Text = value.ToString(),

                    Value = value.ToString(),

                    Selected = value == selectedMovie,

                };

            ViewBag.MovieType = items;

        }

        public ActionResult SelectCategoryEnum()
        {

            SetViewBagMovieType(eMovieCategories.Drama);

            return View();

        }
        [HttpPost]

        public ActionResult SelectCategoryEnum(string MovieType) //傳回來的是SelectListItem得value
        {

            ViewBag.messageString = MovieType.ToString() +

                                    " val = "/* + (int)MovieType*/;
            SetViewBagMovieType(eMovieCategories.Drama);
            return View();

        }
    }
}
