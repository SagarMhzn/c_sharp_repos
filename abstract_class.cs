using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    public abstract class AbstractDemo1
    {
        public abstract void findModulus(int x, int y);
        public void findNormalDIvision(int a,int b)
        {
            Console.WriteLine("normal division is " + (a / b));
        }
    }

    class PracticalDemo : AbstractDemo1
    {
        public override void findModulus(int x, int y)
        {
            Console.WriteLine("mdoulus division is " + (x % y));
        }
    }
}
