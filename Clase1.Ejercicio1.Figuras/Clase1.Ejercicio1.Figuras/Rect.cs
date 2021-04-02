using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Rect : Fg
    {
        public Rect(List<int> lados)
        {
            this.lados = lados;
        }


        public override double PerimetroCal()
        {
            double resultado = lados[0] * 2 + lados[1] * 2;
            return resultado;
        }

        public override double AreaCal()
        {
            double resultado = lados[0] * lados[1];
            return resultado;
        }
    }
}