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
                if ((pacienteRepository.Buscar(paciente.Identificacion)) == null)
                {
                   pacienteRepository.Guardar(paciente);
                    return $"se guardaron los datos sactifactoriamente ";
                }
                return $"No es posible registrar al paciente con Identificacion {paciente.Identificacion} ya se encuentra registrada ";

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
                if (pacienteRepository.Buscar(identificacion) != null)
                {
                    pacienteRepository.Eliminar(identificacion);
                    return $"se elimino la identificacion numero: {identificacion} correctamente";
                }
                return $"El numero de identificacion no esta registrado en el sistema";
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
                if (pacienteRepository.Buscar(paciente.Identificacion) != null)
                {

                    pacienteRepository.Modificar(paciente);
                    return $"el paciente con identificacion {paciente.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {paciente.Identificacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception ex)
            {

                return "Error de datos" + ex.Message;
            }

        }
        public List<Paciente> Consultar()
        {
            return pacienteRepository.Consultar();
        }

        public Paciente Buscar(string identificacion)
        {
            return pacienteRepository.Buscar(identificacion);

        }

    }
}
