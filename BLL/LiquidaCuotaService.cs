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
                if ((liquidaCuotaRepository.Buscar(liquidaCuota.Identificacion)) == null)
                {
                    liquidaCuotaRepository.Guardar(liquidaCuota);
                    return $"se guardaron los datos sactifactoriamente ";
                }
                return $"No es posible registrar al paciente con  {liquidaCuota.Identificacion} ya se encuentra registrado";

            }
            catch (Exception ex)
            {

                return $"Error de datos " + ex.Message;
            }

        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (liquidaCuotaRepository.Buscar(identificacion) != null)
                {
                    liquidaCuotaRepository.Eliminar(identificacion);
                    return $"se elimino la identificacion numero: {identificacion} correctamente";
                }
                return $"El numero de identificacion no esta registrado en el sistema";
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
                if (liquidaCuotaRepository.Buscar(liquidaCuota.Identificacion) != null)
                {

                    liquidaCuotaRepository.Modificar(liquidaCuota);
                    return $"el paciente con numero de identificacion {liquidaCuota.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {liquidaCuota.Identificacion} no se encuentra registrada por favor verifique los datos";
                    
            }
            catch (Exception ex)
            {

                return "Error de datos" + ex.Message;
            }

        }

        public RespuestaBusqueda Buscar(string Identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                respuesta.liquidaCuota = liquidaCuotaRepository.Buscar(Identificacion);
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
                        respuesta.Mensaje = "LISTADO DE LIQUIDACIONES";
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
        

            public LiquidaCuota BuscarId(string Identificacion)
            {
                 try
                 {
                return liquidaCuotaRepository.Buscar(Identificacion);
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
        public decimal TotalCuotaModeradoras()
        {
            return liquidaCuotaRepository.TotalCuotaModeradoras();
        }
        public decimal SumaLiquidacionSubsidiado()
        {
            return liquidaCuotaRepository.SumaLiquidacionSubsidiado();
        }
        public decimal SumaLiquidacionContributivo()
        {
            return liquidaCuotaRepository.SumaLiquidacionContributivo();
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
