using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer_9
    {
        public static void Main(string[] args)
        {
            const int TOTAL_CONJUNTOS = 7;
            int maxDescargas = 0;
            int minDescargas = 0;
            int numConjuntoMax = 1;
            int numConjuntoMin = 1;
            //se detiene cuando i supera el total de conjuntos_conjuntos
            for (int i = 1; i <= TOTAL_CONJUNTOS; i++)
            {
                Console.WriteLine("ingrese las descargas registradas del conjunto" + i + ":");
                int descargas = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maxDescargas = descargas;
                    minDescargas = descargas;
                    numConjuntoMax = i;
                    numConjuntoMin = i;

                }
                else
                {
                    if (descargas > maxDescargas)
                    {
                        maxDescargas = descargas;
                        numConjuntoMax = i;
                    }
                    if (descargas < minDescargas)
                    {
                        minDescargas = descargas;
                        numConjuntoMin = i;
                    }
                }

            }
            Console.WriteLine("maximo de descargas" + maxDescargas + " del conjunto " + numConjuntoMax);
            Console.WriteLine("minimo de descargas" + minDescargas + " del conjunto " + numConjuntoMin);


        }
    }
}