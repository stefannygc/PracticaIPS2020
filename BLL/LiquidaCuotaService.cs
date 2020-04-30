using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LiquidaCuotaService
    {
        private LiquidaCuotaRepository liquidaCuotaRepository;
        public LiquidaCuotaService()
        {
            liquidaCuotaRepository = new LiquidaCuotaRepository();
        }

        public string Guardar(LiquidaCuota liquidaCuota)
        {
            try
            {
                if ((liquidaCuotaRepository.Buscar(liquidaCuota.NumLiquidacion)) == null)
                {
                    liquidaCuotaRepository.Guardar(liquidaCuota);
                    return $"se guardaron los datos sactifactoriamente ";
                }
                return $"No es posible registrar al paciente con numero de liquidacion {liquidaCuota.NumLiquidacion} ya se encuentra registrado";

            }
            catch (Exception ex)
            {

                return $"Error de datos " + ex.Message;
            }

        }

        public string Eliminar(string numLiquidacion)
        {
            try
            {
                if (liquidaCuotaRepository.Buscar(numLiquidacion) != null)
                {
                    liquidaCuotaRepository.Eliminar(numLiquidacion);
                    return $"se elimino la liquidacion numero: {numLiquidacion} correctamente";
                }
                return $"El numero de liquidacion no esta registrado en el sistema";
            }
            catch (Exception e)
            {
                return $"ERROR" + e.Message;
            }

        }
        public string Modificar(LiquidaCuota liquidaCuota)
        {
            try
            {
                if (liquidaCuotaRepository.Buscar(liquidaCuota.NumLiquidacion) != null)
                {

                    liquidaCuotaRepository.Modificar(liquidaCuota);
                    return $"el paciente con numero de liquidacion {liquidaCuota.NumLiquidacion} ha sido modificada satisfacatoriamente";
                }
                return $"La liquidacion {liquidaCuota.NumLiquidacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception ex)
            {

                return "Error de datos" + ex.Message;
            }

        }

        public RespuestaBusqueda Buscar(string NumLiquidacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                respuesta.liquidaCuota = liquidaCuotaRepository.Buscar(NumLiquidacion);
                if (respuesta.liquidaCuota != null)
                {
                    respuesta.Mensaje = "Se encontro un Paciente /n ";
                }
                else
                {
                    respuesta.Mensaje = "No hay un paciente asociado  al numero digitado, VERIFIQUE!/n ";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "ERROR: " + e.Message;
                respuesta.liquidaCuota = null;
                return respuesta;
            }
        }
            public RespuestaConsulta ConsultarConsulta()
            {
                RespuestaConsulta respuesta = new RespuestaConsulta();
                try
                {
                    respuesta.Error = false;
                    respuesta.liquidaCuotas = liquidaCuotaRepository.Consultar();
                    if (respuesta.liquidaCuotas != null)
                    {
                        respuesta.Mensaje = "LISTADO DE PACIENTES";
                    }
                    else
                    {
                        respuesta.Mensaje = "NO HAY DATOS";
                    }
                }
                catch (Exception e)
                {

                    respuesta.Error = true;
                    respuesta.Mensaje = $"ERROR" + e.Message;
                }
                return respuesta;
            }
        

            public LiquidaCuota BuscarId(string NumLiquidacion)
            {
                 try
                 {
                return liquidaCuotaRepository.Buscar(NumLiquidacion);
                 }
                  catch (Exception e)
                 {
                    string mensaje = " ERROR" + e.Message;
                      return null;
                 }

            }

        public int Totalizar()
        {
            return liquidaCuotaRepository.Totalizar();
        }
        public int TotalizarSubsidiado()
        {
            return liquidaCuotaRepository.TotalizarSubsidiado();
        }
        public int TotalizarContributivo()
        {
            return liquidaCuotaRepository.TotalizarContributivo();
        }
        public IList<LiquidaCuota> ListaContributivo()
        {
            return liquidaCuotaRepository.ListaContributivo();
        }
        public IList<LiquidaCuota> ListaSubsidiado()
        {
            return liquidaCuotaRepository.ListaSubsidiado();
        }



    }
    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public LiquidaCuota liquidaCuota { get; set; }
        public bool Error { get; set; }
    }
    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<LiquidaCuota> liquidaCuotas { get; set; }
        public bool Error { get; set; }
    }

   
}
