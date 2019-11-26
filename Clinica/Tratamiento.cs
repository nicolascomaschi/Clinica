using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Tratamiento : Form
    {
        LPaciente paciente = new LPaciente();
        public Tratamiento()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            pacienteViewBindingSource.DataSource = null;
            pacienteViewBindingSource.DataSource = paciente.Mostrar(); 
        }

        private void Tratamiento_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtBuscar.Text = "";
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            pacienteViewBindingSource.DataSource = null;
            pacienteViewBindingSource.DataSource = paciente.Buscar(txtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           
            PacienteAdd frm = new PacienteAdd(null);
            frm.ShowDialog();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PacienteView item = dataListado.Rows[e.RowIndex].DataBoundItem as PacienteView;
            if (e.ColumnIndex == 0)
            {
                TratamientoAdd frm = new TratamientoAdd(item.idPaciente);
                frm.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                TratamientoList frm = new TratamientoList(item.idPaciente);
                frm.ShowDialog();
            }      
        }
    }
}
