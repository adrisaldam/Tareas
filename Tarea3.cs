using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese los votos del partido A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos del partido B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos en blanco");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la población que es mayor de edad");
            double p = double.Parse(Console.ReadLine());

            double g = a - b;
            if (g < 0) g = b - a;

            bool A = a + b + c + anulados> n;
            bool B = g < 0.10 * a + b + c + anulados;
            bool C = a + b + c + anulados < 0.30 * n;
            bool D = a > b;
                       
            if ((A || B) && (C))
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            } else
            {
                if (D) Console.WriteLine("El ganador es el partido A"); else Console.WriteLine("El ganador es el partido B");               
            }
        }
    }
}
