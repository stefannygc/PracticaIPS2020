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
        private IList<Paciente> pacientes;
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

        public IList<Paciente> Consultar()
        {
            pacientes = new List<Paciente>();
            string linea = string.Empty;
            pacientes.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);

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
            Paciente paciente;
            char delimiter = ';';
            string[] datos = linea.Split(delimiter);


            if (datos[2].ToLower() == "Contributivo")
            {
                paciente = new Contributivo();
            }
            else
            {
                paciente = new Subsidiado();
            }
            paciente.Identificacion = (datos[0]);
            paciente.Tarifa = decimal.Parse(datos[1]);
            paciente.NumLiquidacion = datos[2];
            paciente.TipoAfiliacion = datos[3];
            paciente.Salario = decimal.Parse(datos[4]);
            paciente.ValorServicio = decimal.Parse(datos[5]);
            paciente.CuotaModeradora = decimal.Parse(datos[6]);
            paciente.Tope = decimal.Parse(datos[7]);
            paciente.SALARIOMINIMO= decimal.Parse(datos[8]);
            return paciente;




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
        public int Totalizar()
        {
            return pacientes.Count();
        }
        public int TotalizarSubsidiado()
        {
            return pacientes.Where(p => p.TipoAfiliacion.Equals("Subsidiado")).Count();
        }
        public int TotalizarContributivo()
        {
            return pacientes.Where(p => p.TipoAfiliacion.Equals("Contributivo")).Count();
        }
        public IList<Paciente> ListaFiltrada(string Tipo)
        {
            return pacientes.Where(p => p.TipoAfiliacion.Equals(Tipo)).ToList();
        }
        public IList<Paciente> ListaSubsidiado()
        {
            return pacientes.Where(p => p.TipoAfiliacion.Equals("Subsidiado")).ToList();
        }
        public IList<Paciente> ListaContributivo()
        {
            return pacientes.Where(p => p.TipoAfiliacion.Equals("Contributivo")).ToList();
        }
    }
}

