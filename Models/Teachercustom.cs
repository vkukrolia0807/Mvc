using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_mgmt_Model.Models
{
    public class Teachercustom
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

        [Required(ErrorMessage ="Phone number is required")]
        [RegularExpression("^[0-9](10)$", ErrorMessage = "phone Number is not valid")]
        public string Mno { get; set; }
        [Required(ErrorMessage = "Start date and time cannot be empty")]
        //validate:Must be greater than current date
        [DataType(DataType.DateTime)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Gender is required")]

        public string gender { get; set; }
        [Required(ErrorMessage = "address is required")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required(ErrorMessage = "city is required")]
        public int city { get; set; }
        [Required(ErrorMessage = "state is required")]
        public int state { get; set; }
        [Required(ErrorMessage = "country is required")]
        public int country { get; set; }
        [Required(ErrorMessage = "subject is required")]
        public string subject { get; set; }
    }
}