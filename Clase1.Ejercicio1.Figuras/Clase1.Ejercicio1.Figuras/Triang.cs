using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Triang : Fg
    {
        public Triang(List<int> lados)
        {
            this.lados = lados;
        }


        public override double PerimetroCal()
        {
            double resultado = lados[0] + lados[1] + lados[2];
            return resultado;
        }

        public override double AreaCal()
        {
            double resultado = 0.5 * (lados[0] + lados[1] + lados[2]);
            return resultado;
        }
    }
}
    
