using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            string[] palabras = frase.Split(' ');
            bool hallada = false;
            int n = 0;
            int[] pos = new int[palabras.Length];

            for (int i = 0; i < palabras.Length ; i++) {
                if (palabra == palabras[i])
                {
                    hallada = true;
                    n++;
                    pos[i] = i + 1;
                    Console.WriteLine("Se econtró la palabra");
                    Console.WriteLine("La palabra fue encontrada en la posición " + pos[i]);
                }
                if (n != 0 && i == palabras.Length-1)
                {
                    Console.WriteLine("La palabra se encontró " + n + " veces");
                }
            }
            if (hallada != true)
            {
                Console.WriteLine("No se encontró la palabra");
            }
        }
    }
}
