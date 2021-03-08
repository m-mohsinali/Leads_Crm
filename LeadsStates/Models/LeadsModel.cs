using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class LeadsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PrimaryNumber { get; set; }
        public string SecoundryNumber { get; set; }
        public string Address { get; set; }
        public string LeadType { get; set; }
        public string City { get; set; }
        public string Project { get; set; }
        public string Phase { get; set; }
        public string Block { get; set; }
        public string PropertyType { get; set; }
        public string HomeType { get; set; }
        public decimal MinBudget { get; set; }
        public decimal MaxBudget { get; set; }
        public string AreaType { get; set; }
        public decimal MinArea { get; set; }
        public decimal MaxArea { get; set; }
        public string LeadPriority { get; set; }
        public string ClientType { get; set; }
        public string AllocatedUser { get; set; }
        public int Beds { get; set; }
        public string Source { get; set; }
        public string CreatedOn { get; set; }
    }
}