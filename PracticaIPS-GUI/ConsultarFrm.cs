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

            if (tipo.Equals("Liquidaciones Contributivo"))
            {  
                DtgPaciente.DataSource = service.ListaContributivo();
                TotalContributivoTxt.Text = service.TotalizarContributivo().ToString();
                ValorLiContributivoTxt.Text = service.SumaLiquidacionContributivo().ToString();
                
            }
            else if (tipo == "Liquidaciones Subsidiado")
            {
                
                DtgPaciente.DataSource = service.ListaSubsidiado();
                TotalSubsidiadoTxt.Text = service.TotalizarSubsidiado().ToString();
                ValorLiquiSubsidiadioTxt.Text = service.SumaLiquidacionSubsidiado().ToString();

            }
            else  if (tipo.Equals("Total De Liquidaciones"))
               
            {
               
                DtgPaciente.DataSource = service.ConsultarConsulta().liquidaCuotas;
                TodosTxt.Text = service.Totalizar().ToString();
                ValorTotalLiquiTxt.Text = service.TotalCuotaModeradoras().ToString();
            }

            if (tipo == "") { MessageBox.Show("Seleccione un tipo"); }


        }
        private void Limpiar()
        {
            TotalContributivoTxt.Text = " ";
            TotalSubsidiadoTxt.Text = " ";
            TodosTxt.Text = " ";
            ValorLiContributivoTxt.Text = "";
            ValorLiquiSubsidiadioTxt.Text = "";
            ValorTotalLiquiTxt.Text = "";
        }

        private void ConsultarFrm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
