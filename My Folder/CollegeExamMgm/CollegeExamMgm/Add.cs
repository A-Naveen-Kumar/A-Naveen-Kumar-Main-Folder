using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Add : IAdd
    {
        public static int primaryKey = 1;
        static AutoIncrement autoIncrement = new AutoIncrement();
        static AutoIncrement autoIncrement1 = new AutoIncrement();
        public static Dictionary<int, Student> StudentDtlList = new Dictionary<int, Student>();
        public static Dictionary<int, List<Exam>> ExamDtl = new Dictionary<int, List<Exam>>();

        public void AddOperation(Student request)
        {
            AddStudentDtl(request);
            AddExamDtl(request);
        }

        private void AddStudentDtl(Student request)
        {
            Console.WriteLine("Enter The Students Details");
            Console.WriteLine("Reg. No : " + primaryKey);
            request.StudentRegNo = primaryKey++;
            Console.Write("Student Name : ");
            request.StudentName = Console.ReadLine();
            Console.Write("Date of Birth Details (DD-MM-YYYY) : ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            request.DOB = dob.ToShortDateString();
            Console.Write("Blood Group : ");
            request.BloodGroup = Console.ReadLine();
            Console.Write("City : ");
            request.City = Console.ReadLine();
            Console.Write("Department : ");
            request.Department = Console.ReadLine();
            StudentDtlList.Add(autoIncrement.GenerateId(), request);
        }

        private void AddExamDtl(Student request)
        {
            ISemester Obj = new Semester();
            Console.WriteLine("Enter The Exam Details");
            int addSemDtl = 1;
            int count = 0;
            var a = new List<Exam>();
            while (addSemDtl == 1)
            {
                Console.WriteLine($"\nEnter Semester {++count} Details");
                a.AddRange(Obj.Sem());
                Console.Write("\nDo you want to add another semester details (Yes - 1 / No - 0) : ");
                addSemDtl = Convert.ToInt32(Console.ReadLine());
            }
            ExamDtl.Add(autoIncrement1.GenerateId(), a);
        }
    }
}
