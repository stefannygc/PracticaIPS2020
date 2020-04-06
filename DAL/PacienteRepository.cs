using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PacienteRepository
    {
        private string ruta = @"Paciente.txt";
        private List<Paciente> pacientes;
        public PacienteRepository()
        {
            pacientes = new List<Paciente>();
        }
        public void Guardar(Paciente paciente)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(paciente.ToString());
            writer.Close();
            fileStream.Close();
        }

        public List<Paciente> Consultar()
        {
            pacientes.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = streamReader.ReadLine()) != null)
            {
                Paciente paciente = MapearPaciente(linea);
                pacientes.Add(paciente);
            }
            fileStream.Close();
            streamReader.Close();
            return pacientes;
        }
            private static Paciente MapearPaciente(string linea)
            {
                Paciente paciente = new Paciente();
                string[] datos = linea.Split(';');
                paciente.Identificacion = datos[0];
                paciente.NumLiquidacion = datos[1];
                paciente.TipoAfiliacion = datos[2];
                paciente.Salario = decimal.Parse(datos[3]);
                paciente.ValorServicio = double.Parse(datos[4]);
                paciente.CuotaModeradora = Convert.ToDouble(datos[5]);
                return paciente;
            }
            
        

        public void Eliminar( string identificacion) 
        {
            pacientes.Clear();
            pacientes = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in pacientes)
            {
                if (item.Identificacion != identificacion)
                {
                    Guardar(item);
                }
            }

        }
        public void Modificar(Paciente paciente)
        {
            pacientes.Clear();
            pacientes = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in pacientes)
            {
                if (item.Identificacion != paciente.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(paciente);
                }
            }
        }
        public Paciente Buscar(string identificacion)
        {
            pacientes.Clear();
            pacientes = Consultar();
            Paciente paciente = new Paciente();
            foreach (var item in pacientes)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

