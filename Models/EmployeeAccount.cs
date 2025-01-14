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
    
    public partial class EmployeeAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeAccount()
        {
            this.AuditTrails = new HashSet<AuditTrail>();
            this.Employee_Attendance = new HashSet<Employee_Attendance>();
            this.Sales_Transaction = new HashSet<Sales_Transaction>();
        }
    
        public int Account_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    
        public virtual EmployeeInformation EmployeeInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditTrail> AuditTrails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Attendance> Employee_Attendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Transaction> Sales_Transaction { get; set; }
    }
}
