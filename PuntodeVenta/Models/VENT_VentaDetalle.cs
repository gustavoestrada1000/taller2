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
    
    public partial class VENT_VentaDetalle
    {
        public int numerofactura { get; set; }
        public int codigoproducto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> costoUni { get; set; }
    
        public virtual BODE_PRODUCTO BODE_PRODUCTO { get; set; }
        public virtual VENT_VentaEncabezado VENT_VentaEncabezado { get; set; }
    }
}
