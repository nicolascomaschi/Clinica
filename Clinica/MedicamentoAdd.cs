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
    public partial class MedicamentoAdd : Form
    {
        private int? id;
        private LMedicamento obj = new LMedicamento();
        public MedicamentoAdd(MedicamentoView view)
        {
            InitializeComponent();
            ObjEqual(view);
            MostrarTitulo();
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

        private void ObjEqual(MedicamentoView view)
        {
            if (view != null)
            {
                this.id = view.idMedicamento;
                txtDetalle.Text = view.detalles;
                txtNombre.Text = view.nombre;
            }
        }
    }
}
