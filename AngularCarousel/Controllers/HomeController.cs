using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularCarousel.Models;

namespace AngularCarousel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetData() {           
            using (MyDatabaseEntities context = new MyDatabaseEntities()) {
               var ret = context.Galleries.ToList().Select(x => new { x.ImageID, x.Title, x.Summary,Path = @"\Images\" + x.ImageGuid.Value +"." + x.ImageExt  }).ToList();
               return Json(ret, JsonRequestBehavior.AllowGet);             
            }           
        }

    }
}
