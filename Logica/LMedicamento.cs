using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LMedicamento
    {
        ClinicaEntities1 ctx = new ClinicaEntities1();
        public List<MedicamentoView> Mostrar()
        {
            var list = from m in ctx.Medicamento
                       select new MedicamentoView
                       {
                           idMedicamento = m.idMedicamento,
                           nombre = m.nombre,
                           detalles = m.detalles,
                       };
            return list.ToList();
        }

        public List<MedicamentoView> Buscar(string medicamento)
        {
            var list = from m in ctx.Medicamento
                       where m.nombre.Contains(medicamento)
                       select new MedicamentoView
                       {
                           idMedicamento = m.idMedicamento,
                           nombre = m.nombre,
                           detalles = m.detalles,
                       };
            return list.ToList();
        }

        public string Insert(string nombre, string detalle)
        {
            try
            {
                Medicamento medicamento = new Medicamento
                {
                    detalles = detalle,
                    nombre = nombre,
                };
                ctx.Medicamento.Add(medicamento);
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
                Medicamento medicamento = new Medicamento
                {
                    detalles = detalle,
                    nombre = nombre,
                    idMedicamento = id ?? 0,
                };
                if (medicamento.idMedicamento != 0)
                {
                    ctx.Entry(medicamento).State = System.Data.Entity.EntityState.Modified;
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
                var obj = ctx.Medicamento.Where(os => os.idMedicamento == id).First();
                ctx.Medicamento.Remove(obj);
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
