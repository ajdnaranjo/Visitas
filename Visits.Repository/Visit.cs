//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Visits.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int VisitsID { get; set; }
        public int ClientID { get; set; }
        public int SellerID { get; set; }
        public string Observations { get; set; }
        public System.DateTime VistDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Seller Seller { get; set; }
    }
}