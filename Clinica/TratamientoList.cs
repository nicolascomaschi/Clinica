using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class TratamientoList : Form
    {
        LTratamiento tratamiento = new LTratamiento();
        public TratamientoList(int idPaciente)
        {
            InitializeComponent();
            Mostrar(idPaciente);
        }

        public void Mostrar(int idPaciente)
        {
            tratamientoViewBindingSource.DataSource = tratamiento.Mostrar(idPaciente);
        }

        private void TratamientoList_Load(object sender, EventArgs e)
        {

        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TratamientoView item = dataListado.Rows[e.RowIndex].DataBoundItem as TratamientoView;
            TratamientoDetalleList frm = new TratamientoDetalleList(item.idTratamiento);
            frm.ShowDialog();
        }
    }
}
