using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO03_EST07
    {
        public static void Main(string[] args)

        {
            const int MINIMO = 0;  
            const int MAXIMO = 80;
            int metros;

            do 
            {
                Console.WriteLine("Ingrese metros de retroceso del glaciar (0 a 80):");
                metros = int.Parse(Console.ReadLine());

                if (metros < MINIMO || metros > MAXIMO)
                {

                    Console.WriteLine("Valor invalido. Intente de nuevo.");

                }
            } while (metros < MINIMO || metros > MAXIMO);

            Console.WriteLine("");
            Console.WriteLine("Valor valido: " + metros+ " metros");
        }
    }
}
