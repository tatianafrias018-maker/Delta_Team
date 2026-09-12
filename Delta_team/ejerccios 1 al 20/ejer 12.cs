using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer_12
    {
        public static void Main(string[] args)
        {
            const int TOTAL_REGISTROS = 7;
            const int LIMITE_ALTO = 300;
            const int LIMITE_MEDIO = 120;

            int contConfirmados = 0;
            int contPendientes = 0;

            // Condicion de salida: Se detiene cuando i excede TOTAL_REGISTROS .
            for (int i = 1; i <= TOTAL_REGISTROS; i++)
            {
                Console.Write("Ingrese cantidad de registros historicos digitalizados #" + i + ": ");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad >= LIMITE_ALTO)
                {
                    Console.Write("¿Fue verificado en campo? (1 = Si, 2 = No): ");
                    int verificado = int.Parse(Console.ReadLine());

                    if (verificado == 1)
                    {
                        Console.WriteLine("-> DIGITALIZACION ALTA CONFIRMADO");
                        contConfirmados++;
                    }
                    else
                    {
                        Console.WriteLine("-> DIGITALIZACION ALTA PENDIENTE");
                        contPendientes++;
                    }


                }
                else if (cantidad >= LIMITE_MEDIO)
                {
                    Console.WriteLine("-> DIGITALIZACION MEDIA");

                }
                else
                {
                    Console.WriteLine("-> DIGITALIZACION BAJA");
                }
            }
            Console.WriteLine("Total de digitalizaciones altas confirmadas: " + contConfirmados);
            Console.WriteLine("Total de digitalizaciones altas pendientes: " + contPendientes);
        }
    }
}