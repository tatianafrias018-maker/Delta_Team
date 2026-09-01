using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.clase4
{
    public class ciclo
    {
        public static void Main(string[] args)
        {

            int contador = 1;

            while (contador <= 5)

            {
               Console.WriteLine("Vuelta numero " + contador);
                contador++;
            }

            Console.WriteLine("El ciclo termino.");

        }

    }

}
