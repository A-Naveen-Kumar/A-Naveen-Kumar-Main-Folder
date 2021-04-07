using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Semester : ISemester
    {
        public static AutoIncrement autoIncrement = new AutoIncrement();
        public static List<Exam> ExamDtl = new List<Exam>();
        public void Sem()
        {
            int addSubDtl = 1;
            while (addSubDtl == 1)
            {
                Exam exam = new Exam();
                Exam.AutoId = autoIncrement.GenerateId();
                Console.Write("Enter Subject Name : ");
                exam.SubName = Console.ReadLine();
                Console.Write("Enter Mark : ");
                exam.SubMarks = Convert.ToInt32(Console.ReadLine());
                ExamDtl.Add(exam);
                Console.Write("\nDo you want to add another subject marks (Yes - 1 / No - 0) : ");
                addSubDtl = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
