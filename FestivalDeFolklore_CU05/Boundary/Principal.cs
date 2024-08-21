using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestivalDeFolklore_CU05.Boundary
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCasoUso05_Click(object sender, EventArgs e)
        {

            OpcionRegFestival();

        }

        private void OpcionRegFestival()
        {
            HabilitarVentana();
        }
        private void HabilitarVentana()
        {
            //
            // Crear una instancia del formulario secundario
            Pantalla pantallaCU05 = new Pantalla();

            this.Hide();

            // Mostrar el formulario secundario
            pantallaCU05.Show();
        }
    }
}
