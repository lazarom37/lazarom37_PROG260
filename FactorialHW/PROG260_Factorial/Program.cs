using System;

namespace PROG260_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer between 1-10: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factor(n));

        }

        public static int factor(int n)
        {
            if (n > 0)
            {
                return n * factor(n - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}

//Created by Marcus Lazaro, Fall 2022