using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LTurno
    {
        ClinicaEntities1 ctx = new ClinicaEntities1();
        public List<TurnoView> Mostrar()
        {
            var list = from t in ctx.Turno
                       join p in ctx.Paciente on t.idPaciente equals p.idPaciente
                       join m in ctx.Medico on t.idMedico equals m.idMedico
                       join e in ctx.Empleado on t.idEmpleado equals e.idEmpleado
                       orderby t.fecha, t.hora
                       select new TurnoView
                       {
                           idPaciente = t.idPaciente,
                           detalles = t.detalles,
                           fecha = t.fecha,
                           hora = t.hora,
                           estado = t.estado,
                           idEmpleado = t.idEmpleado,
                           empleado = e.Apellido +" "+ e.Nombre,
                           medico = m.apellido +" "+ m.nombre,
                           idMedico = t.idMedico,
                           idTurno = t.idTurno,
                           paciente = p.apellido +" "+ p.nombre,
                       };
            return list.ToList();
        }

        public List<TurnoView> Buscar(DateTime date)
        {
            DateTime dateEnd = date.AddHours(24);
            var list = from t in ctx.Turno
                       join p in ctx.Paciente on t.idPaciente equals p.idPaciente
                       join m in ctx.Medico on t.idMedico equals m.idMedico
                       join e in ctx.Empleado on t.idEmpleado equals e.idEmpleado
                       where (t.fecha <= dateEnd && t.fecha >= date)
                       select new TurnoView
                       {
                           idPaciente = t.idPaciente,
                           detalles = t.detalles,
                           fecha = t.fecha,
                           hora = t.hora,
                           estado = t.estado,
                           idEmpleado = t.idEmpleado,
                           empleado = e.Apellido + " " + e.Nombre,
                           medico = m.apellido + " " + m.nombre,
                           idMedico = t.idMedico,
                           idTurno = t.idTurno,
                           paciente = p.apellido + " " + p.nombre,
                       };
            return list.ToList();
        }

        public string Insert(string detalle, string estado, int idPaciente, DateTime fecha, string hora,
            int idMedico, int idEmpleado)
        {
            try
            {
                var obj = ctx.Turno.Where(t => t.hora == hora && t.fecha == fecha).FirstOrDefault();
                if (obj != null)
                {
                    return "Ya existe un turno con esa fecha";
                }
                Turno turno = new Turno
                {
                    detalles = detalle,
                    estado = estado,
                    idPaciente = idPaciente,
                    fecha = fecha,
                    hora = hora,
                    idMedico = idMedico,
                    idEmpleado = idEmpleado,
                };
                ctx.Turno.Add(turno);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(int? id, string detalle, string estado, int idPaciente, DateTime fecha, string hora,
            int idMedico, int idEmpleado)
        {
            try
            {
                //var obj = ctx.Turno.Where(t => t.hora == hora && t.fecha == fecha).FirstOrDefault();
                //if (obj != null)
                //{
                //    return "Ya existe un turno con esa fecha";
                //}
                Turno turno = new Turno
                {
                    idTurno = id ?? 0,
                    detalles = detalle,
                    estado = estado,
                    idPaciente = idPaciente,
                    fecha = fecha,
                    hora = hora,
                    idMedico = idMedico,
                    idEmpleado = idEmpleado,
                };
                if (turno.idTurno != 0)
                {
                    ctx.Entry(turno).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Turno.Where(os => os.idTurno == id).First();
                ctx.Turno.Remove(obj);
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
