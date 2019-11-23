using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacienteAdd : Form
    {
        private int? id;
        private LPaciente obj = new LPaciente();
        public PacienteAdd(PacienteView view)
        {
            InitializeComponent();
            MostrarTitulo();
            LlenarCombo();
            ObjEqual(view);
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
                msj = obj.Insert(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFecha.Value, txtAlergias.Text, txtAntecedentes.Text, Convert.ToInt32(cbObraSocial.SelectedValue));
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = obj.Edit(id, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFecha.Value, txtAlergias.Text, txtAntecedentes.Text, Convert.ToInt32(cbObraSocial.SelectedValue));
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

        private void ObjEqual(PacienteView view)
        {
            if (view != null)
            {
                this.id = view.idPaciente;
                txtApellido.Text = view.apellido;
                txtNombre.Text = view.nombre;
                txtAlergias.Text = view.alergias;
                txtAntecedentes.Text = view.antecedentes;
                txtDni.Text = view.dni.ToString();
                txtEmail.Text = view.email;
                txtTelefono.Text = view.telefono.ToString();
                cbObraSocial.SelectedValue = view.idObraSocial;
            }
        }

        private void LlenarCombo()
        {
            LObraSocial obj = new LObraSocial();
            cbObraSocial.DataSource = obj.Mostrar();
            cbObraSocial.DisplayMember = "nombre";
            cbObraSocial.ValueMember = "idObraSocial";
        }
    }
}
