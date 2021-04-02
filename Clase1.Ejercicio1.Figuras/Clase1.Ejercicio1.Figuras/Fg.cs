using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
 
    public abstract class Fg
    {


        protected List<int> lados { get; set; }

        public abstract double AreaCal();
        public abstract double PerimetroCal();

    }
}