using Datos;
using System;

namespace Logica
{
    public class Helpers
    {
        public string Guardar(ClinicaEntities ctx)
        {
            try
            {
                ctx.SaveChanges();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
