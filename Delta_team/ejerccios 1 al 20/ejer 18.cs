using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    internal class ejer_18
    {
       public static void Main(string[]args)
        {

            const int ANO_INICIO = 2018;
            const int DURACION_ANOS = 10;
            const int FRECUENCIA_HITO = 5;

            int totalParcelas = 0;
            int hitosConmemorados = 0;

            // Condicion de salida: Se detiene al superar el lapso de 10 anos.
            for (int i = 1; i <= DURACION_ANOS; i++)
            {
                int anoActual = ANO_INICIO + i - 1;
                Console.Write("Ano " + anoActual + " (Serie #" + i + ") - Ingrese parcelas verificadas: ");
                int parcelas = int.Parse(Console.ReadLine());
                totalParcelas += parcelas;

                if (i % FRECUENCIA_HITO == 0)
                {
                    Console.Write("ano hito ,hubo acto conmemorativo?(1=si,2=no)");
                    int acto=int.Parse(Console.ReadLine());
                     if (acto == 1)
                    {
                        Console.WriteLine("hito conmemorado registrado");
                        hitosConmemorados++;
                    }
                    else
                    {
                        Console.WriteLine("hito sin acto conmemorativo");
                    }
                }


            }
            Console.WriteLine("total parcelas verificadas" + totalParcelas);
            Console.WriteLine(" hitos conmemorados " + hitosConmemorados);
        }
    }
}