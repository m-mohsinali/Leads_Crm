using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Common
{
    public class Database
    {
        public const string GET_ALL_LEADS = "GETAllLeads";
        public const string GET_LEAD_BY_ID = "GETLeadById";
        public const string CREATE_LEADE = "CreateLeade";
        public const string UPDATE_LEAD = "UpdateLead";
        public const string UPDATE_LEAD_STATUS = "UpdateLeadStatus";
        public const string GET_ALL_USERS = "GetAllUsers";
        public const string SAHRE_LEAD = "SahreLead";
        public const string Get_Assigned_Leads = "GetAssignedLeads";
        public const string GET_ALL_TASKS = "GetAllTasks";
        public const string GET_TASKS_BY_USER_ID = "GetTasksByUserId";
        public const string ADD_TASK = "AddTask";
        public const string ADD_BLOCKS = "AddBlocks";
        public const string ADD_PHASE = "AddPhase";
        public const string ADD_PROJECT = "AddProject";
        public const string GET_PROJECTS = "GetProjects";
        public const string GET_PHASES = "GetPhases";   
        public const string GET_BLOCKS = "GetBlocks";   
        public const string GET_ALL_CITIES = "GetAllCities";   
        public const string DELETE_PROJECT = "DeleteProject";   
        public const string DELETE_BLOCK = "DeleteBlock";   
        public const string DELETE_PHASE = "DeletePhase";   
        public const string DELETE_TASK = "DeleteTask";   
    }
}