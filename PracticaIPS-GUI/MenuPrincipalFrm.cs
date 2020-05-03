using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIPS_GUI
{
    public partial class MenuPrincipalFrm : Form
    {
        public MenuPrincipalFrm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarLiquidaCuotaFrm registrarPacienteFrm = new RegistrarLiquidaCuotaFrm();
            registrarPacienteFrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFrm consultarFrm = new ConsultarFrm();
            consultarFrm.Show();
        }
    }
}
