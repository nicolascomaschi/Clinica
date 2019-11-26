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
    public partial class TratamientoDetalleList : Form
    {
        LTratamiento tratamiento = new LTratamiento();
        public TratamientoDetalleList(int idtratamiento)
        {
            InitializeComponent();
            Mostrar(idtratamiento);
        }

        public void Mostrar(int idtratamiento)
        {
            tratamientoDetalleViewBindingSource.DataSource = tratamiento.MostrarDetalle(idtratamiento);
        }

        private void TratamientoDetalleList_Load(object sender, EventArgs e)
        {

        }
    }
}
