using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.Clase_ciclos
{
    public class ciclodo_if_while
    {
        public static void Main(string[] args)
        {
            int edad;

            do
            {
                Console.WriteLine("Ingrese su edad (1 a 120):");
                edad = int.Parse(Console.ReadLine());
                
                if (edad < 1 || edad > 120)
                {

                    Console.WriteLine("Edad invalida. Intente de nuevo.");
                }
            }
            while (edad < 1 || edad > 120);

            Console.WriteLine("Edad registrada: " + edad);
        }
    }
}
