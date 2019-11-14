using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class ObraSocial : Form
    {
        private LObraSocial obj = new LObraSocial();
        public ObraSocial()
        {
            InitializeComponent();
            Mostrar();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar()
        {
            obraSocialViewBindingSource.DataSource = null;
            obraSocialViewBindingSource.DataSource = obj.Mostrar();
        }

        private void frmObraSocialAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObraSocialAdd frm = new ObraSocialAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmObraSocialAdd_FormClosed);
            frm.ShowDialog();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObraSocialView item = dataListado.Rows[e.RowIndex].DataBoundItem as ObraSocialView;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Realmete desea eliminar el registro", "Clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    obj.Delete(item.idObraSocial);
                }
            }
            if (e.ColumnIndex == 1)
            {
                ObraSocialAdd frm = new ObraSocialAdd(item);
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
            obraSocialViewBindingSource.DataSource = null;
            obraSocialViewBindingSource.DataSource = obj.Buscar(txtBuscar.Text);
        }
    }
}
