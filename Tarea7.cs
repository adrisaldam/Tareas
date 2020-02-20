using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, dado2 = 0, lanzamientos = 0, vidas = 3, total = 0;
            string continuar = "";
            Console.WriteLine("Desea jugar? (s/n)");
            continuar = Console.ReadLine();

            while (vidas > 0 && total < 100 && continuar == "s")
            {
                lanzamientos++;
                bool A = lanzamientos % 3 == 0;
                bool B = lanzamientos % 2 == 0;

                if (A)
                {
                    dado = aleatorio.Next(5, 7);
                    dado2 = aleatorio.Next(5, 7);
                    total = dado + dado2 + total;
                    Console.WriteLine("El dado1 ha sumado " + dado);
                    Console.WriteLine("El dado2 han sumado " + dado2);
                }else
                {
                    dado = aleatorio.Next(1, 7);
                    total = dado + total;
                    Console.WriteLine("El dado ha sumado " + dado);
                }
                if (B)
                {
                    vidas--;
                    Console.WriteLine("Ha perdido una vida. Vidas: " + vidas);
                }
                if (dado == dado2 && A)
                {
                    Console.WriteLine("Has ganado");
                    continuar = "n";
                }
                if (vidas <= 0)
                {
                    Console.WriteLine("Has perdido");
                    continuar = "n";
                }
                if (total < 100 && vidas > 0 && continuar == "s")
                {
                    Console.WriteLine("Lleva un total de " + total + ". Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                }

            }
            if (total > 100) Console.WriteLine("Has ganado");
            Console.WriteLine("Se acabó el juego");
            

        }
    }
}
