using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Child2 :Parentt
    {
        

        public override void Work1()
        {
            Console.WriteLine("Method Work 1 in child 2 class");
        }

        public override void work2(int id)
        {
            Console.WriteLine("Method work 2 in child 2 class with parameter : {0}", id);
        }
    }
}
