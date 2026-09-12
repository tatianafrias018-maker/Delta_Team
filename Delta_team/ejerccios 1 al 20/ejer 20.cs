using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public   class ejer_20
    {
        public static void Main(string[] args)
        {
            const int CANTIDAD_CENTROS = 5;
            const int MIN_DOSIS = 10;
            const int MAX_DOSIS = 800;
            const int DOSIS_POR_JORNADA = 250;
            const int OPCION_SALIR = 4;

            int opcionMenu;
            int totalDosisCargadas = 0;
            bool datosCargados = false;

            // Condicion de salida: Se detiene cuando el usuario selecciona la opcion 4.
            do
            {
                Console.WriteLine("'= SISTEMA INTEGRADO SEDES BENI ===");
                Console.WriteLine("1) Carga de centros de salud");
                Console.WriteLine("2) Reporte de clasificacion");
                Console.WriteLine("3) Simulacion de cobertura");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    totalDosisCargadas = 0;

                   
                    for (int i = 1; i <= CANTIDAD_CENTROS; i++)
                    {
                        int dosis;

                        // Condicion de salida: Repite validacion hasta ingresar dosis entre 10 y 800.
                        do
                        {
                            Console.Write("Centro " + i + " - Ingrese dosis aplicadas (" + MIN_DOSIS + " a " + MAX_DOSIS + "): ");
                            dosis = int.Parse(Console.ReadLine());

                            if (dosis < MIN_DOSIS || dosis > MAX_DOSIS)
                            {
                                Console.WriteLine("  Error: Valor fuera de rango.");
                            }
                        }
                        while (dosis < MIN_DOSIS || dosis > MAX_DOSIS);

                        totalDosisCargadas += dosis;
                    }

                    datosCargados = true;
                    Console.WriteLine("-> Carga completada. Total dosis: " + totalDosisCargadas);
                }
                else if (opcionMenu == 2)
                {
                    if (datosCargados)
                    {
                        double promedio = (double)totalDosisCargadas / CANTIDAD_CENTROS;
                        Console.WriteLine("Promedio de dosis por centro: " + promedio);

                        if (promedio >= 500)
                        {
                            Console.WriteLine("Clasificacion: COBERTURA OPTIMA");
                        }
                        else if (promedio >= 200)
                        {
                            Console.WriteLine("Clasificacion: COBERTURA REGULAR");
                        }
                        else
                        {
                            Console.WriteLine("Clasificacion: COBERTURA BAJA");
                        }
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Primero debe realizar la Carga de Centros (Opcion 1).");
                    }
                }
                else if (opcionMenu == 3)
                {
                    if (datosCargados)
                    {
                        int dosisRestantes = totalDosisCargadas;
                        int jornadasCovers = 0;

                        while (dosisRestantes >= DOSIS_POR_JORNADA)
                        {
                            dosisRestantes -= DOSIS_POR_JORNADA;
                            jornadasCovers++;
                        }

                        Console.WriteLine("Simulacion: Las dosis cargadas cubren " + jornadasCovers + " jornadas completas (Sobrante: " + dosisRestantes + " dosis).");
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Primero debe realizar la Carga de Centros (Opcion 1).");
                    }
                }
                else if (opcionMenu == OPCION_SALIR)
                {
                    Console.WriteLine("Resumen de la sesion: Total de dosis procesadas = " + totalDosisCargadas);
                    Console.WriteLine("Cerrando sistema SEDES Beni...");
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
            while (opcionMenu != OPCION_SALIR);
        }
    }
    
}
