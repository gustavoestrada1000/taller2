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
    
    public partial class BODE_PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODE_PRODUCTO()
        {
            this.VENT_CompraDetalle = new HashSet<VENT_CompraDetalle>();
            this.VENT_VentaDetalle = new HashSet<VENT_VentaDetalle>();
        }
    
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> Existencia { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENT_CompraDetalle> VENT_CompraDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENT_VentaDetalle> VENT_VentaDetalle { get; set; }
    }
}
