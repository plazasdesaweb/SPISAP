//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPISAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RELACION_LABORAL
    {
        public RELACION_LABORAL()
        {
            this.DEXPERIENCIAs = new HashSet<DEXPERIENCIA>();
        }
    
        public string COD_RELACION { get; set; }
        public string DES_RELACION { get; set; }
    
        public virtual ICollection<DEXPERIENCIA> DEXPERIENCIAs { get; set; }
    }
}