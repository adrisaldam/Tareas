using System;

namespace Tarea1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule el valor mediante triángulos");
            Console.WriteLine("Ingrese el valor del lado Z del triángulo 1");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado Y del triángulo 1");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del ángulo B el triángulo 2");
            double b = double.Parse(Console.ReadLine());

            double bgrados = b  * (Math.PI / 180);

            double a = Math.Atan(y / z);
            double f = a + b;

            double g = z * Math.Tan(f);
            double x = g - y;

            Console.WriteLine("El lado X mide: " + x);
        }
    }
}
