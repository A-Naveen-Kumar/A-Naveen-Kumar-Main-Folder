using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    class View : IView
    {
        public void ViewOperation(List<Student> request)
        {
            ViewStudentDtl(request);
            ViewExamDtl(request);
        }

        private void ViewStudentDtl(List<Student> request)
        {
            Console.WriteLine("Student Details");
            for (int i = 1; i <= Add.StudentDtlList.Count; i++)
            {
                Console.WriteLine("\nReg.No : " + Add.StudentDtlList[i].StudentRegNo + ", Name : " + Add.StudentDtlList[i].StudentName + ", DOB : " + Add.StudentDtlList[i].DOB + ", BloodGroup : " + Add.StudentDtlList[i].BloodGroup + ", City : " + Add.StudentDtlList[i].City + ", Department : " + Add.StudentDtlList[i].Department);
                foreach (var item in Add.ExamDtl[i])
                {
                    Console.WriteLine(item.SubName +" : " + item.SubMarks);
                }
            }
        }

        private void ViewExamDtl(List<Student> request)
        {
        }
    }
}
