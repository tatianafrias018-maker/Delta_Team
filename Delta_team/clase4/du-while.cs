using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.clase4
{
    internal class du_while
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
            }
            while (opcion != 2);


        }
    }
}
