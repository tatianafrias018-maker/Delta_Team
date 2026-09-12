using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer_17
    {
        static void Main(string[] args)
        {

            const int CENTINELA = -1;
            const double LIMITE_OPTIMO = 18.0;
            const double LIMITE_REGULAR = 10.0;

            int contadorBarrios = 0;
            double sumaHoras = 0;

            Console.Write("Ingrese horas de servicio de agua del barrio (-1 para terminar): ");
            double horas = double.Parse(Console.ReadLine());

            // Condicion de salida: Se detiene cuando horas es igual al CENTINELA (-1).
            while (horas != CENTINELA)
            {
                sumaHoras += horas;
                contadorBarrios++;

                Console.Write("ingrese horas de servicio de agua del siguiente barrio(-1 para terminar");
                horas = double.Parse(Console.ReadLine());
            }
            if (contadorBarrios > 0)
            {
                double promedio = sumaHoras / contadorBarrios;
                Console.WriteLine("Barrios cargados: " + contadorBarrios);
                Console.WriteLine("Suma total de horas: " + sumaHoras);
                Console.WriteLine("Promedio de servicio: " + promedio + " hrs/dia");

                if (promedio >= LIMITE_OPTIMO)
                {
                    Console.WriteLine("Clasificacion General: SERVICIO OPTIMO");
                }
                else if (promedio >= LIMITE_REGULAR)
                {
                    Console.WriteLine("clasificacion : SERVICIO REGURAL");

                }
                else
                {
                    Console.WriteLine("clasificacion:SERVICIO CRITICO");

                }

            }
            else 
            {
                Console.WriteLine("no se ingresaron datos para procesar");
            }
        }
    }
}
