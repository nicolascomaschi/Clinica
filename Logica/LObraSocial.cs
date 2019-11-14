using Datos;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LObraSocial
    {
        ClinicaEntities ctx = new ClinicaEntities();
        public List<ObraSocialView> Mostrar()
        {
            var list = from os in ctx.ObraSocial
                       select new ObraSocialView
                       {
                           idObraSocial = os.idObraSocial,
                           detalles = os.detalles,
                           nombre = os.nombre,
                       };
            return list.ToList();
        }

        public List<ObraSocialView> Buscar(string obraSocial)
        {
            var list = from os in ctx.ObraSocial
                       where os.nombre.Contains(obraSocial)
                       select new ObraSocialView
                       {
                           idObraSocial = os.idObraSocial,
                           detalles = os.detalles,
                           nombre = os.nombre,
                       };
            return list.ToList();
        }

        public void Insert(string nombre, string detalle)
        {
            ObraSocial obraSocial = new ObraSocial
            {
                nombre = nombre,
                detalles = detalle,
            };
            ctx.ObraSocial.Add(obraSocial);
            ctx.SaveChanges();
        }

        public void Edit(int? id, string nombre, string detalle)
        {
            ObraSocial obraSocial = new ObraSocial
            {
                idObraSocial = id??0,
                nombre = nombre,
                detalles = detalle,
            };
            if (obraSocial.idObraSocial != 0)
            {
                ctx.Entry(obraSocial).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void Delete(int? id)
        {
            var obj = ctx.ObraSocial.Where(os => os.idObraSocial == id).First();
            ctx.ObraSocial.Remove(obj);
            ctx.SaveChanges();
        }
    }
}
