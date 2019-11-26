using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class TratamientoDetalle : Form
    {
        public IContractDetalle contract { get; set; }
        public TratamientoDetalle()
        {
            InitializeComponent();
            dpFecha.Value = DateTime.Now;
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            LMedicamento obj = new LMedicamento();
            cbMedicamento.DataSource = obj.Mostrar();
            cbMedicamento.DisplayMember = "nombre";
            cbMedicamento.ValueMember = "idMedicamento";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            TratamientoDetalleView view = new TratamientoDetalleView
            {
                diagnosticoParcial = txtDiagnosticoParcial.Text,
                fecha = dpFecha.Value,
                idMedicamento = Convert.ToInt32(cbMedicamento.SelectedValue),
                sintomas = txtSistomas.Text,
                idTratamiento = 1,
                idTratamientoDetalle = 1,
                medicamento = cbMedicamento.SelectedText,
            };
            contract.PasarDetalle(view);
            txtSistomas.Text = string.Empty;
            txtDiagnosticoParcial.Text = string.Empty;
        }
    }
}
