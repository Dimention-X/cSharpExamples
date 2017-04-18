using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class MyException : Exception
    {
        public MyException(string str)
        {
             Console.WriteLine("my Custom Exception from the class");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            UserDefinedExceptions();
            throwingExceptionprgra();

        }

        private static void UserDefinedExceptions()
        {
            try
            {
                throw new MyException("haha");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here" + e.ToString());
            }

            finally { Console.WriteLine("akhilesh"); }
        }

        private static void throwingExceptionprgra()
        {
            int x = 9;
            try
            {
                if (x % 0 == 0)
                    throw new DivideByZeroException("invalid diviion");
                else
                    Console.WriteLine("mni hua bc");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
