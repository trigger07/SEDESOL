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
    
    public partial class SOUP_KITCHEN_USER_TYPE
    {
        public int Id { get; set; }
        public int Id_SoupKitchen { get; set; }
        public int Id_UserType { get; set; }
        public bool IsActive { get; set; }
    
        public virtual SOUP_KITCHEN SOUP_KITCHEN { get; set; }
        public virtual USER_TYPE USER_TYPE { get; set; }
    }
}
