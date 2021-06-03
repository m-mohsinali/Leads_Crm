using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeadsStates.Models;
using LeadsStates.Repository;

namespace LeadsStates.Controllers
{
    [Authorize]
    public class LeadsController : Controller
    {
        Repository.Repository repository = new Repository.Repository();
        // GET: Leads
        public ActionResult Index()
        {
            string userId = User.Identity.Name;
            var objlist = repository.GetAssignedLeads(userId);
            if (userId == "admin@leadscrm.com")
            {
                 objlist = repository.GetAllLeads();
            }
            return View("leads", objlist.ToList());
        }
        public ActionResult create_leads()
        {
            ViewBag.Message = "Your application description page.";
            LocationVm locationVm = new LocationVm();
            locationVm.Cities = repository.GetAllCities();
            locationVm.Projects = repository.GetProjects();
            locationVm.Phase = repository.GetPhases();
            locationVm.Blocks = repository.GetBlocks();
            return View(locationVm);
        }
        public ActionResult lead_detail(int id)
        {
            LeadsViewModel leadsVM = new LeadsViewModel();
            leadsVM.LeadsDetails = repository.GETLeadById(id);
            leadsVM.Users = repository.GetAllUsers();
            
            ViewBag.Message = "Your application description page.";

            return View(leadsVM);
        }
        public int CreateLead (string PrimaryNumber)
        {
            return repository.CreateLead(PrimaryNumber);
        }
        public bool UpdateLead(LeadsModel lead )
        {
            lead.AllocatedUser = User.Identity.Name;
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
        public bool UpdateLeadStatus(int leadId, string Status)
        {
            try
            {
                var obj = repository.UpdateLeadStatus(leadId , Status);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool SahreLead(int leadId, string UserId)
        {
            try
            {
                var obj = repository.SahreLead(leadId, UserId);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}