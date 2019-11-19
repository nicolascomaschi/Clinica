using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LEmpleado
    {
        ClinicaEntities ctx = new ClinicaEntities();
        public List<EmpleadoView> Mostrar()
        {
            var list = from e in ctx.Empleado
                       join m in ctx.Medico on e.idMedico equals m.idMedico
                       select new EmpleadoView
                       {
                           idEmpleado = e.idEmpleado,
                           apellido = e.Apellido,
                           nombre = e.Nombre,
                           dni = e.dni,
                           telefono = e.telefono,
                           email = e.email,
                           fechaIngreso = e.fechaIngreso,
                           idMedico = m.idMedico,
                           medico = m.apellido + " " + m.nombre,
                       };
            return list.ToList();
        }

        public List<EmpleadoView> Buscar(string empleado)
        {
            var list = from e in ctx.Empleado
                       join m in ctx.Medico on e.idMedico equals m.idMedico
                       where e.Apellido.Contains(empleado)
                       select new EmpleadoView
                       {
                           idEmpleado = e.idEmpleado,
                           apellido = e.Apellido,
                           nombre = e.Nombre,
                           dni = e.dni,
                           telefono = e.telefono,
                           email = e.email,
                           fechaIngreso = e.fechaIngreso,
                           idMedico = m.idMedico,
                           medico = m.apellido + " " + m.nombre,
                       };
            return list.ToList();
        }

        public string Insert(string nombre, string apellido, int dni, string telefono, string email, 
            DateTime fecha, int idMedico)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    Apellido = apellido,
                    Nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaIngreso = fecha,
                    idMedico = idMedico,
                };
                ctx.Empleado.Add(empleado);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(int? id, string nombre, string apellido, int dni, string telefono, string email, 
            DateTime fecha, int idMedico)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    idEmpleado = id ?? 0,
                    Apellido = apellido,
                    Nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaIngreso = fecha,
                    idMedico = idMedico,
                };
                if (empleado.idEmpleado != 0)
                {
                    ctx.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Empleado.Where(os => os.idEmpleado == id).First();
                ctx.Empleado.Remove(obj);
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
