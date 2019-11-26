using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinica
{
    public partial class TratamientoAdd : Form, IContractDetalle
    {
        private int idPaciente;
        private LTratamiento tratamiento = new LTratamiento();
        private List<TratamientoDetalleView> list = new List<TratamientoDetalleView>();
        public TratamientoAdd(int id)
        {
            InitializeComponent();
            this.idPaciente = id;
            LlenarComboMedico();
            Mostrar();
        }

        public void Mostrar()
        {
            tratamientoDetalleViewBindingSource.DataSource = null;
            tratamientoDetalleViewBindingSource.DataSource = list;
        }

        private void LlenarComboMedico()
        {
            LMedico obj = new LMedico();
            cbMedico.DataSource = obj.Mostrar();
            cbMedico.DisplayMember = "apellido";
            cbMedico.ValueMember = "idMedico";
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TratamientoDetalle frm = new TratamientoDetalle();
            frm.contract = this;
            frm.ShowDialog();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string msj = tratamiento.Insertar(txtTratamiento.Text, dpFecha.Value, txtDiagnosticoFinal.Text,
                this.idPaciente, Convert.ToInt32(cbMedico.SelectedValue), list);
            MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void PasarDetalle(TratamientoDetalleView view)
        {
            list.Add(view);
            Mostrar();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TratamientoDetalleView obj = dataListado.Rows[e.RowIndex].DataBoundItem as TratamientoDetalleView;
            list.Remove(obj);
            Mostrar();
        }
    }
}
