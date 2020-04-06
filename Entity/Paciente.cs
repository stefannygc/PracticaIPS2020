using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Paciente
    {
        public string Identificacion { get; set; }
        public string NumLiquidacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal Salario { get; set; }
        public double ValorServicio { get; set; }
        public double Tarifa { get; set; }
        public double CuotaModeradora { get; set; }
        const decimal SALARIOMINIMO = 980657;


        public void CalcularTarifa(Paciente paciente)
        {
            if (paciente.TipoAfiliacion.Equals("Contributivo"))
            {
                if (paciente.Salario < SALARIOMINIMO * 2)
                {
                    Tarifa = 0.15;
                    paciente.CuotaModeradora = paciente.ValorServicio * Tarifa;
                    double TOPE = 250000;
                    if (paciente.CuotaModeradora > TOPE)
                    {
                        paciente.CuotaModeradora = TOPE;
                    }
                    else
                    {
                        paciente.Tarifa = Tarifa;
                    }
                }
                if ((paciente.Salario >= SALARIOMINIMO * 2) && (paciente.Salario <= SALARIOMINIMO * 5))
                {
                    Tarifa = 0.20;
                    paciente.CuotaModeradora = paciente.ValorServicio * Tarifa;
                    double TOPE = 900000;
                    if (paciente.CuotaModeradora > TOPE)
                    {
                        paciente.CuotaModeradora = TOPE;
                    }
                    else
                    {
                        paciente.Tarifa = Tarifa;
                    }
                }
                if (paciente.Salario > SALARIOMINIMO * 5)
                {
                    Tarifa = 0.25;
                    paciente.CuotaModeradora = paciente.ValorServicio * Tarifa;
                    double TOPE = 1500000;
                    if (paciente.CuotaModeradora > TOPE)
                    {
                        paciente.CuotaModeradora = TOPE;
                    }
                    else
                    {
                        paciente.Tarifa = Tarifa;
                    }
                }
            }
            else
            {
                double Tarifa = 5;

                if (paciente.TipoAfiliacion.Equals("Subsidiado"))
                {
                    paciente.CuotaModeradora = paciente.ValorServicio * Tarifa/100;
                    double TOPE = 200000;
                    if (paciente.CuotaModeradora> TOPE)
                    {
                        paciente.CuotaModeradora = TOPE;
                    }
                    else 
                    {
                        paciente.Tarifa = Tarifa;
                    }

                } 
                
            }
        }
      

    }

}
    
