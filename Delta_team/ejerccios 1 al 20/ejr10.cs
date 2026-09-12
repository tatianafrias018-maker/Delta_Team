using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.clase4
{
    public class ejr10
    {
        public static void Main(string[] args)
        {
            const int TOTA_DOCS = 9;
            const double LIMITE_ACEPTABLE =100.0;
            int contador = 1;
            double sumaFolios = 0;
            while (contador <= TOTA_DOCS)
            {
                Console.WriteLine("ingrese la cantidad de folios del documento" + contador);
                double folios = double.Parse(Console.ReadLine());
                sumaFolios += folios;
                

            }
            double promedio= sumaFolios / TOTA_DOCS;
            Console.WriteLine("promedio de folios trancritos" + promedio);
            if(promedio>= LIMITE_ACEPTABLE)
            {
                Console.WriteLine("promedio de folios aceptable en EL ALTO");
            }
            else
            {
                Console.WriteLine("promedio de folios no aceptable en EL ALTO");
            }

        }
    }
}
