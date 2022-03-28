using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            AddElement(ref array);
            
        }

        public static void AddElement(ref int [] array)
        {
           
            Array.Resize(ref array, array.Length+1);
            array[array.Length - 1] = 8;
            foreach (var Number in array)
            {
                Console.WriteLine(Number);
            }

        }
        
    }
}
