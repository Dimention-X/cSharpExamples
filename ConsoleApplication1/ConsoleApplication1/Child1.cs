using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Child1 :Parentt
    {
        public override void Work1()
        {
            Console.WriteLine("Mthord work 1 in Child1 class");
        }

        public override void work2(int id)
        {
            Console.WriteLine("Method work 2 in child1 classs with patermeter : {0}", id);
        }

    }
}
