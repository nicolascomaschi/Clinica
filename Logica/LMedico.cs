using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LMedico
    {
        ClinicaEntities ctx = new ClinicaEntities();
        public List<MedicoView> Mostrar()
        {
            var list = from m in ctx.Medico
                       join e in ctx.Especialidad on m.idEspecialidad equals e.idEspecialidad 
                       select new MedicoView
                       {
                           idMedico = m.idMedico,
                           apellido = m.apellido,
                           nombre = e.nombre,
                           dni = m.dni,
                           telefono = m.telefono,
                           email = m.email,
                           fechaNac = m.fechaNac,
                           especialidad = e.nombre,
                           fechaIngreso = m.fechaIngreso,
                           idEspecialidad = m.idEspecialidad,
                       };
            return list.ToList();
        }

        public List<MedicoView> Buscar(string medico)
        {
            var list = from m in ctx.Medico
                       join e in ctx.Especialidad on m.idEspecialidad equals e.idEspecialidad
                       where m.nombre.Contains(medico)
                       select new MedicoView
                       {
                           idMedico = m.idMedico,
                           apellido = m.apellido,
                           nombre = e.nombre,
                           dni = m.dni,
                           telefono = m.telefono,
                           email = m.email,
                           fechaNac = m.fechaNac,
                           especialidad = e.nombre,
                           fechaIngreso = m.fechaIngreso,
                           idEspecialidad = m.idEspecialidad,
                       };
            return list.ToList();
        }

        public string Insert(string nombre, string apellido, int dni, string telefono, string email, DateTime fechaNac,
            DateTime fechaIngreso, int idEspecialidad)
        {
            try
            {
                Medico medico = new Medico
                {
                    apellido = apellido,
                    nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaNac = fechaNac,
                    fechaIngreso = fechaIngreso,
                    idEspecialidad = idEspecialidad,
                };
                ctx.Medico.Add(medico);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(int? id, string nombre, string apellido, int dni, string telefono, string email, DateTime fechaNac,
            DateTime fechaIngreso, int idEspecialidad)
        {
            try
            {
                Medico medico = new Medico
                {
                    idMedico = id??0,
                    apellido = apellido,
                    nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaNac = fechaNac,
                    fechaIngreso = fechaIngreso,
                    idEspecialidad = idEspecialidad,
                };
                if (medico.idMedico != 0)
                {
                    ctx.Entry(medico).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Medico.Where(os => os.idMedico == id).First();
                ctx.Medico.Remove(obj);
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
