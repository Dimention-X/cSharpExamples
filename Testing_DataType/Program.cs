using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diff_Btn_Cts_Tostrig();
            //Escape_Secquence_Char_test();
            


        }

        private static void Escape_Secquence_Char_test()
        {
            Console.Write("\r asdghad ");
            Console.WriteLine("\v testing slash verbose");

            Console.WriteLine("\b testing slash backslash");

            Console.WriteLine("\t testing slash tab ");

            Console.Write("\n new line \\n"); Console.WriteLine();
            string path = @"C:\data";

            Console.WriteLine(path);
        }

        private static void Diff_Btn_Cts_Tostrig()
        {      // difference between string and tostring
            int? n = null;  // custom nullable 
            int n1 = 23;    // tostring is good here 
            object b = null;  // but for null Convert.tostring is best .
            Console.WriteLine(n.ToString());     
            Console.WriteLine(n1.ToString());
            Console.WriteLine(Convert.ToString(b));
        }
    }
}
