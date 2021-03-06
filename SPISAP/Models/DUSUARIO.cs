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
    
    public partial class DUSUARIO
    {
        public DUSUARIO()
        {
            this.DCOMUNICACIONs = new HashSet<DCOMUNICACION>();
            this.DCOMUNICACIONs1 = new HashSet<DCOMUNICACION>();
            this.DCUENTAS = new HashSet<DCUENTA>();
            this.DCUENTAS1 = new HashSet<DCUENTA>();
            this.DDIRECCIONs = new HashSet<DDIRECCION>();
            this.DDIRECCIONs1 = new HashSet<DDIRECCION>();
            this.DDISCAPACIDADs = new HashSet<DDISCAPACIDAD>();
            this.DDISCAPACIDADs1 = new HashSet<DDISCAPACIDAD>();
            this.DEXPERIENCIAs = new HashSet<DEXPERIENCIA>();
            this.DEXPERIENCIAs1 = new HashSet<DEXPERIENCIA>();
            this.DFAMILIARES = new HashSet<DFAMILIAR>();
            this.DFAMILIARES1 = new HashSet<DFAMILIAR>();
            this.DFORMACIONs = new HashSet<DFORMACION>();
            this.DFORMACIONs1 = new HashSet<DFORMACION>();
            this.DPERSONALES = new HashSet<DPERSONALES>();
            this.DPERSONALES1 = new HashSet<DPERSONALES>();
        }
    
        public string COD_USER { get; set; }
        public string DES_USER { get; set; }
        public string CLAVE { get; set; }
        public string COD_SUCURSAL { get; set; }
        public System.DateTime FECHA_INS { get; set; }
        public System.DateTime FECHA_UPD { get; set; }
    
        public virtual ICollection<DCOMUNICACION> DCOMUNICACIONs { get; set; }
        public virtual ICollection<DCOMUNICACION> DCOMUNICACIONs1 { get; set; }
        public virtual ICollection<DCUENTA> DCUENTAS { get; set; }
        public virtual ICollection<DCUENTA> DCUENTAS1 { get; set; }
        public virtual ICollection<DDIRECCION> DDIRECCIONs { get; set; }
        public virtual ICollection<DDIRECCION> DDIRECCIONs1 { get; set; }
        public virtual ICollection<DDISCAPACIDAD> DDISCAPACIDADs { get; set; }
        public virtual ICollection<DDISCAPACIDAD> DDISCAPACIDADs1 { get; set; }
        public virtual ICollection<DEXPERIENCIA> DEXPERIENCIAs { get; set; }
        public virtual ICollection<DEXPERIENCIA> DEXPERIENCIAs1 { get; set; }
        public virtual ICollection<DFAMILIAR> DFAMILIARES { get; set; }
        public virtual ICollection<DFAMILIAR> DFAMILIARES1 { get; set; }
        public virtual ICollection<DFORMACION> DFORMACIONs { get; set; }
        public virtual ICollection<DFORMACION> DFORMACIONs1 { get; set; }
        public virtual ICollection<DPERSONALES> DPERSONALES { get; set; }
        public virtual ICollection<DPERSONALES> DPERSONALES1 { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
