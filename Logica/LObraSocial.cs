using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LObraSocial
    {
        ClinicaEntities1 ctx = new ClinicaEntities1();
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

        public string Insert(string nombre, string detalle)
        {
            try
            {
                ObraSocial obraSocial = new ObraSocial
                {
                    nombre = nombre,
                    detalles = detalle,
                };
                ctx.ObraSocial.Add(obraSocial);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(int? id, string nombre, string detalle)
        {
            try
            {
                ObraSocial obraSocial = new ObraSocial
                {
                    idObraSocial = id ?? 0,
                    nombre = nombre,
                    detalles = detalle,
                };
                if (obraSocial.idObraSocial != 0)
                {
                    ctx.Entry(obraSocial).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return "La operacion se realizo correctamente";
                }
                return "Error al buscar la llave primaria";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int? id)
        {
            try
            {
                var obj = ctx.ObraSocial.Where(os => os.idObraSocial == id).First();
                ctx.ObraSocial.Remove(obj);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
