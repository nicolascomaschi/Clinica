﻿using Logica;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class ObraSocialAdd : Form
    {
        private int? id;
        private LObraSocial obj = new LObraSocial();
        public ObraSocialAdd(ObraSocialView view)
        {
            InitializeComponent();
            ObjEqual(view);
            MostrarTitulo();
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
                msj = obj.Edit(id,txtNombre.Text, txtDetalle.Text);
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

        private void ObjEqual(ObraSocialView view)
        {
            if (view != null)
            {
                this.id = view.idObraSocial;
                txtDetalle.Text = view.detalles;
                txtNombre.Text = view.nombre;
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
