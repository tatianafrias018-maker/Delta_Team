using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_team.ejerccios_1_al_20
{
    public class ejer3
    {
        public static void Main(string[] args)
        {
           const int MIN_LIBROS = 5;
            const int MAX_LIBROS = 400;
            int librosprestados;
            do
            {
                Console.Write("ingrese la cantidad de libros prestados(" + MIN_LIBROS + "a" +MAX_LIBROS + ")");
                librosprestados = int.Parse(Console.ReadLine());
                if( librosprestados < MIN_LIBROS || librosprestados > MAX_LIBROS)
                {
                    Console.WriteLine("error el dato debe estar entre"+MIN_LIBROS+" y "+MAX_LIBROS+"libros");

                }
            }
            while(librosprestados < MIN_LIBROS || librosprestados > MAX_LIBROS);
            Console.WriteLine("dato registrado correctamente"+librosprestados+"libros");
        }
    }
}
