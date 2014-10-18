using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;

namespace RunForYourMoney.Controllers
{
    public class VenmoController : Controller
    {
        public ActionResult Index(string access_token)
        {
            ViewBag.access_token = access_token;

            return View();
        }
    }
}
