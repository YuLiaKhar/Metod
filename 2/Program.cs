using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int S, V;
            CubeS(a, out S);
            Console.WriteLine("S = {0}", S);
            CubeV(a, out V);
            Console.WriteLine("V = {0}", V);
            Console.ReadKey();
        }
        static void CubeS(int a, out int S)
        {
            S = 6 * a * a;
        }
        static void CubeV(int a, out int V)
        {
            V = a * a * a;
        }
    }
}
