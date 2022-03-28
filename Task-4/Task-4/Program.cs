using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(CountWords());
            Console.WriteLine(Upper());
        }

        public static int CountWords()
        {
            string sentence = "Task Uzundu";
            var wordCount=0;
            for (var i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' || i == sentence.Length - 1)
                {
                      wordCount++;
                  
                }

            }
            return wordCount;
        }
        public static bool Upper()
        {
            string sentence = "Task Uzundu";
            int counter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]) && i == 0)
                {
                    counter++;

                }
                else if (char.IsWhiteSpace(sentence[i]))
                {
                    counter++;
                    if (char.IsUpper(sentence[i + 1]))
                    {
                        counter++;
                    }
                }  

            }
            return counter ==3? true:false;
        }
    }
}

