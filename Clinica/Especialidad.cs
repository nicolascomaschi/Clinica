using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Especialidad : Form
    {
        LEspecialidad obj = new LEspecialidad(); 
        public Especialidad()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            especialidadViewBindingSource.DataSource = null;
            especialidadViewBindingSource.DataSource = obj.Mostrar();
        }

        private void frmEspecilidadAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EspecilidadAdd frm = new EspecilidadAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmEspecilidadAdd_FormClosed);
            frm.ShowDialog();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            EspecialidadView item = dataListado.Rows[e.RowIndex].DataBoundItem as EspecialidadView;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Realmete desea eliminar el registro", "Clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    msj = obj.Delete(item.idEspecialidad);
                    MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == 1)
            {
                EspecilidadAdd frm = new EspecilidadAdd(item);
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
            especialidadViewBindingSource.DataSource = null;
            especialidadViewBindingSource.DataSource = obj.Buscar(txtBuscar.Text);
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {

        }
    }
}
