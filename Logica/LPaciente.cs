using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LPaciente
    {
        ClinicaEntities ctx = new ClinicaEntities();
        public List<PacienteView> Mostrar()
        {
            var list = from e in ctx.Paciente
                       select new PacienteView
                       {
                           idPaciente = e.idPaciente,
                           apellido = e.apellido,
                           nombre = e.nombre,
                           dni = e.dni,
                           telefono = e.telefono,
                           email = e.email,
                           fechaNac = e.fechaNac,
                           alergias = e.alergias,
                           antecedentes = e.antecedentes,
                           idObraSocial = e.idObraSocial,
                       };
            return list.ToList();
        }

        public List<PacienteView> Buscar(string paciente)
        {
            var list = from e in ctx.Paciente
                       where e.nombre.Contains(paciente)
                       select new PacienteView
                       {
                           idPaciente = e.idPaciente,
                           apellido = e.apellido,
                           nombre = e.nombre,
                           dni = e.dni,
                           telefono = e.telefono,
                           email = e.email,
                           fechaNac = e.fechaNac,
                           alergias = e.alergias,
                           antecedentes = e.antecedentes,
                           idObraSocial = e.idObraSocial,
                       };
            return list.ToList();
        }

        public string Insert(string nombre, string apellido, int dni, string telefono, string email, DateTime fechaNac,
            string alergias, string antecedentes, int idObraSocial)
        {
            try
            {
                Paciente paciente = new Paciente
                {
                    apellido = apellido,
                    nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaNac = fechaNac,
                    alergias = alergias,
                    antecedentes = antecedentes,
                    idObraSocial = idObraSocial,
                };
                ctx.Paciente.Add(paciente);
                ctx.SaveChanges();
                return "La operacion se realizo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(int? id, string nombre, string apellido, int dni, string telefono, string email, DateTime fechaNac,
            string alergias, string antecedentes, int idObraSocial)
        {
            try
            {
                Paciente paciente = new Paciente
                {
                    idPaciente = id ?? 0,
                    apellido = apellido,
                    nombre = nombre,
                    dni = dni,
                    telefono = telefono,
                    email = email,
                    fechaNac = fechaNac,
                    alergias = alergias,
                    antecedentes = antecedentes,
                    idObraSocial = idObraSocial,
                };
                if (paciente.idPaciente != 0)
                {
                    ctx.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Paciente.Where(os => os.idPaciente == id).First();
                ctx.Paciente.Remove(obj);
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
