//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenuFerreBerny.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compras()
        {
            this.ComprasDetalle = new HashSet<ComprasDetalle>();
        }
    
        public int Id { get; set; }
        public string Documento { get; set; }
        public Nullable<int> Id_Proveedor { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<decimal> Sumas { get; set; }
        public Nullable<decimal> Iva { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprasDetalle> ComprasDetalle { get; set; }
    }
}
