using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result;

            result= a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, result);

            result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, result);

            Console.Read();
        }
    }
}
