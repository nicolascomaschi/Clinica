using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class TurnoAdd : Form
    {
        private int? id;
        private LTurno obj = new LTurno();
        private LEmpleado objE = new LEmpleado();
        public TurnoAdd(TurnoView view)
        {
            InitializeComponent();
            
            MostrarTitulo();
            LlenarComboMedico();
            LlenarComboPaciente();
            ObjEqual(view);
        }

        private void TurnoAdd_Load(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string msj;
            if (id == null)
            {
                msj = obj.Insert(txtDetalle.Text, "alta", Convert.ToInt32(cbPaciente.SelectedValue),dpFecha.Value.Date,txtHora.Text,Convert.ToInt32(cbMedico.SelectedValue), objE.RecuperarUltimo());
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = obj.Edit(id, txtDetalle.Text, "edit", Convert.ToInt32(cbPaciente.SelectedValue), dpFecha.Value.Date, txtHora.Text, Convert.ToInt32(cbMedico.SelectedValue), objE.RecuperarUltimo());
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void MostrarTitulo()
        {
            if (id == null)
            {
                lblTitle.Text = "Guardar";
                btnGuardar.Text = "Guardar";
            }
            else
            {
                lblTitle.Text = "Editar";
                btnGuardar.Text = "Editar";
            }
        }

        private void ObjEqual(TurnoView view)
        {
            if (view != null)
            {
                this.id = view.idPaciente;
                txtDetalle.Text = view.detalles;
                txtHora.Text = view.hora;
                dpFecha.Value = view.fecha;
                cbMedico.SelectedValue = view.idMedico;
                cbPaciente.SelectedValue = view.idPaciente;
            }
        }

        private void LlenarComboMedico()
        {
            LMedico obj = new LMedico();
            cbMedico.DataSource = obj.Mostrar();
            cbMedico.DisplayMember = "apellido";
            cbMedico.ValueMember = "idMedico";
        }

        private void LlenarComboPaciente()
        {
            LPaciente obj = new LPaciente();
            cbPaciente.DataSource = obj.Mostrar();
            cbPaciente.DisplayMember = "apellido";
            cbPaciente.ValueMember = "idPaciente";
        }
    }
}
