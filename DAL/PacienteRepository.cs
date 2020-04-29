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
             {     Paciente paciente ;
                string[] datos = linea.Split(';');

                if (datos[2].ToLower() == "subsidiado")
                {
                    paciente = new Subsidiado();
                }
                else
                {
                    paciente = new Contributivo();
                }
                paciente.Identificacion = (datos[0]); 
                paciente.Tarifa = decimal.Parse(datos[1]);
                paciente.NumLiquidacion = datos[2];
                paciente.TipoAfiliacion = datos[3];
                paciente.Salario = decimal.Parse(datos[4]);
                paciente.ValorServicio = decimal.Parse(datos[5]);
                paciente.CuotaModeradora = decimal.Parse(datos[6]);
                pacientes.Add(paciente);
            }
            fileStream.Close();
            streamReader.Close();
            return pacientes;
        }
        


        public void Eliminar( string numLiquidacion) 
        {
            pacientes.Clear();
            pacientes = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in pacientes)
            {
                if (item.NumLiquidacion != numLiquidacion)
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
                if (item.NumLiquidacion != paciente.NumLiquidacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(paciente);
                }
            }
        }
        public Paciente Buscar(string numLiquidacion)
        {
            pacientes.Clear();
            pacientes = Consultar();
          
            foreach (var item in pacientes)
            {
                if (item.NumLiquidacion.Equals(numLiquidacion))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

