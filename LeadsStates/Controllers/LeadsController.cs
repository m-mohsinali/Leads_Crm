using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadsStates.Controllers
{
    public class LeadsController : Controller
    {
        // GET: Leads
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult create_leads()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult lead_detail()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}