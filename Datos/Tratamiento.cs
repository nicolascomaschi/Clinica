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
    
    public partial class Tratamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tratamiento()
        {
            this.TratamientoDetalle = new HashSet<TratamientoDetalle>();
            this.TratamientoMedicamento = new HashSet<TratamientoMedicamento>();
        }
    
        public int idTratamiento { get; set; }
        public string tratamiento1 { get; set; }
        public string diagnosticoFinal { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> idMedicamento { get; set; }
        public int idMedico { get; set; }
        public int idPaciente { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TratamientoDetalle> TratamientoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TratamientoMedicamento> TratamientoMedicamento { get; set; }
    }
}