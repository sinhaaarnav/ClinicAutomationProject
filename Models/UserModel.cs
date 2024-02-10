using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ClinicAutomationProject.Models;

namespace ClinicAutomationProject.Models
{
    public class UserModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }    

    }
    public class CurrentUserModel
    {
        public int UserId { get; set; } 
        public string UserName { get; set; }

        public string Role { get; set; }
        public Nullable<int> RefrenceToId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
    }
}