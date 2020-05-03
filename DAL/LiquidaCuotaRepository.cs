using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidaCuotaRepository
    {
        private string ruta = @"LiquidaCuota.txt";
        private IList<LiquidaCuota> liquidaCuotas;
        public LiquidaCuotaRepository()
        {
            liquidaCuotas = new List<LiquidaCuota>();
        }
        public void Guardar(LiquidaCuota liquidaCuota)
        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(liquidaCuota.ToString());
            writer.Close();
            fileStream.Close();
        }

        public IList<LiquidaCuota> Consultar()
        {
            liquidaCuotas = new List<LiquidaCuota>();
            string linea = string.Empty;
            liquidaCuotas.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);

            while ((linea = streamReader.ReadLine()) != null)
            {
                LiquidaCuota liquidaCuota = MapearPaciente(linea);
                liquidaCuotas.Add(liquidaCuota);
            }
            fileStream.Close();
            streamReader.Close();
            return liquidaCuotas;
        }
        private static LiquidaCuota MapearPaciente(string linea)
        {
            LiquidaCuota liquidaCuota;
            char delimiter = ';';
            string[] datos = linea.Split(delimiter);


            if (datos[2].ToLower() == "Contributivo")
            {
                liquidaCuota= new Contributivo();
            }
            else
            {
                liquidaCuota = new Subsidiado();
            }
            liquidaCuota.Fecha = DateTime.Parse(datos[0]);
            liquidaCuota.Identificacion = (datos[1]);
            liquidaCuota.Nombre = datos[2];
            liquidaCuota.Tarifa = decimal.Parse(datos[3]);
            liquidaCuota.NumLiquidacion = datos[4];
            liquidaCuota.TipoAfiliacion = datos[5];
            liquidaCuota.Salario = decimal.Parse(datos[6]);
            liquidaCuota.ValorServicio = decimal.Parse(datos[7]);
            liquidaCuota.CuotaModeradora = decimal.Parse(datos[8]);
            liquidaCuota.Tope = decimal.Parse(datos[9]);
            liquidaCuota.SALARIOMINIMO= decimal.Parse(datos[10]);
            return liquidaCuota;


        }
           
      
        public void Eliminar( string identificacion) 
        {
            liquidaCuotas.Clear();
            liquidaCuotas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidaCuotas)
            {
                if (item.Identificacion != identificacion)
                {
                    Guardar(item);
                }
            }

        }
        public void Modificar(LiquidaCuota paciente)
        {
            liquidaCuotas.Clear();
            liquidaCuotas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidaCuotas)
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
        public LiquidaCuota Buscar(string identificacion)
        {
            liquidaCuotas.Clear();
            liquidaCuotas = Consultar();
          
            foreach (var item in liquidaCuotas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        public int Totalizar()
        {
            return liquidaCuotas.Count();
        }
        public int TotalizarSubsidiado()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion.Equals("Subsidiado")).Count();
        }
        public int TotalizarContributivo()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion.Equals("Contributivo")).Count();
        }
        public IList<LiquidaCuota> ListaFiltrada(string Tipo)
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion.Equals(Tipo)).ToList();
        }
        public IList<LiquidaCuota> ListaSubsidiado()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion.Equals("Subsidiado")).ToList();
        }
        public IList<LiquidaCuota> ListaContributivo()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion.Equals("Contributivo")).ToList();
        } 
        public decimal TotalCuotaModeradoras()
        {
            return liquidaCuotas.Sum(p => p.CuotaModeradora);
        }
        public decimal SumaLiquidacionSubsidiado()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion == "Subsidiado").Sum(p => p.CuotaModeradora);
        }
        public decimal SumaLiquidacionContributivo()
        {
            return liquidaCuotas.Where(p => p.TipoAfiliacion == "Contributivo").Sum(p => p.CuotaModeradora);
        }
        


    }

}

