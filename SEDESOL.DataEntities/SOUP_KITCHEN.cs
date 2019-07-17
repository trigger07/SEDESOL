//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEDESOL.DataEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOUP_KITCHEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOUP_KITCHEN()
        {
            this.CAPTUREs = new HashSet<CAPTURE>();
            this.USER_SOUP_KITCHEN = new HashSet<USER_SOUP_KITCHEN>();
            this.SOUP_KITCHEN_USER_TYPE = new HashSet<SOUP_KITCHEN_USER_TYPE>();
            this.COUPONs = new HashSet<COUPON>();
            this.RATIONs = new HashSet<RATION>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public bool IsActive { get; set; }
        public int Id_State { get; set; }
        public bool AllowAnonym { get; set; }
        public string Folio { get; set; }
        public Nullable<int> Id_Region { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAPTURE> CAPTUREs { get; set; }
        public virtual STATE STATE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_SOUP_KITCHEN> USER_SOUP_KITCHEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOUP_KITCHEN_USER_TYPE> SOUP_KITCHEN_USER_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUPON> COUPONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATION> RATIONs { get; set; }
        public virtual REGION REGION { get; set; }
    }
}
