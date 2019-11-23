using System;

namespace Logica
{
    public class TurnoView
    {
        public int idTurno { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string detalles { get; set; }
        public int idPaciente { get; set; }
        public string paciente { get; set; }
        public int idMedico { get; set; }
        public string medico { get; set; }
        public string estado { get; set; }
        public int idEmpleado { get; set; }
        public string empleado { get; set; }
    }
}
