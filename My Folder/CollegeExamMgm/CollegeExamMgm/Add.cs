using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    public class Add : IAdd
    {
        public static int primaryKey = 1;
        static Dictionary<int, Student> StudentDtlList = new Dictionary<int, Student>();

        void IAdd.AddOperation(Student request)
        {
            AddStudentDtl(request);
            AddExamDtl();
        }

        private void AddStudentDtl(Student request)
        {
            Console.WriteLine("Enter The Students Details");
            Console.WriteLine("SI. No : " + primaryKey);
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
            StudentDtlList.Add(primaryKey, request);
        }

        //public static Dictionary<int, int> ExamList = new Dictionary<int, int>();
        public static List<int> s1, s2, s3, s4, s5, s6;
        private void AddExamDtl()
        {
            ISemester Obj = new Semester();

            s1 = Obj.Sem1();
            s2 = Obj.Sem2();
            s3 = Obj.Sem3();
            s4 = Obj.Sem4();
            s5 = Obj.Sem5();
            s6 = Obj.Sem6();

            //var s1 = Obj.Sem1();
            //var s2 = Obj.Sem1();
            //var s3 = Obj.Sem1();
            //var s4 = Obj.Sem1();
            //var s5 = Obj.Sem1();
            //var s6 = Obj.Sem1();

            //foreach (var i in s1)
            //{
            //    Console.WriteLine(i);
            //}

            //ExamList.Add(Obj.Sem1());
            //ExamList.Add(Obj.Sem2());
            //ExamList.Add(Obj.Sem3());
            //ExamList.Add(Obj.Sem4());
            //ExamList.Add(Obj.Sem5());
            //ExamList.Add(Obj.Sem6());
        }
    }
}
