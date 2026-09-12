using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO04_ESTU07
    {
        public static void Main(string[] args)
        {
            const int SALIR = 4;
            int opcion;

            do

            {
                Console.WriteLine("----------------------"); 
                Console.WriteLine("-MENU DE OPCIONES-");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Ver el registro de unidades educativas");
                Console.WriteLine("2. Ver la meta del periodo");
                Console.WriteLine("3. Ver el rango valido de estudiantes que abandonaron el año");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {

                    Console.WriteLine("Mostrando el registro de unidades educativas...");
                }

                else if (opcion == 2) 

                {
                        Console.WriteLine("Mostrando la meta del periodo...");
                }

                else if (opcion == 3)

                {
                    Console.WriteLine("Mostrando el rango valido de estudiantes que abandonaron el año...");
                }

                else if (opcion == SALIR)

                {
                    Console.WriteLine("Saliendo del programa...");
                }

                else

                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                }
            }
            while (opcion != SALIR);
        }
    }
}