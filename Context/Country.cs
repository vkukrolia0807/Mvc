//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_mgmt_Model.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.States = new HashSet<State>();
        }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<State> States { get; set; }
    }
}
