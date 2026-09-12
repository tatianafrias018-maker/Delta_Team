using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO06_ESTU07
    {
        public static void Main(string[] args)

        {
            const int RESERVA_INICIAL = 900;
            const double PORCENTAJE_ALERTA = 20;
            int jornadas = 0;
            int reserva = RESERVA_INICIAL;

            Console.WriteLine("Ingrese la cantidad de postulantes entregadas por jornadas");
            int entrega = int.Parse(Console.ReadLine());

            while (reserva > 0)

            {
                jornadas = jornadas + 1;
                reserva = reserva - entrega;

                if (reserva < 0) ;

                {
                    reserva = 0;
                }
                Console.WriteLine("Jornada", jornadas, "reserva restante: ", reserva);

                if (reserva < RESERVA_INICIAL * PORCENTAJE_ALERTA && reserva > 0) ;

                {
                    Console.WriteLine("**ALERTA DE RESERVA BAJA**");
                }


            }
            Console.WriteLine("");
            Console.WriteLine("La reserva duro: ", jornadas, " jornadas");
        }
    }

}
