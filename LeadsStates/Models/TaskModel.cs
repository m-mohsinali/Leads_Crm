using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }        
        public string Taskdescription { get; set; }        
        public string TaskDate { get; set; }        
        public string UserName { get; set; }        
        public string Status { get; set; }        
    }
}