using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S1 = {0:#.##}", Formula(a1, b1, c1));
            Console.WriteLine("S2 = {0:#.##}", Formula(a2, b2, c2));
            if (Formula(a1,b1,c1)> Formula(a2,b2,c2))
            {
                Console.WriteLine("S первого треугольника больше");
            }
            else
            {
                Console.WriteLine("S второго треугольника больше");
            }
            Console.ReadKey();
        }
        static double Formula(int a, int b, int c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
    }
}
