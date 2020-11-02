using System;
namespace ConsoleApp1
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write(Fibonacci(i));
                Console.Write(", ");
            }
            Console.ReadKey();
        }
    }
}
