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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnObraSocial_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            ObraSocial form = Application.OpenForms.OfType<ObraSocial>().FirstOrDefault();
            ObraSocial hijo1 = form ?? new ObraSocial();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
