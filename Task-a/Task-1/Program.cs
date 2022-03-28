using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamal Abishli" ,20,"P204");
            Console.WriteLine(student._fullname);
            Console.WriteLine(student._groupno);
        }

        
    }
}
