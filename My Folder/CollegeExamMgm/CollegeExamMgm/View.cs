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
            for (int i = 0; i < Add.StudentDtlList.Count; i++)
            {
                Console.WriteLine("\nAutoId: " + Add.StudentDtlList[i].AutoId + ", Reg.No : " + Add.StudentDtlList[i].StudentRegNo + ", Name: " + Add.StudentDtlList[i].StudentName + ", DOB: " + Add.StudentDtlList[i].DOB + ", BloodGroup : " + Add.StudentDtlList[i].BloodGroup + ", City : " + Add.StudentDtlList[i].City + ", Department : " + Add.StudentDtlList[i].Department);// +" "+ Semester.ExamDtl[i].SubName + " : " + Semester.ExamDtl[i].SubMarks);

                for (int j = 0; j < Semester.ExamDtl.Count; j++)
                {
                    Console.WriteLine(Semester.ExamDtl[j].SubName + " : " + Semester.ExamDtl[j].SubMarks);
                }
            }
        }

        private void ViewExamDtl(List<Student> request)
        {
        }
    }
}
