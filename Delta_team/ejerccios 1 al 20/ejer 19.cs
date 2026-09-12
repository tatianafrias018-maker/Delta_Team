using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public   class ejer_19
    {
        public static void Main(string[] args)
        {
            const int RECURSOS_INICIALES = 3;
            const int PUNTOS_INTENSIVA = 1200;
            const int PUNTOS_PREVENTIVA = PUNTOS_INTENSIVA / 2;
            const int META_PUNTOS = 20000;

            int recursos = RECURSOS_INICIALES;
            int puntos = 0;
            bool seRetiro = false;

            // Condicion de salida: Se detiene si recursos <= 0, puntos >= META_PUNTOS o seRetiro es true.
            do
            {
                Console.WriteLine("\nRecursos disponibles: " + recursos + " | Puntos acumulados: " + puntos);
                Console.WriteLine("Estrategia: 1) Intensiva (+1200 pts, -1 rec), 2) Preventiva (+600 pts, 0 rec), 3) Retirarse");
                Console.Write("Elija opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    puntos += PUNTOS_INTENSIVA;
                    recursos--;
                    Console.WriteLine("Intervencion intensiva realizada.");

                    if (recursos == 1)
                    {
                        Console.WriteLine("¡ADVERTENCIA: Queda solo 1 recurso disponible!");
                    }
                }
                else if (opcion == 2)
                {
                    puntos += PUNTOS_PREVENTIVA;
                    Console.WriteLine("Intervencion preventiva realizada.");
                }
                else if (opcion == 3)
                {
                    seRetiro = true;
                    Console.WriteLine("La brigada decidio retirarse.");
                }
                else
                {
                    Console.WriteLine("Estrategia invalida.");
                }
            }
            while (recursos > 0 && puntos < META_PUNTOS && !seRetiro);

            Console.WriteLine("-- RESULTADO FINAL CAMPANA EMAPA ---");
            Console.WriteLine("Puntaje obtenido: " + puntos);

            if (puntos >= 15000)
            {
                Console.WriteLine("Clasificacion: ABASTECIDA");
            }
            else if (puntos >= 8000)
            {
                Console.WriteLine("Clasificacion: AJUSTADA");
            }
            else
            {
                Console.WriteLine("Clasificacion: EN RIESGO");
            }
        }
    }
}
