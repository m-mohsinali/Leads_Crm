using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class TaskVM
    {
        public IEnumerable<TaskModel> Tasks { get; set; }
        public IEnumerable<LeadsModel> Leads { get; set; }
        public string SelectedLead { get; set; }
    }
}