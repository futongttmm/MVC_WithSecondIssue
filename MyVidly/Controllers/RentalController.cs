using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyVidly.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental

        //use this to return the form to the client
        public ActionResult New()
        {
            return View();
        }
    }
}