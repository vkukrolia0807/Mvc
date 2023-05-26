using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_mgmt_Model.Models
{
    public class Registercustom
    {
        public int id { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        
      
        public string fname { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        
      
        public string lname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        
        public string password { get; set; }
        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string confipassword { get; set; }

    }
}