using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8A
{

    /*
     * Complete the Student class before attempting to complete any of Tests
     * 
     * Notes:
     * 
     * -	Identifiers (method names and variables) are case sensitive. For example,
     *      SetIdNumber is not the same as SetIDNumber. If a specific name is provided, 
     *      you must use the exact name provided.\
     * -	For Tests 4 and 5, before attempting to access a Student class method from 
     *      an array element, you must ensure the array element contains a Student 
     *      object. If the element is null and you attempt to call a member method, the 
     *      program will throw an Exception and crash. To verify the element is not 
     *      empty, compare the element to null – if the element is not null, then it 
     *      contains a valid Student object.
     *       
    */
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student student = new Student(last, first, idNo);
            return student;
        }

        public static Student Test2()
        {
            Student student = new Student();

            return student;
        }

        public static bool Test3(Student enrolled)
        {
            bool IsEnrolled=false;
            for(int i=0;i<enrollment.Length;i++)
            {
                if(enrollment[i] == null)
                {
                    enrollment[i]=enrolled;
                    IsEnrolled=true;
                    break;
                }
            }

            return IsEnrolled;
        }

        public static bool Test4(int idNumber)
        {
            bool WillRemove=false;
            for (int i = 0; i <enrollment.Length;i++)
            {
                if (enrollment[i] != null && enrollment[i].GetIDNumber()==idNumber)
                {
                    enrollment[i]=null;
                    WillRemove=true;
                    break;
                }
            }
            return WillRemove;
        }

        public static Student Test5(int idNumber)
        {
            Student studentname=null;
            for(int i=0;i<enrollment.Length;i++)
            {
                if (enrollment[i]!=null && enrollment[i].GetIDNumber()==idNumber)
                {
                    studentname=enrollment[i];
                    break;
                }
            }
            return studentname;
        }
    }
}
