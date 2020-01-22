using System;

namespace Tarea_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Hola, ingresa el valor de 'Z' y el ángulo 'C'. " +
                "Recuerde escribir los datos decimales con coma.");
            Console.WriteLine("Valor de 'Z': ");
            double valorZ = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de 'C': ");
            double anguloC1 = double.Parse(Console.ReadLine());
            double anguloC = anguloC1 * (Math.PI / 180);

            //Cálculo de datos faltantes
            double ladoT = valorZ / Math.Sin(anguloC);
            Console.WriteLine("El valor del lado 'Y' es: " + ladoT);

            double ladoY = Math.Round(valorZ / Math.Tan(anguloC));
            Console.WriteLine("El valor del lado 'T' es: " + ladoY);

            double anguloA1 = Math.Asin(ladoY / ladoT);
            double anguloA = anguloA1 * 180 / Math.PI;
            Console.WriteLine("El valor del ángulo 'A' es: " + anguloA);
        }
    }
}
