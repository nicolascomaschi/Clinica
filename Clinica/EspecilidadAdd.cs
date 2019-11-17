using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class EspecilidadAdd : Form
    {
        private int? id;
        private LEspecialidad obj = new LEspecialidad();
        public EspecilidadAdd(EspecialidadView view)
        {
            InitializeComponent();
            ObjEqual(view);
            MostrarTitulo();
        }

        private void EspecilidadAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string msj;
            if (id == null)
            {
                msj = obj.Insert(txtNombre.Text, txtDetalle.Text);
                MessageBox.Show(msj, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = obj.Edit(id, txtNombre.Text, txtDetalle.Text);
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

        private void ObjEqual(EspecialidadView view)
        {
            if (view != null)
            {
                this.id = view.idEspecialidad;
                txtDetalle.Text = view.detalle;
                txtNombre.Text = view.nombre;
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
