using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    internal class ejer7
    {
      public static void Main(string[] args)
        {
            //rangos de medicion de congestion vial preestablecidos
            const int TOTAL_CRUCES = 9;
            const int LIMITE_CONGESTIONADO = 90;
            const int LIMITE_NORMAL = 45;
            int contCongestionado= 0;
            int contNormal= 0;
            int contFluido= 0;
            for(int i=1; i<=TOTAL_CRUCES; i++)
            {
                Console.WriteLine("ingrese los segundos de espera para el cruce" + i);
                int espera = int.Parse(Console.ReadLine());
                if(espera>=LIMITE_CONGESTIONADO )
                {
                    Console.WriteLine("el cruce esta congestionado");
                    contCongestionado++;
                }
                else if(espera>=LIMITE_NORMAL)
                {
                    Console.WriteLine("el cruce esta normal");
                    contNormal++;
                }
                else
                {
                    Console.WriteLine("el cruce esta fluido");
                    contFluido++;
                }
            }
            Console.WriteLine("total de cruces congestionados" + contCongestionado);
            Console.WriteLine("total de cruces normales" + contNormal);
            Console.WriteLine("total de cruces fluidos" + contFluido);
        }
    }
}
