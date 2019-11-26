using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LEspecialidad
    {
        ClinicaEntities1 ctx = new ClinicaEntities1();
        public List<EspecialidadView> Mostrar()
        {
            var list = from e in ctx.Especialidad
                       select new EspecialidadView
                       {
                           idEspecialidad = e.idEspecialidad,
                           detalle = e.detalles,
                           nombre = e.nombre,
                       };
            return list.ToList();
        }

        public List<EspecialidadView> Buscar(string especialidad)
        {
            var list = from e in ctx.Especialidad
                       where e.nombre.Contains(especialidad)
                       select new EspecialidadView
                       {
                           idEspecialidad = e.idEspecialidad,
                           detalle = e.detalles,
                           nombre = e.nombre,
                       };
            return list.ToList();
        }

        public string Insert(string nombre, string detalle)
        {
            try
            {
                Especialidad especialidad = new Especialidad
                {
                    nombre = nombre,
                    detalles = detalle,
                };
                ctx.Especialidad.Add(especialidad);
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
                Especialidad especialidad = new Especialidad
                {
                    idEspecialidad = id ?? 0,
                    nombre = nombre,
                    detalles = detalle,
                };
                if (especialidad.idEspecialidad != 0)
                {
                    ctx.Entry(especialidad).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Especialidad.Where(os => os.idEspecialidad == id).First();
                ctx.Especialidad.Remove(obj);
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
