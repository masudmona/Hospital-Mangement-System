//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient_Bill
    {
        public int Bill_no { get; set; }
        public int P_ID { get; set; }
        public string P_type { get; set; }
        public Nullable<double> Doctor_charge { get; set; }
        public Nullable<double> Lab_charge { get; set; }
        public Nullable<double> Operation_charge { get; set; }
        public Nullable<double> Room_charge { get; set; }
        public Nullable<double> Nursing_charge { get; set; }
        public Nullable<double> Medicine_charge { get; set; }
        public double Total_amount { get; set; }
    }
}