using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Manejo_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            


            ManejoDic Manejo = new ManejoDic();

            Manejo.ValoresAlt("Mariana", "58251425");

            Manejo.EncontrarLlave("Juan");

            Console.WriteLine(Manejo.EncontrarLlave("pedro"));

            Manejo.Mostrar();


            Console.ReadLine();

        }
    }
}
    
 