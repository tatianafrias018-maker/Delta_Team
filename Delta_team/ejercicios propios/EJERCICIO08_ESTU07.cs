using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejercicios_propios
{
    public class EJERCICIO08_ESTU07
    {
        public static void Main(string[] args)
        {
           const int TOTAL_CURSOS = 6;
            int contador = 1;
            int pares = 0; 
            int impares = 0;

            while (contador <= TOTAL_CURSOS)

            {
                Console.WriteLine("Cursos " + contador + ": ");
                int cantidadAlumnos = int.Parse(Console.ReadLine());

                if (cantidadAlumnos % 2 == 0)

                {
                    Console.WriteLine("El turno mañana " + cantidadAlumnos + " es par");
                    pares++;

                }

                else
                
                {
                    Console.WriteLine("El turno tarde " + cantidadAlumnos + " es impar");
                    impares++;

                }
                contador++;
            }
            Console.WriteLine("");
            Console.WriteLine("Cursos turno mañana (pares) : " + pares);
            Console.WriteLine("Cursos turno tarde (impares) : " + impares);

        }
    }

}
