using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public class PropertyExample
    {
        private int num1;
        private int num2;

        public int Num1 { get { return num1; } set { num1 = value; } }
        public int Num2 { get { return num2; } set { num2 = value; } }

        public void display()
        {
            Console.WriteLine((num1 + num2));
        }
    }
}
