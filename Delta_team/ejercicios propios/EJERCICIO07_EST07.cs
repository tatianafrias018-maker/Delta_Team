using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO07_EST07
    {
        public static void Main(string[] args)
        {
            const int TOTAL_BARRIOS = 4;
            const int UMBRAL_ALTO = 500;
            const int UMBRAL_MEDIO = 200;
            int alto = 0;
            int medio = 0;
            int bajo = 0;

            for (int i = 1; i <= TOTAL_BARRIOS; i++)

            {
                Console.WriteLine("INGRESE LOS KG RECICLADOS BARRIO: " + i + ": ");
                int kg = int.Parse(Console.ReadLine());

                if (kg > UMBRAL_ALTO)
                {
                    Console.WriteLine("Acopio alto");
                    alto++;
                }

                else if (kg > UMBRAL_MEDIO)

                {
                    Console.WriteLine("Acopio medio");
                    medio++;
                }

                else

                {
                    Console.WriteLine("Acopio bajo");
                    bajo++;
                }
            }
            Console.WriteLine(""); 
            Console.WriteLine("***RESULTADOS FINALES***");
            Console.WriteLine("Acopios altos: " + alto + " barrios");
            Console.WriteLine("Acopios medios: " + medio + " barrios");
            Console.WriteLine("Acopios bajos: " + bajo + " barrios");
        }   
    }
}
