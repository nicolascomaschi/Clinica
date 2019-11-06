using Datos;
using System;

namespace Logica
{
    public class Helpers
    {
        public bool Guardar(ClinicaEntities ctx)
        {
            try
            {
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
