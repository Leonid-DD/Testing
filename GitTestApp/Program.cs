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

            //Addition
            result= a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, result);

            //Substraction
            result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, result);

            //Multiplication
            result = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, result);

            //Division
            result = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, result);

            //Inc
            a++;
            Console.WriteLine(a);

            Console.Read();
        }
    }
}
