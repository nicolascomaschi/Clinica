using System;
using Logica;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Paciente : Form
    {
        LPaciente obj = new LPaciente();
        public Paciente()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PacienteAdd frm = new PacienteAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmPacienteAdd_FormClosed);
            frm.ShowDialog();
        }

        private void frmPacienteAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            pacienteViewBindingSource.DataSource = null;
            pacienteViewBindingSource.DataSource = obj.Mostrar();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            PacienteView item = dataListado.Rows[e.RowIndex].DataBoundItem as PacienteView;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Realmete desea eliminar el registro", "Clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    msj = obj.Delete(item.idPaciente);
                    MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == 1)
            {
                PacienteAdd frm = new PacienteAdd(item);
                frm.ShowDialog();
            }
            Mostrar();
        }

        private void TxtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtBuscar.Text = "";
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            pacienteViewBindingSource.DataSource = null;
            pacienteViewBindingSource.DataSource = obj.Buscar(txtBuscar.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
