using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class EmpleadoAdd : Form
    {
        private int? id;
        private LEmpleado obj = new LEmpleado();
        public EmpleadoAdd(EmpleadoView view)
        {
            InitializeComponent();
            MostrarTitulo();
            LlenarCombo();
            ObjEqual(view);
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

        private void ObjEqual(EmpleadoView view)
        {
            if (view != null)
            {
                this.id = view.idMedico;
                txtApellido.Text = view.apellido;
                txtNombre.Text = view.nombre;
                txtDni.Text = view.dni.ToString();
                txtEmail.Text = view.email;
                txtTelefono.Text = view.telefono.ToString();
                cbMedico.SelectedValue = view.idMedico;
                dpFechaIngreso.Value = view.fechaIngreso;
            }
        }

        private void LlenarCombo()
        {
            LMedico obj = new LMedico();
            cbMedico.DataSource = obj.Mostrar();
            cbMedico.DisplayMember = "apellido";
            cbMedico.ValueMember = "idMedico";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
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
                msj = obj.Insert(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFechaIngreso.Value, Convert.ToInt32(cbMedico.SelectedValue));
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = obj.Edit(id, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDni.Text), txtTelefono.Text,
                    txtEmail.Text, dpFechaIngreso.Value, Convert.ToInt32(cbMedico.SelectedValue));
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
    }
}
