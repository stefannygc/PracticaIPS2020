using BLL;
using Entity;
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
    public partial class ConsultarFrm : Form
    {
       
        IList<LiquidaCuota> liquidaCuotas = new List<LiquidaCuota>();
        LiquidaCuotaService service = new LiquidaCuotaService();
        public ConsultarFrm()
        {
            InitializeComponent();
        }
     
        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            
            string tipo = cmbConsultar.Text;
            Limpiar();
        
            DtgPaciente.DataSource = null;

            if (tipo.Equals("Contributivo"))
            {  
                DtgPaciente.DataSource = service.ListaContributivo();
                TotalContributivoTxt.Text = service.TotalizarContributivo().ToString();
                
            }
            else if (tipo == "Subsidiado")
            {
                
                DtgPaciente.DataSource = service.ListaSubsidiado();
                TotalSubsidiadoTxt.Text = service.TotalizarSubsidiado().ToString();

            }
            else  if (tipo.Equals("Todos"))
               
            {
               
                DtgPaciente.DataSource = service.ConsultarConsulta().liquidaCuotas;
                TodosTxt.Text = service.Totalizar().ToString();
            }

            if (tipo == "") { MessageBox.Show("Seleccione un tipo"); }


        }
        private void Limpiar()
        {
            TotalContributivoTxt.Text = " ";
            TotalSubsidiadoTxt.Text = " ";
            TodosTxt.Text = " ";
        }

        private void ConsultarFrm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
