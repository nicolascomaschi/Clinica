﻿using System;
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
    public partial class ABMObraSocial : Form
    {
        public ABMObraSocial()
        {
            InitializeComponent();
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}