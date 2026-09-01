using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.Clase_ciclos
{
    public class ciclodo_while
    {
        public static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.WriteLine("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion != 2);
        }
    }
}
