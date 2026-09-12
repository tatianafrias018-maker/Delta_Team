using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer_11
    {
        public static void Main(string[] args)
        {
             const int SALIR = 3;   
            int opcionPrincipal;
             int contUrgentes =0;
            //condicion de salida se detiene cuando opcionPrincipal es igual a SALIR
            do
            {
                Console.WriteLine("1)registrar objeto");
                Console.WriteLine("2)consultar meta ");
                Console.WriteLine("3)salir");
                Console.Write("ingrese una opcion");
                opcionPrincipal = int.Parse(Console.ReadLine());
                
                if(opcionPrincipal == 1)
                {
                    Console.WriteLine("1) Zona Norte");
                    Console.WriteLine("2) Zona Sur");
                    Console.Write("ingrese una opcion");
                    int zona = int.Parse(Console.ReadLine());
                    if(zona==1||zona==2)
                    {
                        Console.Write("es registro urgente ?(1=si,2=no)");
                        int urgente = int.Parse(Console.ReadLine());
                        if(urgente==1)
                        {
                            Console.WriteLine("registro urgente guardado");
                            contUrgentes++;
                        }
                        else if (urgente==2)
                        {
                            Console.WriteLine("registro normal guardado");
                        }
                        else
                        {
                            Console.WriteLine("opcion invalida");
                        }
                    }
                    else 
                    { 
                        Console.WriteLine(" Zona invalida");
                    }   
                }
                else if(opcionPrincipal== 2)
                {
                    Console.WriteLine("meta el periodo inventarias 150 objetos historicos");
                }
                else if (opcionPrincipal == 3)
                {
                    Console.WriteLine("total de registros urgentes realizados " + contUrgentes);
                }
                else
                {
                    Console.WriteLine("opcion invalida");
                }
            }
            while (opcionPrincipal != SALIR);
        }
    }
}