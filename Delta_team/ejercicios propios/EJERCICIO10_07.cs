using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO10_07
    {
        public static void Main(string[] args)
        {
            const int TOTAL_LOTES = 4;
            const double UMBRAL = 120.0;
            int contador = 1;
            double suma = 0.0;
            
             while (contador <= TOTAL_LOTES)   
            {
                Console.Write("Ingrese las toneladas del lote " + contador + ": ");
                double toneladasLote = double.Parse(Console.ReadLine());
                suma = suma + toneladasLote;
                contador++;
            }
            double promedio = suma / TOTAL_LOTES;
            Console.WriteLine("");
            Console.WriteLine("Promedio de producción: " + promedio + " toneladas.");

            if (promedio >= UMBRAL)
            {

                Console.WriteLine("La producción promedio supera el umbral de " + UMBRAL + " toneladas.");
            }

            else

            {
                Console.WriteLine("La producción promedio no supera el umbral de " + UMBRAL + " toneladas.");
            }

        }
    }
}
