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
    
    public partial class REGION_PRODUCT
    {
        public int Id { get; set; }
        public int Id_Region { get; set; }
        public int Id_Product { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual REGION REGION { get; set; }
    }
}
