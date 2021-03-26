using System;
using System.Collections.Generic;

namespace CollegeExamMgm
{
    public class View : IView
    {
        void IView.ViewOperation(List<Student> request)
        {
            ViewStudentDtl(request);
            ViewExamDtl();
        }

        private void ViewStudentDtl(List<Student> request)
        {

            Console.WriteLine("Student Details");

            foreach (var kvp in Add.s1)
            {
                Console.WriteLine("s1 : {0}", kvp);
            }

            foreach (var kvp in Add.s2)
            {
                Console.WriteLine("s2 : {0}", kvp);
            }

            foreach (var kvp in Add.s3)
            {
                Console.WriteLine("s3 : {0}", kvp);
            }

            foreach (var kvp in Add.s4)
            {
                Console.WriteLine("s4 : {0}", kvp);
            }

            foreach (var kvp in Add.s5)
            {
                Console.WriteLine("s5 : {0}", kvp);
            }

            foreach (var kvp in Add.s6)
            {
                Console.WriteLine("s6 : {0}", kvp);
            }

            //foreach (var i in Add.StudentDtlList)
            //{
            //    Console.WriteLine(i.Key,i.Value);
            //    Console.Write("\nSI. No : " + i.StudentRegNo + ", Name : " + i.StudentName + ", DOB : " + i.DOB +
            //                  ", BloodGroup : " + i.BloodGroup + ", City : " + i.City + ", Department : " + i.Department);
            //}
        }

        private void ViewExamDtl()
        {
            
        }
    }
}
