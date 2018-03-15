using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ScanStackOverflow.Controllers
{
    public class ScanController : Controller
    {
        // GET: Scan
        public ActionResult Index()
        {
            

            return View();
        }
    }
}