#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attributes_Test
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string str)
        {
            Console.WriteLine(str);
        }
    }

     
    class Conditional_Attribute
    {
       public static void fcn1()
        {
            Myclass.Message("In function1");
            fcn2();
        }

       public  static void fcn2()
        {
            Myclass.Message("in Function 2 ");
        }

    }
}
