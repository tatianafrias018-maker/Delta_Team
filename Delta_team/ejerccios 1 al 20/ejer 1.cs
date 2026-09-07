using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
     public class ejer_1
    {
        public static void Main(string[] args)
        {
            const int TOTAL_ESCUELAS = 9;
            int contador = 1;
            while(contador <= TOTAL_ESCUELAS)
            {
                Console.WriteLine(" escuela registrada numero" + contador);
                contador++;
               
            }
            Console.WriteLine("total de escuelas procesadas"+TOTAL_ESCUELAS);   

        }


    }
}
