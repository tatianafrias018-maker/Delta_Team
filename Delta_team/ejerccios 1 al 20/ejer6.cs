using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer6
    {
        public static void Main(string[] args)
        {
            const double RESERVA_INICIAL = 500.0;
            const double PORCENTAJE_ALERTA = 0.20;
            const double LIMITE_ALERTA=RESERVA_INICIAL * PORCENTAJE_ALERTA;

            double reservaactual=RESERVA_INICIAL;
            int jornadas = 0;
            bool alerta=false;
            Console.WriteLine("ingrese la cantidad a entregar por jornada");
            double entregaFija= double.Parse(Console.ReadLine());
            //condicion de salida se detiene cuando reservaActual llega a 0 o un valor negativo
            while(reservaactual > 0)
            {
                reservaactual -= entregaFija;
                jornadas++;
                if(reservaactual <0) reservaactual=0;

                 Console.WriteLine("jornada" + jornadas + "reserva restante" + reservaactual);
                 if(reservaactual < LIMITE_ALERTA && !alerta)
                 {
                   Console.WriteLine("¡alerta!la reserva ha bajado del 20% del total ("+ LIMITE_ALERTA+") ");
                   alerta = true;

                 }
               
            }
            Console.WriteLine("la reserva se agoto Duracion total"+jornadas+"jornadas");
        }
    }
}
