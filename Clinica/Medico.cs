using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Medico : Form
    {
        LMedico obj = new LMedico(); 
        public Medico()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MedicoAdd frm = new MedicoAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmMedicoAdd_FormClosed);
            frm.ShowDialog();
        }

        private void frmMedicoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            medicoViewBindingSource.DataSource = null;
            medicoViewBindingSource.DataSource = obj.Mostrar();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            MedicoView item = dataListado.Rows[e.RowIndex].DataBoundItem as MedicoView;
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
                MedicoAdd frm = new MedicoAdd(item);
                frm.ShowDialog();
            }
            Mostrar();
        }
    }
}
