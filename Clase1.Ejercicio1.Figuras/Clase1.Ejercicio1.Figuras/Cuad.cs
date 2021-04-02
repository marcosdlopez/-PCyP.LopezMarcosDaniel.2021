using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Cuad : Fg
    {

        public Cuad(List<int> lados)
        {
            this.lados = lados;
        }


        public override double PerimetroCal()
        {
            double resul = lados[0] * 4;
            return resul;
        }

        public override double AreaCal()
        {
            double resul = lados[0] * lados[0];
            return resul;
        }



    }
}