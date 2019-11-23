using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Turno : Form
    {
        private LTurno obj = new LTurno();
        public Turno()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            turnoViewBindingSource.DataSource = null;
            turnoViewBindingSource.DataSource = obj.Mostrar();
        }

        private void BunifuImageButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTurnoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TurnoAdd frm = new TurnoAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmTurnoAdd_FormClosed);
            frm.ShowDialog();
        }

        private void BunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DpFiltro_onValueChanged(object sender, EventArgs e)
        {
            turnoViewBindingSource.DataSource = null;
            turnoViewBindingSource.DataSource = obj.Buscar(dpFiltro.Value.Date);
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            TurnoView item = dataListado.Rows[e.RowIndex].DataBoundItem as TurnoView;
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
                TurnoAdd frm = new TurnoAdd(item);
                frm.ShowDialog();
            }
            Mostrar();
        }
    }
}
