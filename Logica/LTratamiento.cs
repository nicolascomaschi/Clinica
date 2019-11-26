using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LTratamiento
    {
        ClinicaEntities1 ctx = new ClinicaEntities1();

        public string Insertar(string tratamiento, DateTime fecha, string diagnosticofinal,
            int idPaciente, int idMedico, List<TratamientoDetalleView> list)
        {
            using (var transaction = ctx.Database.BeginTransaction())
            {
                try
                {
                    Tratamiento obj = new Tratamiento
                    {
                        diagnosticoFinal = diagnosticofinal,
                        fecha = fecha,
                        idMedico = idMedico,
                        idPaciente = idPaciente,
                        tratamiento1 = tratamiento,
                    };
                    ctx.Tratamiento.Add(obj);
                    ctx.SaveChanges();
                    foreach (var item in list)
                    {
                        TratamientoDetalle objDetalle = new TratamientoDetalle
                        {
                            diagnosticoParcial = item.diagnosticoParcial,
                            fecha = item.fecha,
                            idMedicamento = item.idMedicamento,
                            idTratamiento = obj.idTratamiento,
                            sintomas = item.sintomas,
                        };
                        ctx.TratamientoDetalle.Add(objDetalle);
                    }
                    ctx.SaveChanges();
                    transaction.Commit();
                    return "El registro se guardo correctamente";
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    return ex.Message;
                }
            }
        }

        public List<TratamientoView> Mostrar(int idPaciente)
        {
            var list = from os in ctx.Tratamiento
                       where os.idPaciente == idPaciente
                       select new TratamientoView
                       {
                           diagnosticoFinal = os.diagnosticoFinal,
                           fecha = os.fecha,
                           idMedico = os.idMedico,
                           idPaciente = os.idPaciente,
                           idTratamiento = os.idTratamiento,
                           tratamiento1 = os.tratamiento1,
                       };
            return list.ToList();
        }

        public List<TratamientoDetalleView> MostrarDetalle(int idTratamiento)
        {
            var list = from os in ctx.TratamientoDetalle
                       join m in ctx.Medicamento on os.idMedicamento equals m.idMedicamento
                       where os.idTratamiento == idTratamiento
                       select new TratamientoDetalleView
                       {
                           diagnosticoParcial = os.diagnosticoParcial,
                           fecha = os.fecha,
                           idTratamiento = os.idTratamiento,
                           idMedicamento = os.idMedicamento,
                           medicamento = m.nombre,
                           sintomas = os.sintomas,
                           idTratamientoDetalle = os.idTratamientoDetalle,
                       };
            return list.ToList();
        }

    }
}
