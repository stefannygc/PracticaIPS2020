using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class Contributivo: Paciente
    {
        public override void CalcularTarifa()
        {
            SALARIOMINIMO = 980657;
            if (Salario < SALARIOMINIMO * 2)
            {
                Tarifa = 0.15M;
                Tope= 250000;
            }
            if ((Salario >= SALARIOMINIMO * 2) && (Salario <= SALARIOMINIMO * 5))
            {
                Tarifa = 0.20M;
                Tope = 900000;
            }
            if (Salario > SALARIOMINIMO * 5)
            {
                Tarifa = 0.25M; Tope = 1500000;

            }
            else
            {
                Tarifa = 5M;
            }
        }
    }
    
}
