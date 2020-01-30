using System;

namespace Tarea2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario exacto");
            int salario = int.Parse(Console.ReadLine());

            if (salario < 1755606)
                Console.WriteLine("Debe pagar la tarifa A que es de 3.400");
            else if (salario >= 1755606 && salario < 4389015)
                Console.WriteLine("Debe pagar la tarifa B que es 13.500");
            else
                Console.WriteLine("Debe pagar la tarifa C que es de 35.600");
        }
    }
}
