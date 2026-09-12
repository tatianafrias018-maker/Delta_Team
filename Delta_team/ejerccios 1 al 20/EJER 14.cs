using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class EJER_14
    {
        public static void Main(string[] args)
        {
            const int TOTAL_ZONAS = 2;
            const int TOTAL_DIAS = 4;
            const int LIMITE_ANALISIS = 240;
            int totalGeneral = 0;
            // condicion de salida se detiene cuando zona pasa de TOTAL_ZONAS 
            for (int zona = 1; zona <= TOTAL_ZONAS; zona++)
            {
                int subtotalZona = 0;
                for (int dia = 1; dia <= TOTAL_DIAS; dia++)
                {
                    Console.WriteLine("zona" + zona + "dia" + dia + "ingrese articulos analizados");
                    int articulos = int.Parse(Console.ReadLine());
                    subtotalZona += articulos;

                }
                Console.WriteLine("subtotal Zona" + zona + ":" + subtotalZona + "articulos");
                if (subtotalZona > LIMITE_ANALISIS)
                {
                    Console.WriteLine("clasificacion zona" + zona + "Analisis alto");

                }
                else
                {
                    Console.WriteLine("Clasificacion Zona " + zona + ": ANALISIS BAJO");
                }

                totalGeneral += subtotalZona;

            }

            Console.WriteLine("Total General de Sucre: " + totalGeneral + " articulos");
        }
    }
}
