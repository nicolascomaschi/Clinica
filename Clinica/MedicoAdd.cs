using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class MedicoAdd : Form
    {
        private int? id;
        private LMedico obj = new LMedico();
        public MedicoAdd(MedicoView view)
        {
            InitializeComponent();
            ObjEqual(view);
            MostrarTitulo();
            LlenarCombo();
        }

        private void MedicoAdd_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string msj;
            if (id == null)
            {
                msj = obj.Insert(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFecha.Value, dpFechaIngreso.Value, Convert.ToInt32(cbEspecialidad.SelectedValue));
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = obj.Edit(id, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFecha.Value, dpFechaIngreso.Value, Convert.ToInt32(cbEspecialidad.SelectedValue));
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
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

        private void ObjEqual(MedicoView view)
        {
            if (view != null)
            {
                this.id = view.idMedico;
                txtApellido.Text = view.apellido;
                txtNombre.Text = view.nombre;
                txtDni.Text = view.dni.ToString();
                txtEmail.Text = view.email;
                txtTelefono.Text = view.telefono.ToString();
                cbEspecialidad.SelectedValue = view.idEspecialidad;
                //dpFecha.Value = view.fechaNac;
            }
        }

        private void LlenarCombo()
        {
            LEspecialidad obj = new LEspecialidad();
            cbEspecialidad.DataSource = obj.Mostrar();
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "idEspecialidad";
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
