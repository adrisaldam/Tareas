﻿using System;

namespace MdBlackjack
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int cuenta = 0, suma = 0, cartas = 2, jugadores = 0, max = 0, l = 200, lol = 0;
            string continuar = "x", nombre = "", nombre2 = "";

            Console.WriteLine("Bienvenido al Blacjack. Ingrese el número de jugadores a participar: ");
            jugadores = int.Parse(Console.ReadLine());
            while (jugadores > 5 || jugadores < 2)
            {
                Console.WriteLine("Error deben ser mínimo dos jugadores y máximo 5.\n Ingrese número de jugadores: ");
                jugadores = int.Parse(Console.ReadLine());
            }
            string[] player = new string[jugadores];
            double[] diferencia = new double[jugadores];
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("Ingrese el nombre del jugador " + (i + 1));
                player[i] = Console.ReadLine();

            }
                for (int j = 0; j < jugadores; j++)
                {
                    Console.WriteLine("Bienvenido jugador " + player[j]);
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
                        nombre = player[j];
                    }
                    for (int i = 0; i < jugadores; i++)
                    {
                        diferencia[i] = Math.Pow((max - cuenta), 2);
                    if (diferencia[i] < l)
                    {
                        nombre2 = player[j];
                        lol = cuenta;
                        l = (int)diferencia[i];
                    }
                    }

                }
          
                        
            Console.WriteLine($"La mejor puntuación es {max} y es del jugador {nombre}");
            Console.WriteLine("El segundo puesto es para " + nombre2 + " con " + lol + " puntos");
        
        }
    }
}
