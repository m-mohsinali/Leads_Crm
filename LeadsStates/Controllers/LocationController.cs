using LeadsStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeadsStates.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        Repository.Repository repository = new Repository.Repository();
        // GET: Location
        public ActionResult Index()
        {
            LocationVm locationVm = new LocationVm();
            locationVm.Projects = repository.GetProjects();
            locationVm.Cities = repository.GetAllCities();
            return View("AddProject", locationVm);
        }
        public ActionResult AddPhase()
        {
            LocationVm locationVm = new LocationVm();
            locationVm.Cities = repository.GetAllCities();
            locationVm.Projects = repository.GetProjects();
            locationVm.Phase = repository.GetPhases();
            return View(locationVm);
        }
        public ActionResult AddBlock()
        {
            LocationVm locationVm = new LocationVm();
            locationVm.Cities = repository.GetAllCities();
            locationVm.Projects = repository.GetProjects();
            locationVm.Phase = repository.GetPhases();
            locationVm.Blocks = repository.GetBlocks();
            return View(locationVm);
        }
        public bool AddNewProject (int CityId , string ProjectName)
        {
            try
            {
                repository.AddProject(CityId, ProjectName);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool AddNewPhase(int CityId, int ProjectId,string PhaseName)
        {
            try
            {
                repository.AddPhase(CityId, ProjectId, PhaseName);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool AddNewBlock(int CityId, int ProjectId, int PhaseId , string BlockName)
        {
            try
            {
                repository.AddBlocks(CityId, ProjectId, PhaseId , BlockName);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool DeleteProject(int Id)
        {
            try
            {
                repository.DeleteProject(Id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool DeletePhase(int Id)
        {
            try
            {
                repository.DeletePhase(Id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool DeleteBlock(int Id)
        {
            try
            {
                repository.DeleteBlock(Id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}