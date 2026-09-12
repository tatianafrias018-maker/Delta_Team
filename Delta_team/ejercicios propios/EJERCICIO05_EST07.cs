using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO05_EST07
    {
        public static void Main(string[] args)
        {
            const int TOTAL_TALLERES = 6;
            const int UMBRAL = 40;
            int cumplen = 0;
            int noCumplen = 0;

            for (int i = 1; i <= TOTAL_TALLERES; i++) 

            {
                Console.WriteLine("Ingrese participantes del taller", i, ": "); 
                int participantes = int.Parse(Console.ReadLine());

                if (participantes >= UMBRAL)
                
                {
                    Console.WriteLine("Cumplen");
                    cumplen = cumplen + 1;
                }

                else

                {
                    Console.WriteLine("No cumple");
                    noCumplen = noCumplen + 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("***INFORME***");
            Console.WriteLine("Talleres que cumplen: ", cumplen);
            Console.WriteLine("Talleres que no cumplen: ", noCumplen);
        }
    }
}
