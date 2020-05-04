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
    public partial class RegistrarLiquidaCuotaFrm : Form
    {
        LiquidaCuota liquidaCuota;

        LiquidaCuotaService service = new LiquidaCuotaService();
        public RegistrarLiquidaCuotaFrm()
        {
            InitializeComponent();
           
            
        }
        
        private LiquidaCuota MapearPaciente()
        {
            if (cmbTipoAfiliacion.Text == "subsidiado")
            {
                liquidaCuota = new Subsidiado();
            }
            else
            {
                liquidaCuota = new Contributivo();
            }


            if (liquidaCuota != null) {
                liquidaCuota.Fecha = FechaDTP.Value;
                liquidaCuota.Identificacion = IdentificacionTxt.Text;
                liquidaCuota.Nombre = NombreTxt.Text;
                liquidaCuota.NumLiquidacion =  NumLiquidacionTxt.Text;
                liquidaCuota.TipoAfiliacion = cmbTipoAfiliacion.Text;
                liquidaCuota.Salario = decimal.Parse(SalarioTxt.Text);
                liquidaCuota.ValorServicio = decimal.Parse(ValorServicioTxt.Text);
                liquidaCuota.CuotaModeradora = decimal.Parse(CuotaTxt.Text);
               
            }return liquidaCuota;
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            LiquidaCuota liquidaCuota = MapearPaciente();
         
            liquidaCuota.Fecha = FechaDTP.Value;
            liquidaCuota.Identificacion = IdentificacionTxt.Text;
            liquidaCuota.Nombre = NombreTxt.Text;
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
            string mensaje;
            try {
               
                string Identificacion = IdentificacionTxt.Text.Trim();
                liquidaCuota = service.BuscarId(Identificacion);
                if (liquidaCuota != null)
                {
                    IdentificacionTxt.Text = liquidaCuota.Identificacion;
                    NombreTxt.Text = liquidaCuota.Nombre;
                    NumLiquidacionTxt.Text = liquidaCuota.NumLiquidacion;
                    cmbTipoAfiliacion.Text = liquidaCuota.TipoAfiliacion;
                    SalarioTxt.Text = Convert.ToString(liquidaCuota.Salario);
                    ValorServicioTxt.Text = Convert.ToString(liquidaCuota.ValorServicio);
                    CuotaTxt.Text = Convert.ToString(liquidaCuota.CuotaModeradora);

                }
                else
                {
                    mensaje =($"La persona con Identificacion:  {Identificacion} No se encuentra Registrada");
                    Limpiar();

                }

            }catch (Exception error) {
                   mensaje = Convert.ToString(error);
            }
           
        }
    
    
    

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            LiquidaCuota liquidaCuota = MapearPaciente();
            string NumLiquidacion;
            NumLiquidacion = NumLiquidacionTxt.Text;
            RespuestaBusqueda respuestaBusqueda = service.Buscar(NumLiquidacion);
            if (liquidaCuota != null)
            { 
                liquidaCuota.ValorServicio = decimal.Parse(ValorServicioTxt.Text);
                liquidaCuota.LiquidarCuotaModeradora();
                CuotaTxt.Text = liquidaCuota.CuotaModeradora.ToString();
                string mensaje = service.Modificar(liquidaCuota);
                MessageBox.Show(mensaje);
                Limpiar();
            }

           
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            
            string identificacion = IdentificacionTxt.Text;
            string mensajeEliminar = service.Eliminar(identificacion);
            MessageBox.Show(mensajeEliminar);
            Limpiar();

        }
        private void Limpiar()
        {
            IdentificacionTxt.Text = "";
            NumLiquidacionTxt.Text = "";
            NombreTxt.Text ="";
            cmbTipoAfiliacion.Text = "";
            SalarioTxt.Text = "";
            ValorServicioTxt.Text = "";
            CuotaTxt.Text = "";
            IdentificacionTxt.Focus();

        }

       
    }
}
