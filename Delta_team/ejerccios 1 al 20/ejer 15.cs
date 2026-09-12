using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer_15
    {
        public static void Main(string[]args)
        {
            const int CODIGO_CORRECTO = 2023;
            const int MAX_INTENTOS = 4;

            int intentosRestantes = MAX_INTENTOS;
            bool accesoConcedido = false;

            // Condicion de salida: Se detiene cuando no quedan intentos o cuando accesoConcedido es true.
            do
            {
                Console.Write("Ingrese el codigo de acceso (Intentos restantes " + intentosRestantes + "): ");
                int codigoIngresado = int.Parse(Console.ReadLine());

                if (codigoIngresado == CODIGO_CORRECTO)
                {
                    accesoConcedido = true;
                    Console.Write("Ingrese nivel de permiso (1 = Consulta, 2 = Edicion): ");
                    int nivel = int.Parse(Console.ReadLine());

                    if (nivel == 1)
                    {
                        Console.WriteLine("Acceso Concedido: Modo CONSULTA activado.");
                    }
                    else if (nivel == 2)
                    {
                        Console.WriteLine("Acceso Concedido: Modo EDICION activado.");
                    }
                    else
                    {
                        Console.WriteLine("Acceso Concedido: Nivel no reconocido, asignado modo Lectura basica.");
                    }
                }
                else
                {
                    intentosRestantes--;
                    if (intentosRestantes > 0)
                    {
                        Console.WriteLine("Codigo incorrecto.");
                    }
                }
            }
            while (intentosRestantes > 0 && !accesoConcedido);

            if (!accesoConcedido)
            {
                Console.WriteLine("¡Cuenta bloqueada! Ha agotado sus " + MAX_INTENTOS + " intentos.");
            }
        }
    }
        
    
}

