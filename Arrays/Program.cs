using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1) BasicPorpOfArryClass();

           // 2) Methods_Of_Array

            int[] k = new int[5] { 12, 34, 55, 56,45 };

            foreach (var item in k)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------===========");

            // copy array (sorce, destination , integer)

            int[] kcopy = new int[10];
            Array.Copy(k, kcopy, 5);

            foreach (var item in kcopy)
            {
                Console.WriteLine(" new copied array");
                Console.WriteLine(item);
            }

            Console.WriteLine("==================================");

            //  srot arry

            Array.Sort(k);
            foreach (var item in k)
            {
                Console.WriteLine(item);
            }


            // parameter as a array
            paramArry("Askas","ghgssdfhg","aghgdh","ahgdfha");

            // array as a paramter
            ArryasParameter(k);


        }

        private static void BasicPorpOfArryClass()
        {
            int[] k = new int[3];

            Console.WriteLine(k.Length);
            Console.WriteLine(k.Rank);
        }

        private static void paramArry(params string[] cities)
        {
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }

        private static void ArryasParameter(int[] jk)
        {
            foreach (var item in jk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
