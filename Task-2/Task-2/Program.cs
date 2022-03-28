using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Num ededin daxil edin:");
            int num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsEven(num));


            Console.WriteLine("Num1 ededin daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsOdd(num1));
        }

        public static bool IsEven(int num)
        {
          return num % 2 == 0;  

        }

        public static bool IsOdd(int num1)
        {
            return num1 % 2 == 1;
        }
    }
}
