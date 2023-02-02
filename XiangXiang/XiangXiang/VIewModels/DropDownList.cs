//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Mvc;

//namespace XiangXiang.VIewModels
//{
//    public class DropDownList
//    {
//        public List<SelectListItem> Items = new List<SelectListItem>();
//        public DropDownList(List<SelectListItem> items)
//        {
//            Items = items;
//        }

//        private void SetViewBagMovieType()
//        {
//            Items.Add(new SelectListItem("test1", "value1"));
//            Items.Add(new SelectListItem("test2", "value2"));
//            Items.Add(new SelectListItem("test3", "value3"));
//            ViewBag.MovieType = Items;
//        }

//        public ActionResult SelectCategoryEnum()
//        {

//            SetViewBagMovieType();

//            return View();

//        }
//        [HttpPost]

//        public ActionResult SelectCategoryEnum(string MovieType) //傳回來的是SelectListItem得value
//        {

//            SetViewBagMovieType();
//            ViewBag.messageString = MovieType.ToString() +

//                                    " val = " + MovieType + Items[2].Text;
//            return View();

//        }















//        //public enum eMovieCategories { Action, Drama, Comedy, Science_Fiction };
//        //private void SetViewBagMovieType(eMovieCategories selectedMovie)
//        //{
//        //    //IEnumerator
//        //    IEnumerable<string> values =

//        //                      Enum.GetValues(typeof(eMovieCategories))

//        //                      .Cast<string>();
//        //    IEnumerable<string> a = null;
//        //    foreach (var x in ooo)
//        //    {
//        //        a.add(x);
//        //    }
//        //    IEnumerable<SelectListItem> items = from value in values
//        //                                        select new SelectListItem
//        //                                        {
//        //                                            Text = value.ToString(),
//        //                                            Value = ((int)value).ToString(),
//        //                                            Selected = value == selectedMovie,
//        //                                        };
//        //    ViewBag.MovieType = items;
//        //}

//        //public ActionResult SelectCategoryEnum()
//        //{
//        //    SetViewBagMovieType(eMovieCategories.Drama);
//        //    return View();
//        //}
//        //[HttpPost]

//        //public ActionResult SelectCategoryEnum(eMovieCategories MovieType) //傳回來的是SelectListItem得value
//        //{
//        //    ViewBag.messageString = MovieType.ToString() +
//        //                            " val = " + (int)MovieType;
//        //    SetViewBagMovieType(eMovieCategories.Drama);
//        //    return View();
//        //}
//    }


//}
