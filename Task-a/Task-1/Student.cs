using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    internal class Student
    {
        public string _fullname;
        public int Age;
        public string _groupno;

        public string GroupNo
        {
            get
            {
                return _groupno;
            }

            set
            {
                if (CheckGroup(value))
                {
                    _groupno = value;
                }
                else
                {
                    Console.WriteLine(" Group uygun deyil");
                }
            }
        }

        public string Fullname
        {
            get
            {
                return _fullname;
            }

            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
                else
                {
                    Console.WriteLine(" Fullname uygun deyil");
                }



            }
        }


        public Student(string fullname, int age, string _group)
        {
            Fullname = fullname;
            Age = age;
            GroupNo = _group;

        }

        public static bool CheckGroup(string gr)
        {

            if (gr.Length == 4)
            {
                bool hasdigit = false;
                bool hasUpper = false;

                foreach (char item in gr)
                {
                    if (char.IsDigit(item))
                    {
                        hasdigit = true;
                        continue;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;

                    }
                }
                bool result = hasUpper && hasdigit;
                return result;
            }
            return false;


        }
        public static bool CheckFullname(string Fl)
        {


            int count = 0;
            for (int i = 0; i < Fl.Length; i++)
            {
                if (char.IsUpper(Fl[i])&&i==0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(Fl[i]))
                {
                    count++;

                    if (char.IsUpper(Fl[i + 1]))
                    {
                        count++;
                    }

                }
                
            }
            return count==3 ?true :false;
        }

    }
}
