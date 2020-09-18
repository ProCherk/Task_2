using System;

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

            Console.WriteLine("Введіть змінну типу double");
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Введіть змінну типу long");
            Console.Write("c = ");
            long c = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
