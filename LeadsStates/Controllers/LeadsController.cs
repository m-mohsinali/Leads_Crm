using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeadsStates.Models;
using LeadsStates.Repository;

namespace LeadsStates.Controllers
{
    public class LeadsController : Controller
    {
        Repository.Repository repository = new Repository.Repository();
        // GET: Leads
        public ActionResult Index()
        {
            string userId = User.Identity.Name;
           var objlist = repository.GetAllLeads();
            return View("leads", objlist.ToList());
        }
        public ActionResult create_leads()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult lead_detail(int id)
        {
            var obj = repository.GETLeadById(id);
            ViewBag.Message = "Your application description page.";

            return View(obj);
        }
        public int CreateLead (string PrimaryNumber)
        {
            return repository.CreateLead(PrimaryNumber);
        }
        public bool UpdateLead(LeadsModel lead )
        {
            try
            {
                var obj = repository.UpdateLead(lead);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}