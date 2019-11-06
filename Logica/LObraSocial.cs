using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Datos;

namespace Logica
{
    public class LObraSocial
    {
        ClinicaEntities ctx = new ClinicaEntities();
        public void Insertar(string nombre, string detalle)
        {
            ObraSocial obj = new ObraSocial
            {
                nombre = nombre,
                detalles = detalle,
            };
            ctx.ObraSocial.Add(obj);
            ctx.SaveChanges();
        }
    }
}
