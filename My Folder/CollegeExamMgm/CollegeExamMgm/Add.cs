using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Add : IAdd
    {
        public static int primaryKey = 1;
        public static List<Student> StudentDtlList = new List<Student>();

        public void AddOperation(Student request)
        {
            AddStudentDtl(request);
            AddExamDtl(request);
        }

        static AutoIncrement autoIncrement = new AutoIncrement();
        private void AddStudentDtl(Student request)
        {
            request.AutoId = autoIncrement.GenerateId();
            Console.WriteLine("Enter The Students Details");
            Console.WriteLine("Reg. No : " + primaryKey);
            request.StudentRegNo = primaryKey++;
            Console.Write("Student Name : ");
            request.StudentName = Console.ReadLine();
            Console.WriteLine("Date of Birth Details");
            Console.Write("Date  : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year  : ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime dob = new DateTime(year, month, date);
            request.DOB = dob.ToShortDateString();
            Console.Write("Blood Group : ");
            request.BloodGroup = Console.ReadLine();
            Console.Write("City : ");
            request.City = Console.ReadLine();
            Console.Write("Department : ");
            request.Department = Console.ReadLine();
            StudentDtlList.Add(request);
        }
        
        private void AddExamDtl(Student request)
        {
            ISemester Obj = new Semester();
            Console.WriteLine("Enter The Exam Details");
            int addSemDtl = 1;
            int count = 0;
            while (addSemDtl == 1)
            {
                Console.WriteLine($"\nEnter Semester {++count} Details");
                Obj.Sem();
                Console.Write("\nDo you want to add another semester details (Yes - 1 / No - 0) : ");
                addSemDtl = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
