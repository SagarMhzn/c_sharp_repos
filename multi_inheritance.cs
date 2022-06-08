using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public interface Compute1
    {
        void findsum(int x, int y);
        void finddifference(int x, int y);
    }

    public interface Compute2
    {
        void findDivision(int x, int y);
        void findModulo(int x, int y);
    }

    class practical : Compute1, Compute2
    {
        public void finddifference(int x, int y)
        {
            Console.WriteLine("the differnce is " + (x - y));
        }

        public void findDivision(int x, int y)
        {
            Console.WriteLine("the division is "+(x/y));
        }

        public void findModulo(int x, int y)
        {
            Console.WriteLine("the modulus is " + (x % y));
        }

        public void findsum(int x, int y)
        {
            Console.WriteLine("the sum is "+(x+y));
        }
    }
}
