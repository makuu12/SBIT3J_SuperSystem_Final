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

    public partial class Employee_Attendance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Attendance()
        {
            this.Payrolls = new HashSet<Payroll>();
        }

        public int Attendance_ID { get; set; }
        public Nullable<int> Account_ID { get; set; }
        public Nullable<System.DateTime> Time_In { get; set; }
        public Nullable<System.DateTime> Time_Out { get; set; }
        public Nullable<System.TimeSpan> Total_Hour_Worked { get; set; }
        public Nullable<System.DateTime> Absent { get; set; }

        public virtual EmployeeAccount EmployeeAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payroll> Payrolls { get; set; }
        public static decimal CalculateTotalHours(DateTime timeIn, DateTime timeOut)
        {
            TimeSpan totalTime = timeOut - timeIn;
            return Math.Floor((decimal)totalTime.TotalHours);
        }

    }
}
