using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
     public class ejer_16
    {
        public static void Main (string[] args) 
        {
            const int TOTAL_FOCOS = 9;
            const double TRAMO_ALTO = 1500.0;
            const double TRAMO_MEDIO = 500.0;
            const double PORCENTAJE_ALTO = 0.20;
            const double PORCENTAJE_MEDIO = 0.10;

            double incentivoTotal = 0;
            int contObservaciones = 0;
            //condicion de salida se detiene cuando i supera TOTAL_FOCOS
            for(int i=1;i<= TOTAL_FOCOS;i++)

            {
                Console.Write("ingrese hectareas del foco de calor" + i);
                double hectareas =double.Parse(Console.ReadLine());
                double incentivo = 0;
                if (hectareas >= TRAMO_ALTO)
                {
                    incentivo = hectareas * PORCENTAJE_ALTO;
                    Console.WriteLine("Incentivo asignado (20%): " + incentivo);
                }
                else if (hectareas >= TRAMO_MEDIO)
                {
                    incentivo = hectareas * PORCENTAJE_MEDIO;
                    Console.WriteLine("Incentivo asignado (10%): " + incentivo);
                }
                else
                {
                    Console.WriteLine("sin incentivo, se registra observacion");
                    contObservaciones++;

                }
                incentivoTotal+= incentivo; 

            }
            Console.WriteLine("incentivo total del periodo"+incentivoTotal);
            Console.WriteLine("cantidad de onservaciones "+contObservaciones);
        }



    }
}
