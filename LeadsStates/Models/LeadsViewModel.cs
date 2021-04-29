using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadsStates.Models
{
    public class LeadsViewModel
    {
        public IEnumerable<UserModel> Users { get; set; }
        public UserModel SelectedUser { get; set; }
        public LeadsModel LeadsDetails { get; set; }
    }
}