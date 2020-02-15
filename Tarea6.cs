using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnDado
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, lanzamientos = 0, jk = 0, total = 0;
            string continuar = "s";

            while (continuar == "s" && total < 100)
            {
                dado = aleatorio.Next(1, 13);
                total = dado + total;
                lanzamientos++;
                bool C = 0 != dado % 2;
                Console.WriteLine("El valor del dado fue: " + dado);

                if (dado == 10)
                {
                    jk++;
                }
                else jk = 0;
                if (jk == 1 && dado == 12)
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
                else jk = 0;
                if (C && lanzamientos > 3)
                {
                    Console.WriteLine("Usted ha perdido");
                    continuar = "n";
                }
                if (total < 100 && continuar == "s")
                {
                    Console.WriteLine("Su total actual es: " + total);
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                }
                else continuar = "n";
            }
            Console.WriteLine("El juego ha finalizado, su total fue: " + total);

        }
    }
}
