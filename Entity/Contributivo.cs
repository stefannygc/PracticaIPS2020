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
            SALARIOMINIMO = 877803;
            if (Salario < (2 * SALARIOMINIMO))
            {
                Tarifa = 0.15M; Tope = 250000;

            }

            if ((Salario >= 2 * SALARIOMINIMO) && (Salario<= 5 * SALARIOMINIMO))
            {
                Tarifa = 0.20M; Tope = 900000;


            }
            if (Salario > (5 * SALARIOMINIMO))
            {
                Tarifa = 0.25M; Tope = 1500000;

            }
        }
    }
    
}
