using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Empleado : Form
    {
        LEmpleado obj = new LEmpleado();
        public Empleado()
        {
            InitializeComponent();
            Mostrar();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoAdd frm = new EmpleadoAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmEmpleadoAdd_FormClosed);
            frm.ShowDialog();
        }

        private void frmEmpleadoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            empleadoViewBindingSource.DataSource = null;
            empleadoViewBindingSource.DataSource = obj.Mostrar();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            EmpleadoView item = dataListado.Rows[e.RowIndex].DataBoundItem as EmpleadoView;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Realmete desea eliminar el registro", "Clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    msj = obj.Delete(item.idMedico);
                    MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == 1)
            {
                EmpleadoAdd frm = new EmpleadoAdd(item);
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
            empleadoViewBindingSource.DataSource = null;
            empleadoViewBindingSource.DataSource = obj.Buscar(txtBuscar.Text);
        }
    }
}
