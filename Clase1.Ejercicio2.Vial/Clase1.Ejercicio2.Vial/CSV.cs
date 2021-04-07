using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{
    class CSV
    {
        private string[] line;

        public CSV() { }

        public string[] Archivo()
        {
            line = File.ReadAllLines( @"C: \Users\Mark\Documents\GitHub\-PCyP.LopezMarcosDaniel.2021\Clase1.Ejercicio2.Vial\Clase1.Ejercicio2.Vial");

            return line;
        }


        public void Ver()
        {


            foreach (var i in Archivo())
            {
                var linea = i.Split(',');

                Console.WriteLine($"{linea[0]}{"  "}{linea[1]}{"  "}{linea[2]}{"  "}{linea[3]}{"  "}{linea[4]}");
            }

        }

    }



}
