//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almacen02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.Despacho = new HashSet<Despacho>();
        }
    
        public int codigo { get; set; }
        public System.DateTime fecha_de_creacion { get; set; }
        public System.DateTime fecha_vencimiento { get; set; }
        public string nombre { get; set; }
        public string Descripcion { get; set; }
        public string UdM { get; set; }
        public decimal Costo { get; set; }
        public string Existencia { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despacho> Despacho { get; set; }
    }
}