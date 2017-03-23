using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Transformas (int x);                                  //Anonymous Methods
namespace cSharpExamples
{
    class TestDelegate
        {
        static int num = 10;
        public static void AddNum(int p)
            {
              num+= p;
              Console.WriteLine("num method add :{0}", num);
            }
        public static void Multi(int p)
            {
               num*= p;
            Console.WriteLine("num method add : {0}", num); 
            }
        public static int getnum()
            {
            return num;
            }

        }

    class Program
    {
        static void Main()
        { 
        
           Transformas sqrmulten= delegate(int x)
           {
            Console.WriteLine("Anonymous Method {0}",x); };

           sqrmulten(10);
            sqrmulten = new Transformas(AddNum());
            sqrmulten(20);
            sqrmulten = new Transformas(Multi());
            Console.Read();
        
        }
    }
}
