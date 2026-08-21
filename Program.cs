using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. 
            //El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados. Debe mostrar el nombre y el puntaje total de cada participante.        
            //Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.

            string nombre_participante;
            int punt_01;
            int punt_02;
            int punt_03;
            int punt_total;


                Console.Write("Ingrese el nombre del participante: ");

                nombre_participante = Console.ReadLine();

                while (nombre_participante != "FIN")
                {

                    Console.Write("Ingrese el puntaje del primer jurado: ");

                    punt_01 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese el puntaje del segundo jurado: ");

                    punt_02 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese el puntaje del tercer jurado: ");

                    punt_03 = Convert.ToInt32(Console.ReadLine());

                    punt_total = punt_01 + punt_02 + punt_03;

                    Console.WriteLine("El puntaje del participante " + nombre_participante + " es " + punt_total + ".");

                    Console.Write("Ingrese el nombre del participante: ");
                    nombre_participante = Console.ReadLine();
                }



            }
        }
    }