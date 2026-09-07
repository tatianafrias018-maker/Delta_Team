using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejr2
    {
        public static void Main(string[] args)
        {
            const int TOTAL_COMUNIDADES = 5;
            const double META_VELOCIDAD = 300.0;
            int contador = 1;
            double sumaVelocidad = 0;
            while (contador <= TOTAL_COMUNIDADES)
            {
                Console.WriteLine("ingrese la velocidad de bajada para la comunidad" + contador);
                double velocidad=double.Parse(Console.ReadLine());
                sumaVelocidad += velocidad;
                contador++;
            }
            Console.WriteLine("velociada total acumulada" + sumaVelocidad);
            if (sumaVelocidad >= META_VELOCIDAD)
            {
                Console.WriteLine("meta alcanzada o superada"+META_VELOCIDAD);
            }
            else
            {
                Console.WriteLine("meta no alcanzada");
            }
        }
    }
}
