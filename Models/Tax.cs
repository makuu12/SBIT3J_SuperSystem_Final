//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBIT3J_SuperSystem_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tax
    {
        public int Tax_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public Nullable<decimal> Tax_Income { get; set; }
        public Nullable<int> Tax_Rate { get; set; }
        public Nullable<decimal> Tax_Amount { get; set; }
    
        public virtual EmployeeInformation EmployeeInformation { get; set; }
    }
}