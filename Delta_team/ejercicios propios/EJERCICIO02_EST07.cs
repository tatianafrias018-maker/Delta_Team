using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO02_EST07
    {
        public static void Main(string[] args)
        {
            const int TOTAL_PUNTOS = 6;
            const int META = 100;
            int suma = 0;
            int contador = 1;

            while(contador <= TOTAL_PUNTOS)
            {
                Console.WriteLine("Ingrese nivel de mercurio del punto " + contador + " (0 a 100):");
                int nivel= int.Parse(Console.ReadLine());
                suma = suma + nivel;
                contador++;

            }

            Console.WriteLine("");
            Console.WriteLine("Total acumulado de mercuio: " + suma + " microgramos por litro");

            if (suma >= META)

            {
                Console.WriteLine("Meta alcanzada");

            }

            else

            {
                Console.WriteLine("Meta no alcanzada");
            }
        }
    }
}
