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
    
    public partial class RRHH_Personal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RRHH_Personal()
        {
            this.RRHH_Usuario = new HashSet<RRHH_Usuario>();
        }
    
        public int idtrabajador { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Correo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RRHH_Usuario> RRHH_Usuario { get; set; }
    }
}