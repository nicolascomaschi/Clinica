using System;

namespace Logica
{
    public class MedicoView
    {
        public int idMedico { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public DateTime? fechaNac { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int? idEspecialidad { get; set; }
        public string especialidad { get; set; }
        public DateTime fechaIngreso { get; set; }
    }
}
