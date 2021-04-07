using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("     Welcome to \"The NAVEEN College\"");
            int i = 0;
            while (i != 4)
            {
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("Operations");
                Console.WriteLine("1 - Add Student Details and Marks");
                Console.WriteLine("2 - View Students Details and Marks");
                Console.WriteLine("3 - Update Students Details and Marks");
                Console.WriteLine("4 - Exit");
                Console.Write("Your Choice : ");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*****************************************");
                switch (i)
                {
                    case 1:
                        {
                            Student request = new Student();
                            IAdd Add = new Add();
                            Add.AddOperation(request);
                            break;
                        }
                    case 2:
                        {
                            List<Student> request = new List<Student>();
                            IView View = new View();
                            View.ViewOperation(request);
                            break;
                        }
                    case 3:
                        {
                            Student request = new Student();
                            IUpdate Update = new Update();
                            Update.UpdateOperation(request);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Exited.");
                            Console.WriteLine("*****************************************");
                            break;
                        }
                }
            }
        }
    }
}
