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
    
    public partial class USER_SOUP_KITCHEN
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Soup_Kitchen { get; set; }
        public bool IsActive { get; set; }
    
        public virtual SOUP_KITCHEN SOUP_KITCHEN { get; set; }
        public virtual USER USER { get; set; }
    }
}
