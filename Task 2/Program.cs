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

            Console.WriteLine("Введіть змінну типу int");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            

            if ((a.GetType().ToString() != "System.Int32"))
            {
                Console.WriteLine("Данні введені невірно");
                Environment.Exit(0);
            }


            Console.WriteLine("Введіть змінну типу double");
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            if ((b.GetType().ToString() != "System.Double"))
            {
                Console.WriteLine("Данні введені невірно");
                Environment.Exit(0);
            }


            Console.WriteLine("Введіть змінну типу long");
            Console.Write("c = ");
            long c = Convert.ToInt64(Console.ReadLine());

            if ((c.GetType().ToString() != "System.Int64"))
            {
                Console.WriteLine("Данні введені невірно");
                Environment.Exit(0);
            }


            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
