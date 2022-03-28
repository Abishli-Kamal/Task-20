using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word();
        }

        public static void Word()
        {
            string sentence = "Tasklar bizi bozaga yigib";
            int index = sentence.IndexOf(' ');
            index = sentence.IndexOf(' ', index);
            string result = sentence.Substring(0, index);
            Console.WriteLine(result);

        }
    }
}
