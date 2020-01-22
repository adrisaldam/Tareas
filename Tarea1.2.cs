using System;

namespace Tarea_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Hola, ingresa el valor de 'T' y el ángulo 'A'. " + 
                "Recuerde escribir los datos decimales con coma.");
            Console.WriteLine("Valor de 'T': ");
            double valorT = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de 'A': ");
            double anguloA1 = double.Parse(Console.ReadLine());
            double anguloA = anguloA1 * (Math.PI / 180);

            //Cálculo de datos faltantes
            double ladoY = Math.Round(Math.Sin(anguloA) * valorT);
            Console.WriteLine("El valor del lado 'Y' es: " + ladoY);

            double ladoZ = Math.Round(Math.Cos(anguloA) * valorT);
            Console.WriteLine("El valor del lado 'Z' es: " + ladoZ);

            double anguloC1 = Math.Asin(ladoZ / valorT);
            double anguloC = anguloC1 * 180 / Math.PI;
            Console.WriteLine("El valor del ángulo 'C' es: " + anguloC);
        }
    }
}
