using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8._1
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, x = 1, treses = 0;
            string continuar = "";

            Console.WriteLine("Ingrese el número de jugadores");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Ingrese el número de jugadores");
                n = int.Parse(Console.ReadLine());
            }

            while (x <= n)
            {
                Console.WriteLine("Bienvenido jugador " + x);
                Console.WriteLine("¿Desea jugar? (s/n)");
                continuar = Console.ReadLine();

                while (continuar!="s" && continuar != "n")
                {
                    Console.WriteLine("Error. Responda lo indicado. ¿Desea jugar? (s/n)");
                    continuar = Console.ReadLine();
                }
                total = 0;

                while (continuar == "s" && total < 100)
                {
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine("El dado a sumado " + dado);
                    total = dado + total;

                    if (dado == 3)
                    {
                        treses++;
                    }
                    else treses = 0;

                    if (treses == 3)
                    {
                        Console.WriteLine("Usted ha perdido");
                        continuar = "n";
                    }
                    if (total >= 100)
                    {
                        Console.WriteLine("Has ganado");
                        continuar = "n";
                    }
                    if (total < 100 && continuar == "s")
                    {
                        Console.WriteLine("Su total actual es " + total);
                        Console.WriteLine("¿Desea seguir jugando? (s/n)");
                        continuar = Console.ReadLine();

                        while (continuar != "s" && continuar != "n")
                        {
                            Console.WriteLine("Error. Responda lo indicado. ¿Desea seguir jugando? (s/n)");
                            continuar = Console.ReadLine();
                        }
                    }

                }
                Console.WriteLine("Gracias  por jugar. Su total fue " + total);
                x++;                
            }
            Console.WriteLine("Juego terminado");

        }
    }
}
