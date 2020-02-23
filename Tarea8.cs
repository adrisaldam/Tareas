using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blacjack2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int cuenta = 0, suma = 0, cartas = 2, jugadores = 0, x = 1, max = 0, nombre = 0;
            string continuar = "x";
            
            
            Console.WriteLine("Bienvenido al Blacjack. Ingrese el número de jugadores a participar: ");
            jugadores = int.Parse(Console.ReadLine());
            while (jugadores > 5 || jugadores < 2)
            {
                Console.WriteLine("Error deben ser mínimo dos jugadores y máximo 5.\n Ingrese número de jugadores: ");
                jugadores = int.Parse(Console.ReadLine());
            }

            while (x <= jugadores)
            {
                Console.WriteLine("Bienvenido jugador " + x);
                cuenta = aleatorio.Next(1, 21);
                Console.WriteLine("Sus primeras dos cartas suman: " + cuenta);
                Console.WriteLine("Si desea más cartas escriba 'si', por el contrario escriba 'no'");
                continuar = Console.ReadLine().ToLower();

                while (continuar != "si" && continuar != "no")
                {
                    Console.WriteLine("Si desea más cartas escriba 'si', por el contrario escriba 'no'");
                    continuar = Console.ReadLine().ToLower();
                }
                cartas = 2;

                while (continuar == "si" && cuenta < 21)
                {
                    suma = aleatorio.Next(1, 11);
                    cartas += 1;
                    Console.WriteLine("A su cuenta se suman " + suma);
                    cuenta = suma + cuenta;
                    Console.WriteLine("Lleva un total de " + cartas + " cartas");
                    if (cuenta == 21) Console.WriteLine("Su cuenta es: " + cuenta + " ¡Felicidades! Ha ganado");
                    if (cuenta > 21)
                    {
                        Console.WriteLine("Usted ha quedado eliminado");
                    }
                    else
                    {
                        Console.WriteLine("Su cuenta actual es " + cuenta + " si desea más cartas escriba 'si', por el contrario escriba 'no'");
                        continuar = Console.ReadLine();                       
                        while (continuar != "si" && continuar != "no")
                        {
                            Console.WriteLine("Si desea más cartas escriba 'si'");
                            continuar = Console.ReadLine().ToLower();
                        }
                    }                  
                }

                Console.WriteLine("Su cuenta total fue: " + cuenta);
                Console.WriteLine("Gracias por participar");
                if (cuenta <= 21 && cuenta > max)
                {
                    max = cuenta;
                    nombre = x;
                }
                x++;
            }
            Console.WriteLine($"La mejor puntuación es {max} y es del jugador {nombre}");
        }
    }
}
