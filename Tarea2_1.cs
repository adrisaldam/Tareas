using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique su salario mensual exacto");
            int salario = int.Parse(Console.ReadLine());

            if (salario < 1755606)
                Console.WriteLine("Debe pagar la Tarifa A");

            else if (salario >= 1755606 && salario < 3511212)
                Console.WriteLine("Debe pagar la tarifa B");

            else
                Console.WriteLine("Debe pagar la tarifa C");

        }
    }
}
