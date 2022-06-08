using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public interface Calc
    {
        void getMultiplication(int a, int b);
        void getDifference(int a, int b);
        void getSum(int a, int b);
    }

    public class Demo : Calc
    {
        public void getDifference(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine("the difference is "+diff);
        }

        public void getMultiplication(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine("the product is "+mul);
        }

        public void getSum(int a, int b)
        {
            int sum = a +b;
            Console.WriteLine("the sum is "+sum);
        }
    }
    internal class @interface
    {
    }
}
