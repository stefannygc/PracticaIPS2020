using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class Subsidiado: Paciente
    {
        public override void CalcularTarifa()
        {
            Tarifa = 0.05M;
            Tope = 200000;
        }
    }
}
