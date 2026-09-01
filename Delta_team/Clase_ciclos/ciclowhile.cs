using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.Clase_ciclos
{
    public class ciclowhile
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            while (contador <=5)
            {

                Console.WriteLine("Contador: " + contador);
                contador++;

            }

            Console.WriteLine("El numero no esta en el rango");
        }
    }
}
