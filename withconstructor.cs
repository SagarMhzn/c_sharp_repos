using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    //metgod overloading example

    class Calculation
    {
        public void calc(int a, int b)
        {
            //if int value is passed it will add the two inputs

            Console.WriteLine("the sum is" + (a + b));
        }

        public void calc(double d1,double d2)
        {
            Console.WriteLine("multiplication is " + (d1 * d2));
        }
    }
}
