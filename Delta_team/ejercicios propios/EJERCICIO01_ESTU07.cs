using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO01_ESTU07
    {
        public static void Main(string[] args)

        {
            const int AVENIDAS_MONITOREADAS = 4;
            int contador = 1; 

            while (contador <= AVENIDAS_MONITOREADAS)
            {
                Console.WriteLine("Avenida: " + contador + " monitoreada");
                contador++;
            }

            Console.WriteLine("Total procesado: " + AVENIDAS_MONITOREADAS + " avenidas");
        }
    }
}