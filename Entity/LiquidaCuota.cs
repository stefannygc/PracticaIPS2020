using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidaCuota
    {
        public DateTime Fecha { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public decimal Tarifa { get; set; }
        public string NumLiquidacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal Salario { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal CuotaModeradora { get; set; }
        public decimal Tope { get; set; }
       public  decimal SALARIOMINIMO {get; set;}
        
        public abstract void CalcularTarifa();
        public decimal CalcularCuotaModeradora()
        {
            CuotaModeradora = ValorServicio * Tarifa;
            return CuotaModeradora;
        }
        public void LiquidarCuotaModeradora()
        {

            CalcularTarifa();
            CalcularCuotaModeradora();
            ValorMax();
      
        }

        public void ValorMax()
        {

            if (CuotaModeradora > Tope)
            {
                CuotaModeradora = Tope;
            }
            else
            {
                Tarifa = Tarifa;
            }


        }
        public override string ToString()
        {
            return $"{Fecha};{Identificacion};{Nombre};{Tarifa};{NumLiquidacion};{TipoAfiliacion};{Salario};{ValorServicio};{CuotaModeradora};{Tope};{SALARIOMINIMO}";
        }

    }
}