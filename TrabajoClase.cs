using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main()
        {
            int max = 0, min = 500, total = 0;
            double promedio = 0, m = 0, p = 0, l = 600;
            string ganador = "", perdedor = "", cercano = "";
            Console.WriteLine("Ingrese el número de datos");
            int n = int.Parse(Console.ReadLine());

            string[] nombre = new string[n];
            int[] edades = new int[n];
            double[] distancia = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el nombre del la persona " + (i + 1));
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de esta persona");
                edades[i] = int.Parse(Console.ReadLine());

                if (edades[i] > max)
                {
                    max = edades[i];
                    ganador = nombre[i];
                }
                if (edades[i] < min)
                {
                    min = edades[i];
                    perdedor = nombre[i];
                }

                total += edades[i];
                promedio = ((double)total) / n;          
                                             
            }

            for (int i = 0; i < n; i++)
            {
                double k = Math.Pow((edades[i] - promedio), 2);
                p += k;
                m = Math.Sqrt(p / n);
            }

            for (int i = 0; i < n; i++)
            {
                distancia[i] = Math.Pow((promedio - edades[i]),2);
                if (distancia[i] < l)
                {
                    cercano = nombre[i];
                    l = distancia[i];
                }
                
            }

            Console.WriteLine("El de mayor edad es " + ganador + ". Su edad es " + max);
            Console.WriteLine("El de menor edad es " + perdedor + ". Su edad es " + min);

            Console.WriteLine("El promedio de edades es " + promedio);
            Console.WriteLine("La desviación estándar es " + m);
            Console.WriteLine("La personas más cercana al promedio es " + cercano);
        }
    }
}
