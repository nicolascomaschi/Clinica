using System;

namespace Logica
{
    public class TratamientoDetalleView
    {
        public int idTratamientoDetalle { get; set; }
        public int idTratamiento { get; set; }
        public string sintomas { get; set; }
        public string diagnosticoParcial { get; set; }
        public int? idMedicamento { get; set; }
        public string medicamento { get; set; }
        public DateTime? fecha { get; set; }
    }
}
