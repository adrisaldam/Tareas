using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Hola, ingresa el valor de 'Y' y 'Z'");
            Console.WriteLine("Valor de 'Y': ");
            double valorZ = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de 'Z': ");
            double valorY = double.Parse(Console.ReadLine());

            //Cálculo de datos faltantes
            double valorT = Math.Sqrt((valorZ) * (valorZ) + (valorY) * (valorY));
            Console.WriteLine("El valor de 'T' es: " + valorT);

            double anguloC1 = Math.Asin(valorY / valorT);
            double anguloC = anguloC1 * 180 / Math.PI; 
            Console.WriteLine("El valor del ángulo 'C' es: " + anguloC);

            double anguloA1 = Math.Asin(valorZ / valorT);
            double anguloA = anguloA1 * 180 / Math.PI;
            Console.WriteLine("El valor del ángulo 'A' es: " + anguloA);
            
        }
    }
}
