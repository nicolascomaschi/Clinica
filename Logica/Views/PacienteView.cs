using System;

namespace Logica
{
    public class PacienteView
    {
        public int idPaciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public DateTime? fechaNac { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string alergias { get; set; }
        public string antecedentes { get; set; }
        public int? idObraSocial { get; set; }
    }
}
