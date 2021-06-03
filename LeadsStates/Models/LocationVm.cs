using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class LocationVm
    {
        public IEnumerable<LocationModel> Projects { get; set; }
        public int SelectedCity { get; set; }
        public int SelectedProject { get; set; }
        public int SelectedPhase { get; set; }
        public int SelectedBlock { get; set; }
        public IEnumerable<LocationModel> Cities { get; set; }
        public IEnumerable<LocationModel> Phase { get; set; }
        public IEnumerable<LocationModel> Blocks { get; set; }
    }
}