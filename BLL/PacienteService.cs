using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PacienteService
    {
        private PacienteRepository pacienteRepository;
        public PacienteService()
        {
            pacienteRepository = new PacienteRepository();
        }

        public string Guardar(Paciente paciente)
        {
            try
            {
                if ((pacienteRepository.Buscar(paciente.NumLiquidacion)) == null)
                {
                    pacienteRepository.Guardar(paciente);
                    return $"se guardaron los datos sactifactoriamente ";
                }
                return $"No es posible registrar al paciente con numero de liquidacion {paciente.NumLiquidacion} ya se encuentra registrado";

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
                if (pacienteRepository.Buscar(numLiquidacion) != null)
                {
                    pacienteRepository.Eliminar(numLiquidacion);
                    return $"se elimino la liquidacion numero: {numLiquidacion} correctamente";
                }
                return $"El numero de liquidacion no esta registrado en el sistema";
            }
            catch (Exception e)
            {
                return $"ERROR" + e.Message;
            }

        }
        public string Modificar(Paciente paciente)
        {
            try
            {
                if (pacienteRepository.Buscar(paciente.NumLiquidacion) != null)
                {

                    pacienteRepository.Modificar(paciente);
                    return $"el paciente con numero de liquidacion {paciente.NumLiquidacion} ha sido modificada satisfacatoriamente";
                }
                return $"La liquidacion {paciente.NumLiquidacion} no se encuentra registrada por favor verifique los datos";

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
                respuesta.paciente = pacienteRepository.Buscar(NumLiquidacion);
                if (respuesta.paciente != null)
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
                respuesta.paciente = null;
                return respuesta;
            }
        }
            public RespuestaConsulta ConsultarConsulta()
            {
                RespuestaConsulta respuesta = new RespuestaConsulta();
                try
                {
                    respuesta.Error = false;
                    respuesta.pacientes = pacienteRepository.Consultar();
                    if (respuesta.pacientes != null)
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
        

            public Paciente BuscarId(string NumLiquidacion)
            {
                 try
                 {
                return pacienteRepository.Buscar(NumLiquidacion);
                 }
                  catch (Exception e)
                 {
                    string mensaje = " ERROR" + e.Message;
                      return null;
                 }

            }


        
        public class RespuestaBusqueda
        {
            public string Mensaje { get; set; }
            public Paciente paciente { get; set; }
            public bool Error { get; set; }
        }
        public class RespuestaConsulta
        {
            public string Mensaje { get; set; }
            public List<Paciente>pacientes { get; set; }
            public bool Error { get; set; }
        }
    }
}
