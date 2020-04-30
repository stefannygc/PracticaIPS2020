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
        Paciente paciente;
        
        PacienteService service = new PacienteService();
        public RegistrarPacienteFrm()
        {
            InitializeComponent();
           
            
        }
        
        private Paciente MapearPaciente()
        {
            if (paciente != null) { 
              paciente.Identificacion = IdentificacionTxt.Text;
              //paciente.Tarifa = Convert.ToDecimal(TarifaTxt.Text);
              paciente.NumLiquidacion =  NumLiquidacionTxt.Text;
              paciente.TipoAfiliacion = cmbTipoAfiliacion.Text;
              paciente.Salario = Convert.ToDecimal(TarifaTxt.Text);
              paciente.ValorServicio = Convert.ToDecimal(ValorServicioTxt.Text);
              paciente.CuotaModeradora = Convert.ToDecimal(CuotaTxt.Text);
               
            }return paciente;
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Paciente paciente = MapearPaciente();
            if (cmbTipoAfiliacion.Text == "subsidiado") 
            {
                paciente = new Subsidiado();
            }
            else
            {
                paciente = new Contributivo();
            }


            paciente.Identificacion = IdentificacionTxt.Text;
            //paciente.Tarifa = decimal.Parse(TarifaTxt.Text);
            paciente.NumLiquidacion = NumLiquidacionTxt.Text;
            paciente.TipoAfiliacion = cmbTipoAfiliacion.Text;
            paciente.Salario = decimal.Parse(SalarioTxt.Text);
            paciente.ValorServicio = decimal.Parse(ValorServicioTxt.Text);
            CuotaTxt.Text = paciente.CuotaModeradora.ToString();

            PacienteService service = new PacienteService();
            paciente.LiquidarCuotaModeradora();
            CuotaTxt.Text = paciente.CuotaModeradora.ToString();
            string mensaje = service.Guardar(paciente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            Console.Clear();
            RespuestaConsulta respuestaConsulta = service.ConsultarConsulta();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {

                foreach (var item in respuestaConsulta.pacientes)
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

            Paciente paciente = service.BuscarId(numeroLiquidacion);
            if (paciente != null)
            {
                Console.Write("Ingrese nuevo valor del servicio de hospitalizacion: ");
                paciente.ValorServicio = decimal.Parse(Console.ReadLine());
                paciente.LiquidarCuotaModeradora();
                string mensaje = service.Modificar(paciente);
                Console.Write(mensaje);
                Console.WriteLine(paciente.ToString());
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
