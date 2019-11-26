using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TratamientoView
    {
        public int idTratamiento { get; set; }
        public string tratamiento1 { get; set; }
        public string diagnosticoFinal { get; set; }
        public System.DateTime fecha { get; set; }
        public int idMedico { get; set; }
        public int idPaciente { get; set; }
    }
}
