using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO09_EST07
    {
        public static void Main(string[] args)
        {
            const int TOTAL_TRAMITES = 8;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int tramitesMaximos = 0;
            int tramitesMinimos = 0;

            for (int i = 1; i <= TOTAL_TRAMITES; i++)

            {

                Console.Write("Ingrese los minutos en cada tramite ", i, ": ");
                int minutos = int.Parse(Console.ReadLine());

                if (minutos > maximo)

                {
                    maximo = minutos;
                    tramitesMinimos = i;
                }

                if (minutos < minimo)

                {
                    minimo = minutos;
                    tramitesMaximos = i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("***RESULTADOS***");
            Console.WriteLine("El tramite mas lento: " + tramitesMinimos + " con " + maximo + " minutos.");
            Console.WriteLine("El tramite mas rapido: " + tramitesMaximos + " con " + minimo + " minutos.");

        }
    }


}
