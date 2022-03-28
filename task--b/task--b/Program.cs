using System;

namespace task__b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Checkout());
        }
        public static bool Checkout()
        {
            string Sentence = "Muellim 5 den cox task verib";
            bool isdigit = false;
            bool isupper = false;
            bool islower = false;

            for (int i = 0; i < Sentence.Length; i++)
            {
                if (char.IsDigit(Sentence[i]))
                {
                    isdigit = true;
                    continue;
                }
                if (char.IsUpper(Sentence[i]))
                {
                    isupper = true;
                    continue;
                }
                if (char.IsLower(Sentence[i]))
                {
                    islower = true;
                }
            }
            bool result = islower && isdigit && isupper;
            return result;

        }
    }
}
