using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team
{
    public class ejer5
    {
        public static void Main(string[] args)
        {
            const int TOTAL_TRANSACCIONES = 5;
            const double UMBRAL_MONTO = 800.0;
            int contCumplen = 0;
            int NoCumple = 0;
            //condicion de salida se detiene cuando el indice i supera TOTAL_TRANSACCIONES(5)
            for (int i = 1; i <= TOTAL_TRANSACCIONES; i++)
            {
                Console.WriteLine("ingrese el monto de la transaccion QR" + i);
                double monto = double.Parse(Console.ReadLine());
                if (monto >= UMBRAL_MONTO)
                {
                    Console.WriteLine("la transaccion cumple con el umbral de monto");
                    contCumplen++;
                }
                else
                {
                    Console.WriteLine("la transaccion no cumple con el umbral de monto");
                    NoCumple++;
                }
               
            }
            Console.WriteLine("transacciones que cumplen con el umbral de monto" + contCumplen);
            Console.WriteLine("transacciones que no cumplen con el umbral de monto" + NoCumple);
        }
    }
}
