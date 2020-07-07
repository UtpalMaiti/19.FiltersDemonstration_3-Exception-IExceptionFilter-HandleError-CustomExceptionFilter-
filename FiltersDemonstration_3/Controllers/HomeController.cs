using FiltersDemonstration_3.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemonstration_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HandleError(View = "TestError", ExceptionType = typeof(ArgumentOutOfRangeException))]
        [HandleError(View = "Error")]
        //[CustomExceptionFilter]
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            // throw new IndexOutOfRangeException();

            return View();
        }
    }
}