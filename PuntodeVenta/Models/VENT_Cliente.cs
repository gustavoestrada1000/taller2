//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntodeVenta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENT_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENT_Cliente()
        {
            this.VENT_VentaEncabezado = new HashSet<VENT_VentaEncabezado>();
        }
    
        public string nit { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Direccion { get; set; }
        public string UserSystem { get; set; }
    
        public virtual RRHH_Usuario RRHH_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENT_VentaEncabezado> VENT_VentaEncabezado { get; set; }
    }
}
