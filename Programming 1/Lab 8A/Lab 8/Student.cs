using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8A
{
    public class Student
    {
        // Add member fields here
        private string lastname;
        private string firstname;
        private int IDNO;

        // Add default and overloaded constructors here
        public Student()
        {
            lastname = "";
            firstname = "";
            IDNO = 1000000;
        }
        public Student(string last,string first,int idNo)
        {
             lastname=last;
             firstname=first;
             IDNO = idNo;
        }



        // add Getters and Setters here

        public string GetLastName()
        { return lastname; }
        public string GetFirstName()
        { return firstname; }
        public int GetIDNumber()
        { return IDNO; }

        public void SetFirstName(string FirstName)

        {
            firstname = FirstName;
        }
        public void SetLastName(string LastName)
        {
            lastname = LastName;
        }
        public void SetIDNumber(int IDNumber)
        {
            IDNO = IDNumber;
        }




















        /******************************************************************************************************
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                      do not modify any of the following code                                        *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        *                                                                                                     *
        ******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
