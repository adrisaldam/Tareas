using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int cuenta = 0, suma = 0, cartas = 2;
            string continuar = "x", repetir = "continuar";
          
            while (repetir == "continuar")
            {
                cartas = 2;
                Console.WriteLine("Bienvenido al Blacjack, recibe dos cartas");
                cuenta = aleatorio.Next(1, 21);
                Console.WriteLine("Sus primeras dos cartas suman: " + cuenta);
                Console.WriteLine("Si desea más cartas escriba 'si'");
                continuar = Console.ReadLine();

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
                    }else
                        {
                            Console.WriteLine("Su cuenta actual es " + cuenta + " si desea más cartas escriba 'si'");
                            continuar = Console.ReadLine();
                        }                        
                    }

                    Console.WriteLine("Su cuenta total fue: " + cuenta);
                    Console.WriteLine("Gracias por participar");
                    Console.WriteLine("Si desea volver a jugar escriba 'continuar'");
                    repetir = Console.ReadLine();                
                }    
        }
    }
}
