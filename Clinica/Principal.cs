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

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Especialidad form = Application.OpenForms.OfType<Especialidad>().FirstOrDefault();
            Especialidad hijo1 = form ?? new Especialidad();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Paciente form = Application.OpenForms.OfType<Paciente>().FirstOrDefault();
            Paciente hijo1 = form ?? new Paciente();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Medico form = Application.OpenForms.OfType<Medico>().FirstOrDefault();
            Medico hijo1 = form ?? new Medico();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Empleado form = Application.OpenForms.OfType<Empleado>().FirstOrDefault();
            Empleado hijo1 = form ?? new Empleado();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Turno form = Application.OpenForms.OfType<Turno>().FirstOrDefault();
            Turno hijo1 = form ?? new Turno();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }
    }
}
