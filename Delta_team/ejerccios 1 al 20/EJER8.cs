using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class EJER8
    {
     public static void Main(string[] args)
        {
            //total fijo de las parcelas
            const int TOTAL_PARCELAS = 5;
            int contador = 1;
            int contMañana=0;
            int contTarde = 0;
            //se detiene al sobrepasar TOTAL_PARCELAS
            while(contador <= TOTAL_PARCELAS)
            {
                Console.WriteLine("ingrese el numero correlativo de parcelas" + contador);
                int numParcela = int.Parse(Console.ReadLine());
                if(numParcela%2==0)
                {
                    Console.WriteLine("-> Turno de la Mañana(par)");
                    contMañana++;
                }
                else
                {
                    Console.WriteLine("-> Turno de la Tarde(impar)");
                    contTarde++;
                }
                contador++;
            }
             Console.WriteLine("total de parcelas con turno de la Mañana" + contMañana);
                Console.WriteLine("total de parcelas con turno de la Tarde" + contTarde);
        }
    }
}
