using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {

        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return  Redirect("/");

            }

            return Content("Hellow from our combook page...");
            {
                
        };
           
        }

    }
}