using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.WriteLine("Введiть змiнну типу int");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введiть змiнну типу double");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введiть змiнну типу long");
                long c = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"a = {a}; b = {b}; c = {c}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неправильний тип данних");
            }
        }
    }
}
