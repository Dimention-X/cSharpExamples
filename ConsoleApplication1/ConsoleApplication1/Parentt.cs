using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Parentt
    {
        public void DoSomething()
        {
            Work1();
            work2(23);
        }
        
        public virtual void  Work1()
        {
            Console.WriteLine("Calling the simpleprocess method without parameter");
        }

        public virtual void work2(int id)
        {
            Console.WriteLine("Calling the SimpleProcess method with parameter : {0}",id);
        }
    }
}
