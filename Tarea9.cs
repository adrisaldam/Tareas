using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArreglos
{
    class Program
    {
        static void Main()
        {
            double[] CoordX = new double[4];
            CoordX[0] = 0;
            CoordX[1] = 2;
            CoordX[2] = 3;
            CoordX[3] = 7;

            double[] CoordY = new double[4];
            CoordY[0] = 0;
            CoordY[1] = 1;
            CoordY[2] = 5;
            CoordY[3] = 6;
           
            double pendiente1 = (CoordY[1] - CoordY[0]) / (CoordX[1] - CoordX[0]);
            double pendiente2 = (CoordY[3] - CoordY[2]) / (CoordX[3] - CoordX[2]);

            
            if (pendiente1 == pendiente2) Console.WriteLine("Son una línea recta");
            else Console.WriteLine("No son línea recta");

            double distancia1 = Math.Sqrt((Math.Pow(CoordX[1] - CoordX[0], 2)) + (Math.Pow(CoordY[1] - CoordY[0], 2)));
            double distancia2 = Math.Sqrt((Math.Pow(CoordX[3] - CoordX[2], 2)) + (Math.Pow(CoordY[3] - CoordY[2], 2)));

            if (distancia1 > distancia2) Console.WriteLine("La distancia mayor es la de (X1,Y1) a (X2,Y2).\nEs igual a = " + distancia1);
            else Console.WriteLine("La distancia mayor es la de (X3,Y3) a (X4,Y4).\n Es igual a = " + distancia2);
        }
    }
}
