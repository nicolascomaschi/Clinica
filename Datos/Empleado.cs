//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int idEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int dni { get; set; }
        public Nullable<int> telefono { get; set; }
        public string email { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public Nullable<int> idMedico { get; set; }
    
        public virtual Medico Medico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}