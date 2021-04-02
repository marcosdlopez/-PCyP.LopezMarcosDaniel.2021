using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Program
    {
        static void Main(string[] args)

        //1- Realizar un programa capaz de calcular el área y perímetro de un cuadrado, rectángulo y triángulo.Todos los datos necesarios para su funcionamiento se ingresan por teclado.//

        {
            {
                int lado, op, bas, alt, lad1, lad2, lad3;

                do
                {

                    List<int> datos = new List<int>(); ;

                    Console.WriteLine("1. Cuadrado");
                    Console.WriteLine("2. Rectángulo");
                    Console.WriteLine("3. Triángulo");

                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el lado del Cuadrado: ");
                            lado = Convert.ToInt32(Console.ReadLine());
                            datos.Add(lado);

                            Cuad c = new Cuad(datos);
                            Console.WriteLine("Área del Cuadrado " + c.AreaCal());
                            Console.WriteLine("Perímetro del Cuadrado  " + c.PerimetroCal());



                            break;
                        case 2:
                            Console.WriteLine("Altura  ");
                            alt = Convert.ToInt32(Console.ReadLine());
                            datos.Add(alt);
                            Console.WriteLine(" Base ");
                            bas = Convert.ToInt32(Console.ReadLine());
                            datos.Add(bas);


                            Rect r = new Rect(datos);

                            Console.WriteLine("El Perímetro del Rectángulo es " + r.PerimetroCal());
                            Console.WriteLine("El Área del Rectángulo es " + r.AreaCal());


                            break;
                        case 3:
                            Console.WriteLine("A continuacion ingrese los diferentes lados ");

                            Console.WriteLine("lado 1 ");
                            lad1 = Convert.ToInt32(Console.ReadLine());
                            datos.Add(lad1);

                            Console.WriteLine(" lado 2 ");
                            lad2 = Convert.ToInt32(Console.ReadLine());
                            datos.Add(lad2);

                            Console.WriteLine("lado 3 ");
                            lad3 = Convert.ToInt32(Console.ReadLine());
                            datos.Add(lad3);

                            Triang t = new Triang(datos);

                            Console.WriteLine("El Perímetro del Triángulo es " + t.AreaCal());
                            Console.WriteLine("El Área del Triángulo es " + t.PerimetroCal());


                            break;

                    }

                
    

