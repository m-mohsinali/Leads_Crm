using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string CityName { get; set; }
        public string PhaseName { get; set; }
        public string BlockName { get; set; }
    }
}