using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;   // imp 1

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string classname1 = Console.ReadLine();
            
            Type objtype = Type.GetType("ConsoleApplication1." + classname1);
            Console.WriteLine(objtype);
            object a = Activator.CreateInstance(objtype);

            //Type[] parameter=  new Type[1];
            //parameter[0] = Type.GetType("System.Int32");

            int id1 = Convert.ToInt32(Console.ReadLine());
            object[] id = new object[1];
            id[0] = id1;    
           
            //MethodInfo mi = objtype.GetMethod("work2",new Type[1] { Type.GetType("System.Int32")});
            MethodInfo mi = objtype.GetMethod("DoSomething");
            mi.Invoke(a, null);
        }
    }
}
