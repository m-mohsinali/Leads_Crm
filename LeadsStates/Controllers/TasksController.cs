using LeadsStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadsStates.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        Repository.Repository repository = new Repository.Repository();
        // GET: Tasks
        public ActionResult Index()
        {
            string userId = User.Identity.Name;
            var tasks = repository.GetTasksByUserId(userId);
            var leads =  repository.GetAssignedLeads(userId);
            if (userId == "admin@leadscrm.com")
            {
                tasks = repository.GetAllTasks();
                leads = repository.GetAllLeads();
            }
            TaskVM vm = new TaskVM() { Leads = leads, Tasks = tasks };
            return View(vm);
        }
        public int CreateTask(string LeadId , string TaskName , string TaskStatus , string TaskDate,string TaskDescription )
        {
            return repository.CreateTask(Convert.ToInt32(LeadId), TaskName, TaskStatus, TaskDate, TaskDescription);
        }
        public bool DeleteTask(int Id)
        {
            try
            {
                repository.DeleteTask(Id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}