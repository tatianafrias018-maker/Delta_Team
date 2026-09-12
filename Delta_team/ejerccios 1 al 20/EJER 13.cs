using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class EJER_13
    {
        public static void Main(string[] args)
        {
            const double META_KILOMETROS = 1800.0;
            double acumulado = 0;
            int periodos = 0;
            //condicion de salida se detiene cuando alcanza o supera META_KILOMETROS
            while (acumulado < META_KILOMETROS)
            {

                periodos++;
                Console.WriteLine("ingrese el avance en km del periodo " + periodos);
                double avance = double.Parse(Console.ReadLine());
                if (avance == 0)
                {
                    Console.WriteLine("ADVERTENCIA el periodo fue no muy productivo");

                }
                else
                {
                    acumulado += avance;

                }
                double saldo = META_KILOMETROS - acumulado;
                if (saldo > 0) saldo = 0;

                Console.WriteLine("acumulado actual" + acumulado + "saldo pendiente" + saldo);


            }
            double excedente = acumulado - META_KILOMETROS;
            Console.WriteLine(" Meta alcanzada");
            Console.WriteLine("total acumulado" + acumulado);
            Console.WriteLine("excedente " + excedente);
            Console.WriteLine("periodos utilizados" + periodos);
        }



        
    }
}
