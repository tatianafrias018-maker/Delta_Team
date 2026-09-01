using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.clase4
{
    internal class duwhile
    {
        public static void Main(string[] args)
        {
            int edad;
            do
            {
                Console.WriteLine("ingrese su edad del 1 al 120");
                edad = int.Parse(Console.ReadLine());
                if (edad < 1 || edad > 120)
                {
                    Console.WriteLine("edad invalida,intente de nuevo");
                }
            }
            while (edad < 1 || edad > 120);
            Console.WriteLine("edad registrada:"+ edad);
        }
    }
}
