//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PGNs
    {
        public int Id { get; set; }
        public string ControlNo { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public string OfficeName { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string RequestProblem { get; set; }
        public string ActionTaken { get; set; }
        public string CreatedBy { get; set; }
        public string Remarks { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Offices Offices { get; set; }
    }
}
