#define Trace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Attributes_Test
{
   

    class Program
    {

        static void Main(string[] args)
        {
            //Conditional Attribute 
            Myclass.Message("In Main Fcn");
           Conditional_Attribute.fcn1();
            Console.ReadKey();


            // Obsultue Attribute
            Obsolute_Attribute.Play();
            Obsolute_Attribute.Play1();  // gives warning when u just type the message but gives the error if  u make the second parameter true as in the 3rd calling
           // Obsolute_Attribute.Play2();
        }
    }
}
