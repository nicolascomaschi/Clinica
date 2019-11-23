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
    public partial class Medicamento : Form
    {
        LMedicamento obj = new LMedicamento();
        public Medicamento()
        {
            InitializeComponent();
            Mostrar();
        }

        private void frmMedicamentoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            medicamentoViewBindingSource.DataSource = null;
            medicamentoViewBindingSource.DataSource = obj.Mostrar();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MedicamentoAdd frm = new MedicamentoAdd(null);
            frm.FormClosed += new FormClosedEventHandler(frmMedicamentoAdd_FormClosed);
            frm.ShowDialog();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string msj;
            MedicamentoView item = dataListado.Rows[e.RowIndex].DataBoundItem as MedicamentoView;
            if (e.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Realmete desea eliminar el registro", "Clinica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    msj = obj.Delete(item.idMedicamento);
                    MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == 1)
            {
                MedicamentoAdd frm = new MedicamentoAdd(item);
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
            medicamentoViewBindingSource.DataSource = null;
            medicamentoViewBindingSource.DataSource = obj.Buscar(txtBuscar.Text);
        }
    }
}
