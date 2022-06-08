using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public class Student
    {
        private int roll;
        private string name;
        private string address;
        private string gender;
        private string faculty;

       public Student()
        {
            Console.WriteLine("This is default Constructor");
        }
       public Student(int r, string n,string a, string g, string f)
        {
            roll = r;
            name = n;
            address = a;
            gender = g;
            faculty = f;
        }

        public void displayInfo()
        {
            Console.WriteLine("The student's roll no. is"+ roll);
            Console.WriteLine("The student's name is" + name);
            Console.WriteLine("The student's address is" + address);
            Console.WriteLine("The student's gender is" + gender);
            Console.WriteLine("The student's faculty is" + faculty);
        }
    }
}
