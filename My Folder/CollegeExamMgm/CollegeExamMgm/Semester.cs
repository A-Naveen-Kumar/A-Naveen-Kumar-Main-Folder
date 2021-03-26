using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Semester : ISemester
    {
        List< int> ISemester.Sem1()
        {
            List<int> ListObj = new List<int>();
            Console.WriteLine("Enter The Exam Details");
            Console.Write("Total Number of Subjects in Semester 1 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }

        List<int> ISemester.Sem2()
        {
            List<int> ListObj = new List<int>();
            Console.Write("Total Number of Subjects in Semester 2 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }

        List<int> ISemester.Sem3()
        {
            List<int> ListObj = new List<int>();
            Console.Write("Total Number of Subjects in Semester 3 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }

        List<int> ISemester.Sem4()
        {
            List<int> ListObj = new List<int>();
            Console.Write("Total Number of Subjects in Semester 4 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }

        List<int> ISemester.Sem5()
        {
            List<int> ListObj = new List<int>();
            Console.Write("Total Number of Subjects in Semester 5 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }

        List<int> ISemester.Sem6()
        {
            List<int> ListObj = new List<int>();
            Console.Write("Total Number of Subjects in Semester 6 : ");
            int numOfSub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            for (int i = 1; i <= numOfSub; i++)
            {
                Console.Write("Subject {0} : ", i);
                ListObj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return ListObj;
        }
    }
}
