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
    public partial class RegistrarPacienteFrm : Form
    {
        LiquidaCuota liquidaCuota;

        LiquidaCuotaService service = new LiquidaCuotaService();
        public RegistrarPacienteFrm()
        {
            InitializeComponent();
           
            
        }
        
        private LiquidaCuota MapearPaciente()
        {
            if (liquidaCuota != null) {
                liquidaCuota.Identificacion = IdentificacionTxt.Text;
                //liquidaCuota.Tarifa = Convert.ToDecimal(TarifaTxt.Text);
                liquidaCuota.NumLiquidacion =  NumLiquidacionTxt.Text;
                liquidaCuota.TipoAfiliacion = cmbTipoAfiliacion.Text;
                liquidaCuota.Salario = Convert.ToDecimal(TarifaTxt.Text);
                liquidaCuota.ValorServicio = Convert.ToDecimal(ValorServicioTxt.Text);
                liquidaCuota.CuotaModeradora = Convert.ToDecimal(CuotaTxt.Text);
               
            }return liquidaCuota;
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            LiquidaCuota liquidaCuota = MapearPaciente();
            if (cmbTipoAfiliacion.Text == "subsidiado") 
            {
                liquidaCuota = new Subsidiado();
            }
            else
            {
                liquidaCuota = new Contributivo();
            }


            liquidaCuota.Identificacion = IdentificacionTxt.Text;
            //liquidaCuota.Tarifa = decimal.Parse(TarifaTxt.Text);
            liquidaCuota.NumLiquidacion = NumLiquidacionTxt.Text;
            liquidaCuota.TipoAfiliacion = cmbTipoAfiliacion.Text;
            liquidaCuota.Salario = decimal.Parse(SalarioTxt.Text);
            liquidaCuota.ValorServicio = decimal.Parse(ValorServicioTxt.Text);
            CuotaTxt.Text = liquidaCuota.CuotaModeradora.ToString();

            LiquidaCuotaService service = new LiquidaCuotaService();
            liquidaCuota.LiquidarCuotaModeradora();
            CuotaTxt.Text = liquidaCuota.CuotaModeradora.ToString();
            string mensaje = service.Guardar(liquidaCuota);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            
            RespuestaConsulta respuestaConsulta = service.ConsultarConsulta();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {

                foreach (var item in respuestaConsulta.liquidaCuotas)
                {
                    Console.WriteLine(item.ToString());
                }
            }
           
        }
    
    

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            Console.Clear();

            Console.WriteLine("\tModificar una liquidacion");
            Console.Write("\tDigite numero de liquidacion: ");
            string numeroLiquidacion;
            numeroLiquidacion = Console.ReadLine();
            RespuestaBusqueda respuestaBusqueda = service.Buscar(numeroLiquidacion);
            Console.WriteLine(respuestaBusqueda.Mensaje);

            LiquidaCuota liquidaCuota = service.BuscarId(numeroLiquidacion);
            if (liquidaCuota != null)
            {
                Console.Write("Ingrese nuevo valor del servicio de hospitalizacion: ");
                liquidaCuota.ValorServicio = decimal.Parse(Console.ReadLine());
                liquidaCuota.LiquidarCuotaModeradora();
                string mensaje = service.Modificar(liquidaCuota);
                Console.Write(mensaje);
                Console.WriteLine(liquidaCuota.ToString());
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            ConsoleKeyInfo continuar;
            Console.WriteLine("Digite la identificacion que desea eliminar :");
            string identificacion = Console.ReadLine();
            string mensajeEliminar = service.Eliminar(identificacion);
            Console.WriteLine(mensajeEliminar);
            continuar = Console.ReadKey();
        }
        private void Limpiar()
        {
            IdentificacionTxt.Text = "";
            NumLiquidacionTxt.Text = "";
            //TarifaTxt.Text = "";
            cmbTipoAfiliacion.Text = "";
            SalarioTxt.Text = "";
            ValorServicioTxt.Text = "";
            CuotaTxt.Text = "";
            IdentificacionTxt.Focus();

        }
    }
}
