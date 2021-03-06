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
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Almacenes_Productos = new HashSet<Almacenes_Productos>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Categoria { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public int Existencia { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacenes_Productos> Almacenes_Productos { get; set; }
        public virtual Categorias Categorias { get; set; }
        public virtual Marcas Marcas { get; set; }
    }
}
