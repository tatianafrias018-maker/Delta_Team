using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer4
    {
        public static void Main(string[] args)
        {
          //OPCION_SALIR: Es constante para evitar "números mágicos" y fijar de forma inmutable el código numérico de término de sesión.//
          const int OPCION_SALIR=4;
            int opcion;
            
              //*CONDICIÓN DE SALIDA DEL CICLO DO - WHILE://
               //*La condición de repetición del menú es(opcion != OPCION_SALIR).//
               //*La CONDICIÓN DE SALIDA ocurre de manera explícita cuando el usuario ingresa el entero 4.//
            do
            {
                Console.WriteLine("Menu de consultar FPS");
                Console.WriteLine("1.) ver el riesgo de comunidades");
                Console.WriteLine("2.) ver la meta del periodo");
                Console.WriteLine("3.)ver el rango valido de familas con bano ecologico instalado");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese una opcion:");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("registro de cumunidades: 12 comunidades activas");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("meta del periodo:500 familias benefisiadas");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("rango valido de familias con bano ecologico : 10 a 100 familias");
                }
                else if (opcion == OPCION_SALIR)
                {
                    Console.WriteLine("saliendo del sistema FPS");
                }
                else
                {
                  Console.WriteLine("opcion invalida, por favor ingrese una opcion valida");
                }
            } while (opcion != OPCION_SALIR);

        }
    }
}
