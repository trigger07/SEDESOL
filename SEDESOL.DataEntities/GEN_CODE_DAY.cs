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
    
    public partial class GEN_CODE_DAY
    {
        public int Id { get; set; }
        public int Id_Month { get; set; }
        public int Id_Year { get; set; }
        public int Day { get; set; }
    
        public virtual MONTH MONTH { get; set; }
        public virtual YEAR YEAR { get; set; }
    }
}
