using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Manejo_Diccionario
{
    class ManejoDic
    {
        //CREAMOS EL DICCIONARIO 

        Dictionary<string, string> values = new Dictionary<string, string>();

        public ManejoDic()
        {

            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");
        }

        public string EncontrarLlave(string Nombres)
        {
            string suValor = "";

            if (values.TryGetValue(Nombres, out suValor))
            {
                return suValor;
            }
            else
            {
                return "NO CONTIENE LLAVE";
            }
        }

        public void LlaveBusqueda(String Nombres)
        {
            if (values.ContainsKey(Nombres))
            {
                Console.WriteLine(values[Nombres]);
            }
            else
            {
                Console.WriteLine("No existe llave");
            }
        }

        public void ValoresAlt(string indice, string suValor)
        {
            if (values.ContainsKey(indice))
            {
                values[indice] = suValor;
                Console.WriteLine("Telefono de {0} es {1}", suValor, indice);
            }
            else
            {
                Console.WriteLine("No Existe Indice");




            }
        }
        public void Mostrar()
        {

            foreach (var recorrido in values)
            {

                Console.WriteLine(recorrido.Key + "," + recorrido.Value);


            }

        }
    }
}
