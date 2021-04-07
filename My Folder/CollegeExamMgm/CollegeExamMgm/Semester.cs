using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class Semester : ISemester
    {
        public List<Exam> Sem()
        {
            int addSubDtl = 1;
            List<Exam> ObjLE = new List<Exam>();
            while (addSubDtl == 1)
            {
                Exam exam = new Exam();
                Console.Write("Enter Subject Name : ");
                exam.SubName = Console.ReadLine();
                Console.Write("Enter Mark : ");
                exam.SubMarks = Convert.ToInt32(Console.ReadLine());
                ObjLE.Add(exam);
                Console.Write("\nDo you want to add another subject marks (Yes - 1 / No - 0) : ");
                addSubDtl = Convert.ToInt32(Console.ReadLine());
            }
            return ObjLE;
        }
    }
}
