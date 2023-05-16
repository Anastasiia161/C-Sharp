using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Задание 1
            Console.WriteLine("Введите число от 1 до 100:");
            var num = int.Parse(Console.ReadLine());
            if (num >= 0 || num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("Fizz Buzz");
                else if (num % 3 == 0) Console.WriteLine("Fizz");
                else if (num % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(num);
            }
            else Console.WriteLine("Error");
            Console.WriteLine();


            //Задание 2
            Console.WriteLine("Введите число и %, который необходимо посчитать от этого числа:");
            var value = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            double result = value * (percent / 100);
            Console.WriteLine(percent + "% от " + value + " = " + result);
            Console.WriteLine();

            //Задание 3
            Console.WriteLine("Введите два числа");
            var value1 = int.Parse(Console.ReadLine());
            var value2 = int.Parse(Console.ReadLine());
            void swap(ref int a, ref int b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (value1 > value2) swap(ref value1, ref value2);
            for (var i = value1; i <= value2; ++i)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
