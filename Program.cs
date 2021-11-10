using System;
namespace TechTask
{
    class Program
    {
        private static void Main(string[] args)
        //- длину сторон треугольника;
        //- является ли треугольник равносторонним;
        //- является ли треугольник равнобедренным;
        //- является ли треугольник прямоугольным;
        //- периметр треугольника;
        //- все чётные числа от 0 до величины периметра треугольника включительно.

        {

            {

                double x1 = -1, y1 = 0;//A
                double x2 = 0, y2 = 3;//B
                double x3 = 2, y3 = 0;//C


                Console.Write("Enter coordinate x of dot A:");
                x1 = double.Parse(Console.ReadLine()!);
                Console.Write("Enter coordinate y of dot A:");
                y2 = double.Parse(Console.ReadLine()!);//A
                Console.Write("Enter coordinate x of dot B:");
                x2 = double.Parse(Console.ReadLine()!);
                Console.Write("Enter coordinate y of dot B:");
                y2 = double.Parse(Console.ReadLine()!);//B
                Console.Write("Enter coordinate x of dot C:");
                x3 = double.Parse(Console.ReadLine()!);
                Console.Write("Enter coordinate y of dot C:");
                y3 = double.Parse(Console.ReadLine()!);//C

                double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double CA = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
                Console.WriteLine("Length of AB is=" + AB);
                Console.WriteLine("Length of BC is=" + BC);
                Console.WriteLine("Length of CA is=" + CA);
                var P = (AB + BC + CA) / 2;
                var result = Math.Sqrt(P * (P - AB) * (P - BC) * (P - CA));
                Console.WriteLine("Perimeter is=" + result);

        
                    if ((AB * AB == BC * BC + CA * CA) || (BC * BC == AB * AB + CA * CA) || (CA * CA == AB * AB + BC * BC)) Console.Write("Triangle is right\n");
                    else if ((AB == BC) && (AB == CA) && (BC == CA)) Console.Write("Triangle is equilateral");
                    else if ((AB == BC) || (AB == CA) || (BC == CA)) Console.Write("Triangle is isosceles");
                    else Console.WriteLine("impossible \n");

                Console.WriteLine("Parity numbers in range  from 0 to triangle perimeter");
                int n = 0;
                for (int i = n; i <= P; i++)
                    if (i % 2 == 0)    
                Console.Write("\n" + i );

            Console.ReadLine();
        
            }
        }
    }
}



      
    