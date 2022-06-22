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
    
    public partial class PPEs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PPEs()
        {
            this.DocActions = new HashSet<DocActions>();
            this.EquipmentProfiles = new HashSet<EquipmentProfiles>();
            this.WorkOrders = new HashSet<WorkOrders>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string PropertyNo { get; set; }
        public Nullable<int> EquipmentTypeId { get; set; }
        public string Description { get; set; }
        public string PPEId { get; set; }
        public Nullable<System.DateTime> DateDelivered { get; set; }
        public string Barcode { get; set; }
        public string Serial { get; set; }
        public Nullable<int> BoxNumber { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> ArticleId { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual EquipmentTypes EquipmentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocActions> DocActions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentProfiles> EquipmentProfiles { get; set; }
        public virtual Offices Offices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrders> WorkOrders { get; set; }
    }
}